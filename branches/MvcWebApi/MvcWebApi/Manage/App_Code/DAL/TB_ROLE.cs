using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using SASCMS.DBUtility;
namespace SASCMS.DAL
{
	/// <summary>
	/// 数据访问类TB_ROLE。
	/// </summary>
	public class TB_ROLEDAL
	{
        public TB_ROLEDAL()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return DbHelperSQL.GetMaxID("RoleId", "TB_ROLE"); 
		}
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string RoleId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TB_ROLE");
			strSql.Append(" where RoleId= @RoleId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@RoleId", SqlDbType.VarChar)
				};
			parameters[0].Value = RoleId;
			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public string Add(SASCMS.Model.TB_ROLE model)
		{
			//model.RoleId=GetMaxId();
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TB_ROLE(");
			strSql.Append("RoleId,RoleName,RoleDescription,RoleCreateDate)");
			strSql.Append(" values (");
			strSql.Append("@RoleId,@RoleName,@RoleDescription,@RoleCreateDate)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@RoleId", OleDbType.VarChar,50),
					new OleDbParameter("@RoleName", OleDbType.VarChar,50),
					new OleDbParameter("@RoleDescription", OleDbType.VarChar,255),
					new OleDbParameter("@RoleCreateDate", OleDbType.DBTimeStamp)};
			parameters[0].Value = model.RoleId;
			parameters[1].Value = model.RoleName;
			parameters[2].Value = model.RoleDescription;
			parameters[3].Value = model.RoleCreateDate;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			return model.RoleId;
		}
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(SASCMS.Model.TB_ROLE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_ROLE set ");
            strSql.Append("RoleId='" + model.RoleId + "',");
            strSql.Append("RoleName='" + model.RoleName + "',");
            strSql.Append("RoleDescription='" + model.RoleDescription + "',");
            strSql.Append("RoleCreateDate='" + model.RoleCreateDate + "'");
            strSql.Append(" where RoleId='" + model.RoleId + "' ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string RoleId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete TB_ROLE ");
			strSql.Append(" where RoleId=@RoleId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@RoleId", SqlDbType.VarChar)
				};
			parameters[0].Value = RoleId;
			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SASCMS.Model.TB_ROLE GetModel(string RoleId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select RoleId,RoleName,RoleDescription,RoleCreateDate from TB_ROLE ");
			strSql.Append(" where RoleId=@RoleId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@RoleId", SqlDbType.VarChar)};
			parameters[0].Value = RoleId;
			SASCMS.Model.TB_ROLE model=new SASCMS.Model.TB_ROLE();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.RoleId=ds.Tables[0].Rows[0]["RoleId"].ToString();
				model.RoleName=ds.Tables[0].Rows[0]["RoleName"].ToString();
				model.RoleDescription=ds.Tables[0].Rows[0]["RoleDescription"].ToString();
				if(ds.Tables[0].Rows[0]["RoleCreateDate"].ToString()!="")
				{
					model.RoleCreateDate=DateTime.Parse(ds.Tables[0].Rows[0]["RoleCreateDate"].ToString());
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select RoleId,RoleName,RoleDescription,RoleCreateDate ");
			strSql.Append(" FROM TB_ROLE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
					new OleDbParameter("@tblName", SqlDbType.VarChar, 255),
					new OleDbParameter("@fldName", SqlDbType.VarChar, 255),
					new OleDbParameter("@PageSize", SqlDbType.Int),
					new OleDbParameter("@PageIndex", SqlDbType.Int),
					new OleDbParameter("@IsReCount", SqlDbType.Bit),
					new OleDbParameter("@OrderType", SqlDbType.Bit),
					new OleDbParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "TB_ROLE";
			parameters[1].Value = "RoleId";
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

