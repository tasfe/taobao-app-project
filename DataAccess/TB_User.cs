using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using DBUtility;//请先添加引用
namespace weibo.DataAccess
{
	/// <summary>
	/// 类tb_user。
	/// </summary>
	public partial class tb_user
	{
		public tb_user()
		{}
		#region Model
		private string _tb_userid;
		private string _tb_nick;
		private string _tx_key;
		private string _tx_secret;
		private DateTime _updateon;
		private string _sina_key;
		private string _sina_secret;
		private string _tb_subscribe;
		private int _id;
		/// <summary>
		/// 
		/// </summary>
		public string tb_userid
		{
			set{ _tb_userid=value;}
			get{return _tb_userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tb_nick
		{
			set{ _tb_nick=value;}
			get{return _tb_nick;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tx_key
		{
			set{ _tx_key=value;}
			get{return _tx_key;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tx_secret
		{
			set{ _tx_secret=value;}
			get{return _tx_secret;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime updateon
		{
			set{ _updateon=value;}
			get{return _updateon;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sina_key
		{
			set{ _sina_key=value;}
			get{return _sina_key;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sina_secret
		{
			set{ _sina_secret=value;}
			get{return _sina_secret;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tb_subscribe
		{
			set{ _tb_subscribe=value;}
			get{return _tb_subscribe;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		#endregion Model


		#region  成员方法

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tb_user(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select [tb_userid],[tb_nick],[tx_key],[tx_secret],[updateon],[sina_key],[sina_secret],[tb_subscribe],[ID] ");
			strSql.Append(" FROM tb_user ");
			strSql.Append(" where [ID]=@ID ");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				tb_userid=ds.Tables[0].Rows[0]["tb_userid"].ToString();
				tb_nick=ds.Tables[0].Rows[0]["tb_nick"].ToString();
				tx_key=ds.Tables[0].Rows[0]["tx_key"].ToString();
				tx_secret=ds.Tables[0].Rows[0]["tx_secret"].ToString();
				if(ds.Tables[0].Rows[0]["updateon"].ToString()!="")
				{
					updateon=DateTime.Parse(ds.Tables[0].Rows[0]["updateon"].ToString());
				}
				sina_key=ds.Tables[0].Rows[0]["sina_key"].ToString();
				sina_secret=ds.Tables[0].Rows[0]["sina_secret"].ToString();
				tb_subscribe=ds.Tables[0].Rows[0]["tb_subscribe"].ToString();
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
			}
		}
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_user");
			strSql.Append(" where [ID]=@ID ");

			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_user(");
			strSql.Append("[tb_userid],[tb_nick],[tx_key],[tx_secret],[updateon],[sina_key],[sina_secret],[tb_subscribe])");
			strSql.Append(" values (");
			strSql.Append("@tb_userid,@tb_nick,@tx_key,@tx_secret,@updateon,@sina_key,@sina_secret,@tb_subscribe)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@tb_userid", OleDbType.VarChar,255),
					new OleDbParameter("@tb_nick", OleDbType.VarChar,255),
					new OleDbParameter("@tx_key", OleDbType.VarChar,255),
					new OleDbParameter("@tx_secret", OleDbType.VarChar,255),
					new OleDbParameter("@updateon", OleDbType.Date),
					new OleDbParameter("@sina_key", OleDbType.VarChar,255),
					new OleDbParameter("@sina_secret", OleDbType.VarChar,255),
					new OleDbParameter("@tb_subscribe", OleDbType.VarChar,255)};
			parameters[0].Value = tb_userid;
			parameters[1].Value = tb_nick;
			parameters[2].Value = tx_key;
			parameters[3].Value = tx_secret;
			parameters[4].Value = updateon;
			parameters[5].Value = sina_key;
			parameters[6].Value = sina_secret;
			parameters[7].Value = tb_subscribe;

            return int.Parse(DbHelperSQL.ExecuteScalar(strSql.ToString(), "select @@identity as id", parameters).ToString());
			//DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [tb_user] set ");
			strSql.Append("[tb_userid]=@tb_userid,");
			strSql.Append("[tb_nick]=@tb_nick,");
			strSql.Append("[tx_key]=@tx_key,");
			strSql.Append("[tx_secret]=@tx_secret,");
			strSql.Append("[updateon]=@updateon,");
			strSql.Append("[sina_key]=@sina_key,");
			strSql.Append("[sina_secret]=@sina_secret,");
			strSql.Append("[tb_subscribe]=@tb_subscribe");
			strSql.Append(" where [ID]=@ID ");
			OleDbParameter[] parameters = {
					new OleDbParameter("@tb_userid", OleDbType.VarChar,255),
					new OleDbParameter("@tb_nick", OleDbType.VarChar,255),
					new OleDbParameter("@tx_key", OleDbType.VarChar,255),
					new OleDbParameter("@tx_secret", OleDbType.VarChar,255),
					new OleDbParameter("@updateon", OleDbType.Date),
					new OleDbParameter("@sina_key", OleDbType.VarChar,255),
					new OleDbParameter("@sina_secret", OleDbType.VarChar,255),
					new OleDbParameter("@tb_subscribe", OleDbType.VarChar,255),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
			parameters[0].Value = tb_userid;
			parameters[1].Value = tb_nick;
			parameters[2].Value = tx_key;
			parameters[3].Value = tx_secret;
			parameters[4].Value = updateon;
			parameters[5].Value = sina_key;
			parameters[6].Value = sina_secret;
			parameters[7].Value = tb_subscribe;
			parameters[8].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_user ");
			strSql.Append(" where [ID]=@ID ");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public void GetModel(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select [tb_userid],[tb_nick],[tx_key],[tx_secret],[updateon],[sina_key],[sina_secret],[tb_subscribe],[ID] ");
			strSql.Append(" FROM tb_user ");
			strSql.Append(" where [ID]=@ID ");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				this.tb_userid=ds.Tables[0].Rows[0]["tb_userid"].ToString();
				this.tb_nick=ds.Tables[0].Rows[0]["tb_nick"].ToString();
				this.tx_key=ds.Tables[0].Rows[0]["tx_key"].ToString();
				this.tx_secret=ds.Tables[0].Rows[0]["tx_secret"].ToString();
				if(ds.Tables[0].Rows[0]["updateon"].ToString()!="")
				{
					this.updateon=DateTime.Parse(ds.Tables[0].Rows[0]["updateon"].ToString());
				}
				this.sina_key=ds.Tables[0].Rows[0]["sina_key"].ToString();
				this.sina_secret=ds.Tables[0].Rows[0]["sina_secret"].ToString();
				this.tb_subscribe=ds.Tables[0].Rows[0]["tb_subscribe"].ToString();
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					this.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM tb_user ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

