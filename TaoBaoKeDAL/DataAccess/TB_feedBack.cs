﻿using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Shop.DBUtility;//请先添加引用
namespace JSFT.DAL
{
    /// <summary>
    /// 类tb_feedBack。
    /// </summary>
    public class tb_feedBack
    {
        public tb_feedBack()
        { }
        #region Model
        private string _fdid;
        private string _name;
        private string _email;
        private string _tel;
        private string _title;
        private string _detail;
        private DateTime _updatetime;
        private string _type;
        /// <summary>
        /// 
        /// </summary>
        public string fdID
        {
            set { _fdid = value; }
            get { return _fdid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tel
        {
            set { _tel = value; }
            get { return _tel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string detail
        {
            set { _detail = value; }
            get { return _detail; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime updateTime
        {
            set { _updatetime = value; }
            get { return _updatetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string type
        {
            set { _type = value; }
            get { return _type; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tb_feedBack(string fdID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select fdID,name,email,tel,title,detail,updateTime,type ");
            strSql.Append(" FROM tb_feedBack ");
            strSql.Append(" where fdID=@fdID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@fdID", OleDbType.VarChar,50)};
            parameters[0].Value = fdID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                fdID = ds.Tables[0].Rows[0]["fdID"].ToString();
                name = ds.Tables[0].Rows[0]["name"].ToString();
                email = ds.Tables[0].Rows[0]["email"].ToString();
                tel = ds.Tables[0].Rows[0]["tel"].ToString();
                title = ds.Tables[0].Rows[0]["title"].ToString();
                detail = ds.Tables[0].Rows[0]["detail"].ToString();
                if (ds.Tables[0].Rows[0]["updateTime"].ToString() != "")
                {
                    updateTime = DateTime.Parse(ds.Tables[0].Rows[0]["updateTime"].ToString());
                }
                type = ds.Tables[0].Rows[0]["type"].ToString();
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string fdID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_feedBack");
            strSql.Append(" where fdID=@fdID ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@fdID", OleDbType.VarChar,50)};
            parameters[0].Value = fdID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_feedBack(");
            strSql.Append("fdID,name,email,tel,title,detail,updateTime,type)");
            strSql.Append(" values (");
            strSql.Append("@fdID,@name,@email,@tel,@title,@detail,@updateTime,@type)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@fdID", OleDbType.VarChar,50),
					new OleDbParameter("@name", OleDbType.VarChar,50),
					new OleDbParameter("@email", OleDbType.VarChar,50),
					new OleDbParameter("@tel", OleDbType.VarChar,50),
					new OleDbParameter("@title", OleDbType.VarChar,50),
					new OleDbParameter("@detail", OleDbType.VarChar,0),
					new OleDbParameter("@updateTime", OleDbType.Date),
					new OleDbParameter("@type", OleDbType.VarChar,50)};
            parameters[0].Value = fdID;
            parameters[1].Value = name;
            parameters[2].Value = email;
            parameters[3].Value = tel;
            parameters[4].Value = title;
            parameters[5].Value = detail;
            parameters[6].Value = updateTime;
            parameters[7].Value = type;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_feedBack set ");
            strSql.Append("fdID=@fdID,");
            strSql.Append("name=@name,");
            strSql.Append("email=@email,");
            strSql.Append("tel=@tel,");
            strSql.Append("title=@title,");
            strSql.Append("detail=@detail,");
            strSql.Append("updateTime=@updateTime,");
            strSql.Append("type=@type");
            strSql.Append(" where fdID=@fdID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@fdID", OleDbType.VarChar,50),
					new OleDbParameter("@name", OleDbType.VarChar,50),
					new OleDbParameter("@email", OleDbType.VarChar,50),
					new OleDbParameter("@tel", OleDbType.VarChar,50),
					new OleDbParameter("@title", OleDbType.VarChar,50),
					new OleDbParameter("@detail", OleDbType.VarChar,0),
					new OleDbParameter("@updateTime", OleDbType.Date),
					new OleDbParameter("@type", OleDbType.VarChar,50)};
            parameters[0].Value = fdID;
            parameters[1].Value = name;
            parameters[2].Value = email;
            parameters[3].Value = tel;
            parameters[4].Value = title;
            parameters[5].Value = detail;
            parameters[6].Value = updateTime;
            parameters[7].Value = type;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string fdID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_feedBack ");
            strSql.Append(" where fdID=@fdID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@fdID", OleDbType.VarChar,50)};
            parameters[0].Value = fdID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(string fdID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select fdID,name,email,tel,title,detail,updateTime,type ");
            strSql.Append(" FROM tb_feedBack ");
            strSql.Append(" where fdID=@fdID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@fdID", OleDbType.VarChar,50)};
            parameters[0].Value = fdID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.fdID = ds.Tables[0].Rows[0]["fdID"].ToString();
                this.name = ds.Tables[0].Rows[0]["name"].ToString();
                this.email = ds.Tables[0].Rows[0]["email"].ToString();
                this.tel = ds.Tables[0].Rows[0]["tel"].ToString();
                this.title = ds.Tables[0].Rows[0]["title"].ToString();
                this.detail = ds.Tables[0].Rows[0]["detail"].ToString();
                if (ds.Tables[0].Rows[0]["updateTime"].ToString() != "")
                {
                    this.updateTime = DateTime.Parse(ds.Tables[0].Rows[0]["updateTime"].ToString());
                }
                this.type = ds.Tables[0].Rows[0]["type"].ToString();
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM tb_feedBack ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

