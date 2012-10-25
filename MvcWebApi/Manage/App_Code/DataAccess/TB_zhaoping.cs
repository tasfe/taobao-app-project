using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using SASCMS.DBUtility;//请先添加引用
namespace JSFT.DAL
{
    /// <summary>
    /// 类tb_zhaoping。
    /// </summary>
    public class tb_zhaoping
    {
        public tb_zhaoping()
        { }
        #region Model
        private string _zpid;
        private string _zpzhiwei;
        private string _peoplenum;
        private string _reqiment;
        private DateTime _updatedate;
        /// <summary>
        /// 
        /// </summary>
        public string ZpID
        {
            set { _zpid = value; }
            get { return _zpid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZpZhiWei
        {
            set { _zpzhiwei = value; }
            get { return _zpzhiwei; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PeopleNum
        {
            set { _peoplenum = value; }
            get { return _peoplenum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Reqiment
        {
            set { _reqiment = value; }
            get { return _reqiment; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime UpDateDate
        {
            set { _updatedate = value; }
            get { return _updatedate; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tb_zhaoping(string ZpID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ZpID,ZpZhiWei,PeopleNum,Reqiment,UpDateDate ");
            strSql.Append(" FROM tb_zhaoping ");
            strSql.Append(" where ZpID=@ZpID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ZpID", OleDbType.VarChar,50)};
            parameters[0].Value = ZpID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ZpID = ds.Tables[0].Rows[0]["ZpID"].ToString();
                ZpZhiWei = ds.Tables[0].Rows[0]["ZpZhiWei"].ToString();
                PeopleNum = ds.Tables[0].Rows[0]["PeopleNum"].ToString();
                Reqiment = ds.Tables[0].Rows[0]["Reqiment"].ToString();
                if (ds.Tables[0].Rows[0]["UpDateDate"].ToString() != "")
                {
                    UpDateDate = DateTime.Parse(ds.Tables[0].Rows[0]["UpDateDate"].ToString());
                }
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ZpID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_zhaoping");
            strSql.Append(" where ZpID=@ZpID ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@ZpID", OleDbType.VarChar,50)};
            parameters[0].Value = ZpID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_zhaoping(");
            strSql.Append("ZpID,ZpZhiWei,PeopleNum,Reqiment,UpDateDate)");
            strSql.Append(" values (");
            strSql.Append("@ZpID,@ZpZhiWei,@PeopleNum,@Reqiment,@UpDateDate)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ZpID", OleDbType.VarChar,50),
					new OleDbParameter("@ZpZhiWei", OleDbType.VarChar,50),
					new OleDbParameter("@PeopleNum", OleDbType.VarChar,50),
					new OleDbParameter("@Reqiment", OleDbType.VarChar,50),
					new OleDbParameter("@UpDateDate", OleDbType.Date)};
            parameters[0].Value = ZpID;
            parameters[1].Value = ZpZhiWei;
            parameters[2].Value = PeopleNum;
            parameters[3].Value = Reqiment;
            parameters[4].Value = UpDateDate;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_zhaoping set ");
            strSql.Append("ZpID=@ZpID,");
            strSql.Append("ZpZhiWei=@ZpZhiWei,");
            strSql.Append("PeopleNum=@PeopleNum,");
            strSql.Append("Reqiment=@Reqiment,");
            strSql.Append("UpDateDate=@UpDateDate");
            strSql.Append(" where ZpID=@ZpID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ZpID", OleDbType.VarChar,50),
					new OleDbParameter("@ZpZhiWei", OleDbType.VarChar,50),
					new OleDbParameter("@PeopleNum", OleDbType.VarChar,50),
					new OleDbParameter("@Reqiment", OleDbType.VarChar,50),
					new OleDbParameter("@UpDateDate", OleDbType.Date)};
            parameters[0].Value = ZpID;
            parameters[1].Value = ZpZhiWei;
            parameters[2].Value = PeopleNum;
            parameters[3].Value = Reqiment;
            parameters[4].Value = UpDateDate;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string ZpID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_zhaoping ");
            strSql.Append(" where ZpID=@ZpID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ZpID", OleDbType.VarChar,50)};
            parameters[0].Value = ZpID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(string ZpID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ZpID,ZpZhiWei,PeopleNum,Reqiment,UpDateDate ");
            strSql.Append(" FROM tb_zhaoping ");
            strSql.Append(" where ZpID=@ZpID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ZpID", OleDbType.VarChar,50)};
            parameters[0].Value = ZpID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.ZpID = ds.Tables[0].Rows[0]["ZpID"].ToString();
                this.ZpZhiWei = ds.Tables[0].Rows[0]["ZpZhiWei"].ToString();
                this.PeopleNum = ds.Tables[0].Rows[0]["PeopleNum"].ToString();
                this.Reqiment = ds.Tables[0].Rows[0]["Reqiment"].ToString();
                if (ds.Tables[0].Rows[0]["UpDateDate"].ToString() != "")
                {
                    this.UpDateDate = DateTime.Parse(ds.Tables[0].Rows[0]["UpDateDate"].ToString());
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
            strSql.Append(" FROM tb_zhaoping ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

