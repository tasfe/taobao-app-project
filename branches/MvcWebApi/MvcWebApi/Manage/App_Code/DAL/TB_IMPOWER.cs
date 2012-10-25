using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using SASCMS.DBUtility;
namespace SASCMS.DAL
{
	/// <summary>
	/// 数据访问类TB_IMPOWER。
	/// </summary>
	public class TB_IMPOWERDAL
	{
		public TB_IMPOWERDAL()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return DbHelperSQL.GetMaxID("ImpowerId", "TB_IMPOWER"); 
		}
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ImpowerId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TB_IMPOWER");
			strSql.Append(" where ImpowerId= @ImpowerId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ImpowerId", SqlDbType.VarChar)
				};
			parameters[0].Value = ImpowerId;
			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public string Add(SASCMS.Model.TB_IMPOWER model)
		{
			//model.ImpowerId=GetMaxId();
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TB_IMPOWER(");
			strSql.Append("ImpowerId,RoleId,PrivilegeId)");
			strSql.Append(" values (");
			strSql.Append("@ImpowerId,@RoleId,@PrivilegeId)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ImpowerId", OleDbType.VarChar,50),
					new OleDbParameter("@RoleId", OleDbType.VarChar,50),
					new OleDbParameter("@PrivilegeId", OleDbType.VarChar,50)};
			parameters[0].Value = model.ImpowerId;
			parameters[1].Value = model.RoleId;
			parameters[2].Value = model.PrivilegeId;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			return model.ImpowerId;
		}
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(SASCMS.Model.TB_IMPOWER model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_IMPOWER set ");
            strSql.Append("ImpowerId='" + model.ImpowerId + "',");
            strSql.Append("RoleId='" + model.RoleId + "',");
            strSql.Append("PrivilegeId='" + model.PrivilegeId + "'");
            strSql.Append(" where ImpowerId='" + model.ImpowerId + "' ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string ImpowerId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TB_IMPOWER ");
            strSql.Append(" where ImpowerId='" + ImpowerId + "' ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SASCMS.Model.TB_IMPOWER GetModel(string ImpowerId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ImpowerId,RoleId,PrivilegeId from TB_IMPOWER ");
			strSql.Append(" where ImpowerId=@ImpowerId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ImpowerId", SqlDbType.VarChar)};
			parameters[0].Value = ImpowerId;
			SASCMS.Model.TB_IMPOWER model=new SASCMS.Model.TB_IMPOWER();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.ImpowerId=ds.Tables[0].Rows[0]["ImpowerId"].ToString();
				model.RoleId=ds.Tables[0].Rows[0]["RoleId"].ToString();
				model.PrivilegeId=ds.Tables[0].Rows[0]["PrivilegeId"].ToString();
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
			strSql.Append("select ImpowerId,RoleId,PrivilegeId ");
			strSql.Append(" FROM TB_IMPOWER ");
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
			parameters[0].Value = "TB_IMPOWER";
			parameters[1].Value = "ImpowerId";
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

