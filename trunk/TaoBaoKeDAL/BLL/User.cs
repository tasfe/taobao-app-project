using System;
using System.Data;
using Shop.Model;
namespace Shop.BLL
{
    /// <summary>
    /// 业务逻辑类TB_User 的摘要说明。
    /// </summary>
    public class TB_UserBll
    {
        private readonly Shop.DAL.TB_UserDal dal = new Shop.DAL.TB_UserDal();
        public TB_UserBll()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Id)
        {
            return dal.Exists(Id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Shop.Model.TB_User model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Shop.Model.TB_User model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string Id)
        {
            dal.Delete(Id);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Shop.Model.TB_User GetModel(string Id)
        {
            return dal.GetModel(Id);
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

