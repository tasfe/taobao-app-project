using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Shop.DBUtility;
namespace Shop.DAL
{
    /// <summary>
    /// 数据访问类TB_User。
    /// </summary>
    public class TB_UserDal
    {
        public TB_UserDal()
        { }
        #region  成员方法

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_User");
            strSql.Append(" where Id=@Id ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.VarChar,50)};
            parameters[0].Value = Id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


       /// <summary>
		/// 增加一条数据
		/// </summary>
        public void Add(Shop.Model.TB_User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TB_User(");
			strSql.Append("Id,LasTime,LastIp,ComeFrom,login,RoleId,RealName,isAdmin,Reg_Name,Reg_Pass,Sex,Email,User_Group,State,RegTime,RegIp");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+model.Id+"',");
			strSql.Append("'"+model.LasTime+"',");
			strSql.Append("'"+model.LastIp+"',");
			strSql.Append("'"+model.ComeFrom+"',");
			strSql.Append(""+model.login+",");
			strSql.Append("'"+model.RoleId+"',");
			strSql.Append("'"+model.RealName+"',");
			strSql.Append(""+model.isAdmin+",");
			strSql.Append("'"+model.Reg_Name+"',");
			strSql.Append("'"+model.Reg_Pass+"',");
			strSql.Append(""+model.Sex+",");
			strSql.Append("'"+model.Email+"',");
			strSql.Append(""+model.User_Group+",");
			strSql.Append("'"+model.State+"',");
			strSql.Append("'"+model.RegTime+"',");
			strSql.Append("'"+model.RegIp+"'");
			strSql.Append(")");
			DbHelperSQL.ExecuteSql(strSql.ToString());
		}
		
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Shop.Model.TB_User model)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_User set ");
            strSql.Append("Id='" + model.Id + "',");
            strSql.Append("Reg_Name='" + model.Reg_Name + "',");
            strSql.Append("Reg_Pass='" + model.Reg_Pass + "',");
            strSql.Append("Sex=" + model.Sex + ",");
            strSql.Append("Email='" + model.Email + "',");
            strSql.Append("User_Group=" + model.User_Group + ",");
            strSql.Append("State='" + model.State + "',");
            strSql.Append("RegTime='" + model.RegTime + "',");
            strSql.Append("RegIp='" + model.RegIp + "',");
            strSql.Append("LasTime='" + model.LasTime + "',");
            strSql.Append("LastIp='" + model.LastIp + "',");
            strSql.Append("ComeFrom='" + model.ComeFrom + "',");
            strSql.Append("login=" + model.login + ",");
            strSql.Append("RoleId='" + model.RoleId + "',");
            strSql.Append("RealName='" + model.RealName + "',");
            strSql.Append("isAdmin=" + model.isAdmin + "");
            strSql.Append(" where Id='" + model.Id + "' ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete * from TB_User ");
            strSql.Append(" where Id=@Id ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.VarChar,50)};
            parameters[0].Value = Id;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Shop.Model.TB_User GetModel(string Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Reg_Name,Reg_Pass,Sex,Email,User_Group,State,RegTime,RegIp,LasTime,LastIp,ComeFrom,login,RoleId,RealName,isAdmin from TB_User ");
            strSql.Append(" where Id=@Id ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.VarChar,50)};
            parameters[0].Value = Id;

            Shop.Model.TB_User model = new Shop.Model.TB_User();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.Id = ds.Tables[0].Rows[0]["Id"].ToString();
                model.Reg_Name = ds.Tables[0].Rows[0]["Reg_Name"].ToString();
                model.Reg_Pass = ds.Tables[0].Rows[0]["Reg_Pass"].ToString();
                if (ds.Tables[0].Rows[0]["Sex"].ToString() != "")
                {
                    model.Sex = int.Parse(ds.Tables[0].Rows[0]["Sex"].ToString());
                }
                model.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                if (ds.Tables[0].Rows[0]["User_Group"].ToString() != "")
                {
                    model.User_Group = int.Parse(ds.Tables[0].Rows[0]["User_Group"].ToString());
                }
                model.State = ds.Tables[0].Rows[0]["State"].ToString();
                if (ds.Tables[0].Rows[0]["RegTime"].ToString() != "")
                {
                    model.RegTime = DateTime.Parse(ds.Tables[0].Rows[0]["RegTime"].ToString());
                }
                model.RegIp = ds.Tables[0].Rows[0]["RegIp"].ToString();
                if (ds.Tables[0].Rows[0]["LasTime"].ToString() != "")
                {
                    model.LasTime = DateTime.Parse(ds.Tables[0].Rows[0]["LasTime"].ToString());
                }
                model.LastIp = ds.Tables[0].Rows[0]["LastIp"].ToString();
                model.ComeFrom = ds.Tables[0].Rows[0]["ComeFrom"].ToString();
                if (ds.Tables[0].Rows[0]["login"].ToString() != "")
                {
                    model.login = int.Parse(ds.Tables[0].Rows[0]["login"].ToString());
                }
                model.RoleId = ds.Tables[0].Rows[0]["RoleId"].ToString();
                model.RealName = ds.Tables[0].Rows[0]["RealName"].ToString();
                if (ds.Tables[0].Rows[0]["isAdmin"].ToString() != "")
                {
                    model.isAdmin = int.Parse(ds.Tables[0].Rows[0]["isAdmin"].ToString());
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
            strSql.Append("select Id,Reg_Name,Reg_Pass,Sex,Email,User_Group,State,RegTime,RegIp,LasTime,LastIp,ComeFrom,login,RoleId,RealName,isAdmin ");
            strSql.Append(" FROM TB_User ");
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
            parameters[0].Value = "TB_User";
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

