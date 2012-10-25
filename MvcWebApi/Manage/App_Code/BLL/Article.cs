using System;
using System.Data;
using SASCMS.Model;
namespace SASCMS.BLL
{
    /// <summary>
    /// ҵ���߼���TB_Article ��ժҪ˵����
    /// </summary>
    public class TB_ArticleBll
    {
        private readonly SASCMS.DAL.TB_ArticleDal dal = new SASCMS.DAL.TB_ArticleDal();
        public TB_ArticleBll()
        { }
        #region  ��Ա����
  

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(SASCMS.Model.TB_Article model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(SASCMS.Model.TB_Article model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(string QWBS)
        {
            dal.Delete(QWBS);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public SASCMS.Model.TB_Article GetModel(string QWBS)
        {
            return dal.GetModel(QWBS);
        }


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

