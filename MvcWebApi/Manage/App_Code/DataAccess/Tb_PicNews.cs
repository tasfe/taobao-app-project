using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using SASCMS.DBUtility;
namespace SASCMS.DataAccess
{
    /// <summary>
    /// 类TB_PicNews。
    /// </summary>
    public class TB_PicNews
    {
        public TB_PicNews()
        { }
        #region Model
        private string _title;
        private string _pic_url;
        private string _url;
        private DateTime _updateon;
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Pic_Url
        {
            set { _pic_url = value; }
            get { return _pic_url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Url
        {
            set { _url = value; }
            get { return _url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime UpdateOn
        {
            set { _updateon = value; }
            get { return _updateon; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public TB_PicNews(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [Title],[Pic_Url],[Url],[UpdateOn],[ID] ");
            strSql.Append(" FROM TB_PicNews ");
            strSql.Append(" where [ID]=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Title = ds.Tables[0].Rows[0]["Title"].ToString();
                Pic_Url = ds.Tables[0].Rows[0]["Pic_Url"].ToString();
                Url = ds.Tables[0].Rows[0]["Url"].ToString();
                if (ds.Tables[0].Rows[0]["UpdateOn"].ToString() != "")
                {
                    UpdateOn = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateOn"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_PicNews");
            strSql.Append(" where [ID]=@ID ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_PicNews(");
            strSql.Append("[Title],[Pic_Url],[Url],[UpdateOn])");
            strSql.Append(" values (");
            strSql.Append("@Title,@Pic_Url,@Url,@UpdateOn)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Title", OleDbType.VarChar,0),
					new OleDbParameter("@Pic_Url", OleDbType.VarChar,0),
					new OleDbParameter("@Url", OleDbType.VarChar,0),
					new OleDbParameter("@UpdateOn", OleDbType.Date)};
            parameters[0].Value = Title;
            parameters[1].Value = Pic_Url;
            parameters[2].Value = Url;
            parameters[3].Value = UpdateOn;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [TB_PicNews] set ");
            strSql.Append("[Title]=@Title,");
            strSql.Append("[Pic_Url]=@Pic_Url,");
            strSql.Append("[Url]=@Url,");
            strSql.Append("[UpdateOn]=@UpdateOn");
            strSql.Append(" where [ID]=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Title", OleDbType.VarChar,0),
					new OleDbParameter("@Pic_Url", OleDbType.VarChar,0),
					new OleDbParameter("@Url", OleDbType.VarChar,0),
					new OleDbParameter("@UpdateOn", OleDbType.Date),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = Title;
            parameters[1].Value = Pic_Url;
            parameters[2].Value = Url;
            parameters[3].Value = UpdateOn;
            parameters[4].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TB_PicNews ");
            strSql.Append(" where [ID]=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [Title],[Pic_Url],[Url],[UpdateOn],[ID] ");
            strSql.Append(" FROM TB_PicNews ");
            strSql.Append(" where [ID]=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.Title = ds.Tables[0].Rows[0]["Title"].ToString();
                this.Pic_Url = ds.Tables[0].Rows[0]["Pic_Url"].ToString();
                this.Url = ds.Tables[0].Rows[0]["Url"].ToString();
                if (ds.Tables[0].Rows[0]["UpdateOn"].ToString() != "")
                {
                    this.UpdateOn = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateOn"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    this.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TB_PicNews ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere,int top)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top "+top+" * ");
            strSql.Append(" FROM TB_PicNews ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  成员方法
    }
}

