using System;
using System.Data;
using SASCMS.Model;
namespace SASCMS.BLL
{
    /// <summary>
    /// 业务逻辑类TB_Column 的摘要说明。
    /// </summary>
    public class TB_ColumnBll
    {
        private readonly SASCMS.DAL.TB_ColumnDal dal = new SASCMS.DAL.TB_ColumnDal();
        public TB_ColumnBll()
        { }
        #region  成员方法

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(SASCMS.Model.TB_Column model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(SASCMS.Model.TB_Column model)
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
        public SASCMS.Model.TB_Column GetModel(string Id)
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

