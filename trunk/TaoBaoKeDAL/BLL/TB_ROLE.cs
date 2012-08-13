using System;
using System.Data;

using Shop.Model;
namespace Shop.BLL
{
	/// <summary>
	/// ҵ���߼���TB_ROLE ��ժҪ˵����
	/// </summary>
	public class TB_ROLEBLL
	{
        private readonly Shop.DAL.TB_ROLEDAL dal = new Shop.DAL.TB_ROLEDAL();
        public TB_ROLEBLL()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string RoleId)
		{
			return dal.Exists(RoleId);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public string Add(Shop.Model.TB_ROLE model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(Shop.Model.TB_ROLE model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string RoleId)
		{
			dal.Delete(RoleId);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Shop.Model.TB_ROLE GetModel(string RoleId)
		{
			return dal.GetModel(RoleId);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
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
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  ��Ա����
	}
}

