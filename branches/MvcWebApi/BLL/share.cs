using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using sharejoy.Model;
namespace sharejoy.BLL
{
    /// <summary>
    /// share
    /// </summary>
    public partial class shareBll
    {
        private readonly sharejoy.DAL.shareDal dal = new sharejoy.DAL.shareDal();
        public shareBll()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            return dal.Exists(id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(sharejoy.Model.share model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(sharejoy.Model.share model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            return dal.Delete(id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            return dal.DeleteList(idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public sharejoy.Model.share GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public sharejoy.Model.share GetModelByCache(int id)
        {

            string CacheKey = "shareModel-" + id;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(id);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (sharejoy.Model.share)objModel;
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
        public List<sharejoy.Model.share> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<sharejoy.Model.share> DataTableToList(DataTable dt)
        {
            List<sharejoy.Model.share> modelList = new List<sharejoy.Model.share>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                sharejoy.Model.share model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new sharejoy.Model.share();
                    if (dt.Rows[n]["id"] != null && dt.Rows[n]["id"].ToString() != "")
                    {
                        model.id = int.Parse(dt.Rows[n]["id"].ToString());
                    }
                    if (dt.Rows[n]["category"] != null && dt.Rows[n]["category"].ToString() != "")
                    {
                        model.category = int.Parse(dt.Rows[n]["category"].ToString());
                    }
                    if (dt.Rows[n]["category_title"] != null && dt.Rows[n]["category_title"].ToString() != "")
                    {
                        model.category_title = dt.Rows[n]["category_title"].ToString();
                    }
                    if (dt.Rows[n]["content"] != null && dt.Rows[n]["content"].ToString() != "")
                    {
                        model.content = dt.Rows[n]["content"].ToString();
                    }
                    if (dt.Rows[n]["resource"] != null && dt.Rows[n]["resource"].ToString() != "")
                    {
                        model.resource = dt.Rows[n]["resource"].ToString();
                    }
                    if (dt.Rows[n]["update_date"] != null && dt.Rows[n]["update_date"].ToString() != "")
                    {
                        model.update_date = DateTime.Parse(dt.Rows[n]["update_date"].ToString());
                    }
                    if (dt.Rows[n]["create_date"] != null && dt.Rows[n]["create_date"].ToString() != "")
                    {
                        model.create_date = DateTime.Parse(dt.Rows[n]["create_date"].ToString());
                    }
                    if (dt.Rows[n]["update_user"] != null && dt.Rows[n]["update_user"].ToString() != "")
                    {
                        model.update_user = dt.Rows[n]["update_user"].ToString();
                    }
                    if (dt.Rows[n]["create_user"] != null && dt.Rows[n]["create_user"].ToString() != "")
                    {
                        model.create_user = dt.Rows[n]["create_user"].ToString();
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  Method
    }
}

