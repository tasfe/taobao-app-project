using System;
using System.Data;
using Shop.Model;
namespace Shop.BLL
{
    /// <summary>
    /// 业务逻辑类TB_Article 的摘要说明。
    /// </summary>
    public class TB_ArticleBll
    {
        private readonly Shop.DAL.TB_ArticleDal dal = new Shop.DAL.TB_ArticleDal();
        public TB_ArticleBll()
        { }
        #region  成员方法
  

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Shop.Model.TB_Article model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Shop.Model.TB_Article model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string QWBS)
        {
            dal.Delete(QWBS);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Shop.Model.TB_Article GetModel(string QWBS)
        {
            return dal.GetModel(QWBS);
        }


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

