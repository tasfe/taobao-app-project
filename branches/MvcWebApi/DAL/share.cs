using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace sharejoy.DAL
{
    /// <summary>
    /// 数据访问类:share
    /// </summary>
    public partial class shareDal
    {
        public shareDal()
        { }
        #region  Method

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from share");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,10)			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(sharejoy.Model.share model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into share(");
            strSql.Append("id,category,category_title,content,resource,update_date,create_date,update_user,create_user)");
            strSql.Append(" values (");
            strSql.Append("@id,@category,@category_title,@content,@resource,@update_date,@create_date,@update_user,@create_user)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,10),
					new MySqlParameter("@category", MySqlDbType.Int32,10),
					new MySqlParameter("@category_title", MySqlDbType.VarChar,50),
					new MySqlParameter("@content", MySqlDbType.VarChar,500),
					new MySqlParameter("@resource", MySqlDbType.VarChar,50),
					new MySqlParameter("@update_date", MySqlDbType.DateTime),
					new MySqlParameter("@create_date", MySqlDbType.DateTime),
					new MySqlParameter("@update_user", MySqlDbType.VarChar,50),
					new MySqlParameter("@create_user", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.category;
            parameters[2].Value = model.category_title;
            parameters[3].Value = model.content;
            parameters[4].Value = model.resource;
            parameters[5].Value = model.update_date;
            parameters[6].Value = model.create_date;
            parameters[7].Value = model.update_user;
            parameters[8].Value = model.create_user;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(sharejoy.Model.share model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update share set ");
            strSql.Append("id=@id,");
            strSql.Append("category=@category,");
            strSql.Append("category_title=@category_title,");
            strSql.Append("content=@content,");
            strSql.Append("resource=@resource,");
            strSql.Append("update_date=@update_date,");
            strSql.Append("create_date=@create_date,");
            strSql.Append("update_user=@update_user,");
            strSql.Append("create_user=@create_user");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,10),
					new MySqlParameter("@category", MySqlDbType.Int32,10),
					new MySqlParameter("@category_title", MySqlDbType.VarChar,50),
					new MySqlParameter("@content", MySqlDbType.VarChar,500),
					new MySqlParameter("@resource", MySqlDbType.VarChar,50),
					new MySqlParameter("@update_date", MySqlDbType.DateTime),
					new MySqlParameter("@create_date", MySqlDbType.DateTime),
					new MySqlParameter("@update_user", MySqlDbType.VarChar,50),
					new MySqlParameter("@create_user", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.category;
            parameters[2].Value = model.category_title;
            parameters[3].Value = model.content;
            parameters[4].Value = model.resource;
            parameters[5].Value = model.update_date;
            parameters[6].Value = model.create_date;
            parameters[7].Value = model.update_user;
            parameters[8].Value = model.create_user;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from share ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,10)			};
            parameters[0].Value = id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from share ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public sharejoy.Model.share GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,category,category_title,content,resource,update_date,create_date,update_user,create_user from share ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,10)			};
            parameters[0].Value = id;

            sharejoy.Model.share model = new sharejoy.Model.share();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["category"] != null && ds.Tables[0].Rows[0]["category"].ToString() != "")
                {
                    model.category = int.Parse(ds.Tables[0].Rows[0]["category"].ToString());
                }
                if (ds.Tables[0].Rows[0]["category_title"] != null && ds.Tables[0].Rows[0]["category_title"].ToString() != "")
                {
                    model.category_title = ds.Tables[0].Rows[0]["category_title"].ToString();
                }
                if (ds.Tables[0].Rows[0]["content"] != null && ds.Tables[0].Rows[0]["content"].ToString() != "")
                {
                    model.content = ds.Tables[0].Rows[0]["content"].ToString();
                }
                if (ds.Tables[0].Rows[0]["resource"] != null && ds.Tables[0].Rows[0]["resource"].ToString() != "")
                {
                    model.resource = ds.Tables[0].Rows[0]["resource"].ToString();
                }
                if (ds.Tables[0].Rows[0]["update_date"] != null && ds.Tables[0].Rows[0]["update_date"].ToString() != "")
                {
                    model.update_date = DateTime.Parse(ds.Tables[0].Rows[0]["update_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["create_date"] != null && ds.Tables[0].Rows[0]["create_date"].ToString() != "")
                {
                    model.create_date = DateTime.Parse(ds.Tables[0].Rows[0]["create_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["update_user"] != null && ds.Tables[0].Rows[0]["update_user"].ToString() != "")
                {
                    model.update_user = ds.Tables[0].Rows[0]["update_user"].ToString();
                }
                if (ds.Tables[0].Rows[0]["create_user"] != null && ds.Tables[0].Rows[0]["create_user"].ToString() != "")
                {
                    model.create_user = ds.Tables[0].Rows[0]["create_user"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,category,category_title,content,resource,update_date,create_date,update_user,create_user ");
            strSql.Append(" FROM share ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM share ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperMySQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from share T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            MySqlParameter[] parameters = {
                    new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
                    new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
                    new MySqlParameter("@PageSize", MySqlDbType.Int32),
                    new MySqlParameter("@PageIndex", MySqlDbType.Int32),
                    new MySqlParameter("@IsReCount", MySqlDbType.Bit),
                    new MySqlParameter("@OrderType", MySqlDbType.Bit),
                    new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "share";
            parameters[1].Value = "id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  Method
    }
}

