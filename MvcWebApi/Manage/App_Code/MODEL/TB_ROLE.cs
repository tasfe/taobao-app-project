using System;
namespace SASCMS.Model
{
	/// <summary>
	/// ʵ����TB_ROLE ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class TB_ROLE
	{
		public TB_ROLE()
		{}
		#region Model
		private string _roleid;
		private string _rolename;
		private string _roledescription;
		private DateTime _rolecreatedate;
		/// <summary>
		/// 
		/// </summary>
		public string RoleId
		{
		set{ _roleid=value;}
		get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleName
		{
		set{ _rolename=value;}
		get{return _rolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleDescription
		{
		set{ _roledescription=value;}
		get{return _roledescription;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime RoleCreateDate
		{
		set{ _rolecreatedate=value;}
		get{return _rolecreatedate;}
		}
		#endregion Model

	}
}

