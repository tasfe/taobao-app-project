using System;
using System.Data;
using Shop.Model;
namespace Shop.BLL
{
    /// <summary>
    /// ҵ���߼���TB_Article ��ժҪ˵����
    /// </summary>
    public class TB_ArticleBll
    {
        private readonly Shop.DAL.TB_ArticleDal dal = new Shop.DAL.TB_ArticleDal();
        public TB_ArticleBll()
        { }
        #region  ��Ա����
  

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(Shop.Model.TB_Article model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Shop.Model.TB_Article model)
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
        public Shop.Model.TB_Article GetModel(string QWBS)
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

