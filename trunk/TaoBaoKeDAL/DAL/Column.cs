using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Shop.DBUtility;

namespace Shop.DAL
{
    /// <summary>
    /// 数据访问类TB_Column。
    /// </summary>
    public class TB_ColumnDal
    {
        public TB_ColumnDal()
        { }
        #region  成员方法

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Shop.Model.TB_Column model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_Column(");
            strSql.Append("Id,Title,ParentId,updateTime,Code,isUrl,url,shortName,transId,isVisible");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.Id + "',");
            strSql.Append("'" + model.Title + "',");
            strSql.Append("'" + model.ParentId + "',");
            strSql.Append("'" + model.updateTime + "',");
            strSql.Append("'" + model.Code + "',");
            strSql.Append("" + model.isUrl + ",");
            strSql.Append("'" + model.url + "',");
            strSql.Append("'" + model.shortName + "',");
            strSql.Append("'" + model.transId + "',");
            strSql.Append("" + model.IsVisible + "");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Shop.Model.TB_Column model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_Column set ");
            strSql.Append("Id='" + model.Id + "',");
            strSql.Append("Title='" + model.Title + "',");
            strSql.Append("ParentId='" + model.ParentId + "',");
            strSql.Append("updateTime='" + model.updateTime + "',");
            strSql.Append("Code='" + model.Code + "',");
            //if (model.isUrl)
            //{
            //    strSql.Append("isUrl=1,");
            //}
            //else
            //{
            //    strSql.Append("isUrl=0,");
    
            //}
            strSql.Append("isUrl=" + model .isUrl.ToString()+ ",");
            strSql.Append("url='" + model.url + "',");
            strSql.Append("shortName='" + model.shortName + "',");
            strSql.Append("transId='" + model.transId + "',");
            strSql.Append("isVisible=" + model.IsVisible + "");
            strSql.Append(" where Id='" + model.Id + "' ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TB_Column ");
            strSql.Append(" where Id='" + Id + "' ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Shop.Model.TB_Column GetModel(string Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TB_Column ");
            strSql.Append(" where Id=@Id ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.VarChar,50)};
            parameters[0].Value = Id;

            Shop.Model.TB_Column model = new Shop.Model.TB_Column();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.Id = ds.Tables[0].Rows[0]["Id"].ToString();
                model.Title = ds.Tables[0].Rows[0]["Title"].ToString();
                model.ParentId = ds.Tables[0].Rows[0]["ParentId"].ToString();
                if (ds.Tables[0].Rows[0]["updateTime"].ToString() != "")
                {
                    model.updateTime = DateTime.Parse(ds.Tables[0].Rows[0]["updateTime"].ToString());
                }
                model.Code = ds.Tables[0].Rows[0]["Code"].ToString();
                if (ds.Tables[0].Rows[0]["isUrl"].ToString() != "")
                {
                    //if ((ds.Tables[0].Rows[0]["isUrl"].ToString() == "1") || (ds.Tables[0].Rows[0]["isUrl"].ToString().ToLower() == "true"))
                    //{
                    //    model.isUrl = true;
                    //}
                    //else
                    //{
                    //    model.isUrl = false;
                    //}
                    model.isUrl = int.Parse(ds.Tables[0].Rows[0]["isUrl"].ToString());
                }
                if ((ds.Tables[0].Rows[0]["isVisible"].ToString() == "1") || (ds.Tables[0].Rows[0]["isVisible"].ToString().ToLower() == "true"))
                {
                    model.IsVisible = 1;
                }
                else
                {
                    model.IsVisible =0;
                }
               
                model.url = ds.Tables[0].Rows[0]["url"].ToString();
                model.shortName = ds.Tables[0].Rows[0]["shortName"].ToString();
                model.transId = ds.Tables[0].Rows[0]["transId"].ToString();
                model.TopPic = ds.Tables[0].Rows[0]["TopPic"].ToString();
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
            strSql.Append("select * ");
            strSql.Append(" FROM TB_Column ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            OleDbParameter[] parameters = {
                    new OleDbParameter("@tblName", OleDbType.VarChar, 255),
                    new OleDbParameter("@fldName", OleDbType.VarChar, 255),
                    new OleDbParameter("@PageSize", OleDbType.Integer),
                    new OleDbParameter("@PageIndex", OleDbType.Integer),
                    new OleDbParameter("@IsReCount", OleDbType.Boolean),
                    new OleDbParameter("@OrderType", OleDbType.Boolean),
                    new OleDbParameter("@strWhere", OleDbType.VarChar,1000),
                    };
            parameters[0].Value = "TB_Column";
            parameters[1].Value = "ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  成员方法

    }
}

