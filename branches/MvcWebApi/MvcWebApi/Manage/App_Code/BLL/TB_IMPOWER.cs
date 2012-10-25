using System;
using System.Data;
using SASCMS.Model;
namespace SASCMS.BLL
{
	/// <summary>
	/// ҵ���߼���TB_IMPOWER ��ժҪ˵����
	/// </summary>
	public class TB_IMPOWERBLL
	{
        private readonly SASCMS.DAL.TB_IMPOWERDAL dal = new SASCMS.DAL.TB_IMPOWERDAL();
        public TB_IMPOWERBLL()
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
		public bool Exists(string ImpowerId)
		{
			return dal.Exists(ImpowerId);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public string Add(SASCMS.Model.TB_IMPOWER model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(SASCMS.Model.TB_IMPOWER model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string ImpowerId)
		{
			dal.Delete(ImpowerId);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public SASCMS.Model.TB_IMPOWER GetModel(string ImpowerId)
		{
			return dal.GetModel(ImpowerId);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
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

