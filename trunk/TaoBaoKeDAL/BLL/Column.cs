using System;
using System.Data;
using Shop.Model;
namespace Shop.BLL
{
    /// <summary>
    /// ҵ���߼���TB_Column ��ժҪ˵����
    /// </summary>
    public class TB_ColumnBll
    {
        private readonly Shop.DAL.TB_ColumnDal dal = new Shop.DAL.TB_ColumnDal();
        public TB_ColumnBll()
        { }
        #region  ��Ա����

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(Shop.Model.TB_Column model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Shop.Model.TB_Column model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(string Id)
        {
            dal.Delete(Id);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Shop.Model.TB_Column GetModel(string Id)
        {
            return dal.GetModel(Id);
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
