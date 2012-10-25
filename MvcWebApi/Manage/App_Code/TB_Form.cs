using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using SASCMS.DBUtility;//�����������
namespace SASCMS.DAL
{
    /// <summary>
    /// ��TB_Form��
    /// </summary>
    public class TB_Form
    {
        public TB_Form()
        { }
        #region Model
        private int _formid;
        private string _itemlist;
        private string _formname;
        private DateTime _adddate;
        /// <summary>
        /// 
        /// </summary>
        public int FormID
        {
            set { _formid = value; }
            get { return _formid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ItemList
        {
            set { _itemlist = value; }
            get { return _itemlist; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FormName
        {
            set { _formname = value; }
            get { return _formname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime AddDate
        {
            set { _adddate = value; }
            get { return _adddate; }
        }
        #endregion Model


        #region  ��Ա����

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int FormID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_Form");
            strSql.Append(" where FormID=" + FormID + " ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@FormID", OleDbType.Integer,4)				};
            parameters[0].Value = FormID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_Form(");
            strSql.Append("ItemList,FormName,AddDate)");
            strSql.Append(" values (");
            strSql.Append("@ItemList,@FormName,@AddDate)");
            OleDbParameter[] parameters = {
					//new OleDbParameter("@FormID", OleDbType.Integer,4),
					new OleDbParameter("@ItemList", OleDbType.VarChar,0),
					new OleDbParameter("@FormName", OleDbType.VarChar,0),
					new OleDbParameter("@AddDate", OleDbType.Date)};
            //parameters[0].Value = FormID;
            parameters[0].Value = ItemList;
            parameters[1].Value = FormName;
            parameters[2].Value = AddDate;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_Form set ");
            //strSql.Append("FormID=@FormID,");
            strSql.Append("ItemList=@ItemList,");
            strSql.Append("FormName=@FormName,");
            strSql.Append("AddDate=@AddDate");
            strSql.Append(" where FormID=" + FormID + " ");
            OleDbParameter[] parameters = {
					//new OleDbParameter("@FormID", OleDbType.Integer,4),
					new OleDbParameter("@ItemList", OleDbType.VarChar,0),
					new OleDbParameter("@FormName", OleDbType.VarChar,0),
					new OleDbParameter("@AddDate", OleDbType.Date)};
           // parameters[0].Value = FormID;
            parameters[0].Value = ItemList;
            parameters[1].Value = FormName;
            parameters[2].Value = AddDate;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int FormID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TB_Form ");
            strSql.Append(" where FormID=" + FormID + " ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@FormID", OleDbType.Integer,4)				};
            parameters[0].Value = FormID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public void GetModel(int FormID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select FormID,ItemList,FormName,AddDate ");
            strSql.Append(" FROM TB_Form ");
            strSql.Append(" where FormID=" + FormID + " ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@FormID", OleDbType.Integer,4)				};
            parameters[0].Value = FormID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["FormID"].ToString() != "")
                {
                    FormID = int.Parse(ds.Tables[0].Rows[0]["FormID"].ToString());
                }
                ItemList = ds.Tables[0].Rows[0]["ItemList"].ToString();
                FormName = ds.Tables[0].Rows[0]["FormName"].ToString();
                if (ds.Tables[0].Rows[0]["AddDate"].ToString() != "")
                {
                    AddDate = DateTime.Parse(ds.Tables[0].Rows[0]["AddDate"].ToString());
                }
            }
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [FormID],[ItemList],[FormName],[AddDate] ");
            strSql.Append(" FROM TB_Form ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  ��Ա����
    }
}

