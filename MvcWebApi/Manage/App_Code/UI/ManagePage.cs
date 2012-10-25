using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SASCMS;
using System.Threading;
using System.Globalization;
using System.Reflection;

namespace SASCMS.UI
{
    /// <summary>
    /// PageBase 的摘要说明
    /// </summary>
    public class ManagePage : AdminPage
    {
        protected string keyWord;
        protected string tableName;
        protected string delTableName;
        protected string selColumn;
        protected string tableKey;
        protected string searchColumn;
        protected Panel plEdit;
        protected Panel plList;
        protected Wuqi.Webdiyer.AspNetPager CtrlPager;
        protected GridView GridView1;
        protected TextBox txtKeyWord;
        protected string assemblyName = "";
        protected string orderBy = "UPDATE_ON DESC";
        //protected asp

        protected void Page_Load(object sender, EventArgs e)
        {
            //CheckLogin();

            string strMailType = Request.QueryString["t"];
            if (!Page.IsPostBack)
            {
                if (strMailType != null)
                {
                    GetListByType(strMailType);
                }
                else
                {
                    GetListByType("list");
                }
            }
        }
        protected void btnDelete_Click1(object sender, EventArgs e)
        {
            delModel(getSelectedIds());

            string strMailType = Request.QueryString["t"];
            if (strMailType != null)
            {
                GetListByType(strMailType);
            }
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            GetListByType("list");
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //if (e.Row.RowType == DataControlRowType.DataRow)
            //{
            //    e.Row.Cells[4].Visible = false;
            //}
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            string strMailType = Request.QueryString["t"];
            if (strMailType != null)
            {
                GetListByType(strMailType);
            }
        }

        protected virtual void GetListByType(string strType)
        {
            string strSql = "select * from " + tableName + " where " + searchColumn + " like '%" + keyWord + "%'";
            string strFilter = " 1=1 ";

            switch (strType)
            {
                case "list":
                    if(txtKeyWord!=null)
                    {
                        keyWord = txtKeyWord.Text;
                    }
                    if (keyWord.Trim().Length > 0)
                    {
                        strFilter = searchColumn + " like '%" + keyWord + "%' ";
                    }
                    GetTable(strFilter, strSql);
                    break;
                case "mod":
                    plEdit.Visible = true;
                    plList.Visible = false;
                    GetModel(Request.QueryString["id"]);
                    break;
                case "add":
                    plEdit.Visible = true;
                    plList.Visible = false;
                    break;
            }

        }

        protected void GetTable(string strFileter, string strSql)
        {
            CtrlPager.RecordCount = Maticsoft.DBUtility.DbHelperMySQL.Query(strSql).Tables[0].Rows.Count; //SASCMS.DBUtility.DbHelperSQL.Query(strSql).Tables[0].Rows.Count;
            CtrlPager.PageSize = 10;

            int cruPage = this.CtrlPager.CurrentPageIndex - 1;
            DataTable dt = SASCMS.BaseFunction.getDateByPager(tableName, tableKey, string.IsNullOrEmpty(selColumn)?"*":selColumn, this.CtrlPager.PageSize.ToString(), cruPage.ToString(), strFileter, "", orderBy, false).Tables[0];

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void GetModel(string id)
        {
            Assembly assembly = Assembly.Load("BLL");
            Assembly assemblyModel = Assembly.Load("Model");

            Object obj = assembly.CreateInstance("sharejoy.BLL.shareBll");
            Object objModel = assemblyModel.CreateInstance("sharejoy.Model.share");

            Type t = obj.GetType();
            Type tModel = objModel.GetType();

            objModel=t.GetMethod("GetModel").Invoke(obj, new Object[] { int.Parse(id) });
            //PropertyInfo[] properties = t.GetProperties();

            foreach (Control ctrl in plEdit.Controls)
            {
                if (!string.IsNullOrEmpty(ctrl.ID))
                {
                    PropertyInfo p = tModel.GetProperty(ctrl.ID);
                    if (p != null)
                    {
                        Object objValue = p.GetValue(objModel, null);
                        if (objValue != null)
                        {
                            string ctrlType = ctrl.GetType().ToString();
                            if (ctrlType.IndexOf("TextBox") != -1)
                            {
                                ((TextBox)ctrl).Text = objValue.ToString();
                            }
                            if (ctrlType.IndexOf("DropDownList") != -1)
                            {
                                ListItem li = ((DropDownList)ctrl).Items.FindByValue(objValue.ToString());
                                if (li != null)
                                {
                                   ((DropDownList)ctrl).Items.FindByValue(objValue.ToString()).Selected=true;
                                }
                            }
                            if (ctrlType.IndexOf("FCKeditor") != -1)
                            {
                                //((FredCK.FCKeditorV2.FCKeditor)ctrl).Value = objValue.ToString();
                            }
                        }
                    }

                }
            }
        }

        //获得选中的ID
        protected string getSelectedIds()
        {
            string ids = "";

            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox cb = (CheckBox)GridView1.Rows[i].Cells[0].FindControl("CheckBox1");
                if (cb.Checked)
                {
                    ids = ids + GridView1.DataKeys[i].Value+",";
                }
            }
            return ids;
        }

        //删除信息
        protected void delModel(string id)
        {
            if (id.Length != 0)
            {
                id = id.TrimEnd(',');
                string[] ids = id.Split(',');
                string strSql = "delete from " + (string.IsNullOrEmpty(delTableName) ? tableName : delTableName) + " where " + tableKey + "=";
                for (int i = 0; i < ids.Length ; i++)
                { 
                    Maticsoft.DBUtility.DbHelperMySQL.ExecuteSql(strSql + ids[i]);
                }

                alert("删除成功！");
            }
            else
            {
                alert("请至少选择一项！");
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Request.Params["t"] != null && CheckBeforeSave())
            {
                if (Request.Params["t"] == "mod")
                {
                    AddOrUpdateModel();
                    alert("修改成功!");
                }
                if (Request.Params["t"] == "add")
                {
                    AddOrUpdateModel();
                    alert("添加成功!");
                }

                AfterSave();
            }
        }
        

        protected void AddOrUpdateModel()
        {
            Assembly assembly = Assembly.Load("BLL");
            Assembly assemblyModel = Assembly.Load("Model");

            Object obj = assembly.CreateInstance("sharejoy.BLL.shareBll");
            Object objModel = assemblyModel.CreateInstance("sharejoy.Model.share");

            Type t = obj.GetType();
            Type tModel = objModel.GetType();


            if (Request.QueryString["t"] == "mod")
            {
                objModel=t.GetMethod("GetModel").Invoke(obj, new object[] { int.Parse(Request.Params["id"]) });
            }

            //PropertyInfo[] properties = t.GetProperties();
            
            PropertyInfo p;
            foreach (Control ctrl in plEdit.Controls)
            {
                if (!string.IsNullOrEmpty(ctrl.ID))
                {
                    p = tModel.GetProperty(ctrl.ID);
                    Object objValue=new Object();
                    if (ctrl.GetType().ToString().IndexOf("TextBox")!=-1)
                    {
                        TextBox txt = (TextBox)ctrl;
                        objValue = txt.Text;
                    }
                    if (ctrl.GetType().ToString().IndexOf("DropDownList") != -1)
                    {
                        DropDownList ddl = (DropDownList)ctrl;
                        objValue = ddl.SelectedValue;
                    }
                    if (ctrl.GetType().ToString().IndexOf("FCKeditor") != -1)
                    {
                        //FredCK.FCKeditorV2.FCKeditor fck = (FredCK.FCKeditorV2.FCKeditor)ctrl;
                        //objValue = fck.Value;
                    }

                    if (p != null)
                    {
                        Type pt = p.PropertyType;
                        if (pt.ToString().ToLower().IndexOf("nullable") == -1)
                        {
                            objValue = Convert.ChangeType(objValue, pt);
                        }
                        else
                        {
                            if (pt.ToString().ToLower().IndexOf("int") != -1)
                            {
                                objValue = Convert.ToInt32(objValue);
                            }
                        }

                        p.SetValue(objModel, objValue, null);
                    }
                }
            }

            if (Request.QueryString["t"] == "add")
            {
                p = tModel.GetProperty("create_date");
                if (p != null)
                {
                    p.SetValue(objModel, DateTime.Now, null);
                }
                p = tModel.GetProperty("create_user");
                if (p != null)
                {
                    p.SetValue(objModel, "admin", null);
                }
                t.GetMethod("Add").Invoke(obj, new object[] { objModel });
            }
            else
            {
                p = tModel.GetProperty("update_date");
                if (p != null)
                {
                    p.SetValue(objModel, DateTime.Now, null);
                }
                t.GetMethod("Update").Invoke(obj, new object[] { objModel });
            }
        }
        
        protected virtual bool CheckBeforeSave()
        {
            return true;
        }

        protected virtual void AfterSave()
        {
            ;
        }
    }
}
