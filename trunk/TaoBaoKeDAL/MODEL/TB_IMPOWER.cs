using System;
namespace Shop.Model
{
	/// <summary>
	/// 实体类TB_IMPOWER 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class TB_IMPOWER
	{
		public TB_IMPOWER()
		{}
		#region Model
		private string _impowerid;
		private string _roleid;
		private string _privilegeid;
		/// <summary>
		/// 
		/// </summary>
		public string ImpowerId
		{
		set{ _impowerid=value;}
		get{return _impowerid;}
		}
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
		public string PrivilegeId
		{
		set{ _privilegeid=value;}
		get{return _privilegeid;}
		}
		#endregion Model

	}
}

