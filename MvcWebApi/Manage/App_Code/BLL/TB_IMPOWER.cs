using System;
using System.Data;
using SASCMS.Model;
namespace SASCMS.BLL
{
	/// <summary>
	/// 业务逻辑类TB_IMPOWER 的摘要说明。
	/// </summary>
	public class TB_IMPOWERBLL
	{
        private readonly SASCMS.DAL.TB_IMPOWERDAL dal = new SASCMS.DAL.TB_IMPOWERDAL();
        public TB_IMPOWERBLL()
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
		public bool Exists(string ImpowerId)
		{
			return dal.Exists(ImpowerId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public string Add(SASCMS.Model.TB_IMPOWER model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(SASCMS.Model.TB_IMPOWER model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string ImpowerId)
		{
			dal.Delete(ImpowerId);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SASCMS.Model.TB_IMPOWER GetModel(string ImpowerId)
		{
			return dal.GetModel(ImpowerId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
        //public SASCMS.Model.TB_IMPOWER GetModelByCache(string ImpowerId)
        //{
        //    string CacheKey = "TB_IMPOWERModel-" + ImpowerId;
        //    object objModel = DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(ImpowerId);
        //            if (objModel != null)
        //            {
        //                int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (SASCMS.Model.TB_IMPOWER)objModel;
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

