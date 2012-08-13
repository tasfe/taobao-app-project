using System;
using System.Data;

using Shop.Model;
namespace Shop.BLL
{
	/// <summary>
	/// 业务逻辑类TB_ROLE 的摘要说明。
	/// </summary>
	public class TB_ROLEBLL
	{
        private readonly Shop.DAL.TB_ROLEDAL dal = new Shop.DAL.TB_ROLEDAL();
        public TB_ROLEBLL()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string RoleId)
		{
			return dal.Exists(RoleId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public string Add(Shop.Model.TB_ROLE model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(Shop.Model.TB_ROLE model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string RoleId)
		{
			dal.Delete(RoleId);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Shop.Model.TB_ROLE GetModel(string RoleId)
		{
			return dal.GetModel(RoleId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
        //public Shop.Model.TB_ROLE GetModelByCache(string RoleId)
        //{
        //    string CacheKey = "TB_ROLEModel-" + RoleId;
        //    object objModel = DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(RoleId);
        //            if (objModel != null)
        //            {
        //                int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (Shop.Model.TB_ROLE)objModel;
        //}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  成员方法
	}
}

