using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using SASCMS.DBUtility;

namespace SASCMS.DAL
{
    /// <summary>
    /// 数据访问类TB_Article。
    /// </summary>
    public class TB_ArticleDal
    {
        public TB_ArticleDal()
        { }
        #region  成员方法



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(SASCMS.Model.TB_Article model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_Article(");
            strSql.Append("QWBS,ColumnId,TF,AddDate,CWRQ,FBRQ,ZRZ,Content,NRGS,ViewNum,Author,IsPass,Type,SourceURL,ColumnCode,SYH,WH,isDelete,DepId,fuJian)");
            strSql.Append(" values (");
            strSql.Append("@QWBS,@ColumnId,@TF,@AddDate,@CWRQ,@FBRQ,@ZRZ,@Content,@NRGS,@ViewNum,@Author,@IsPass,@Type,@SourceURL,@ColumnCode,@SYH,@WH,@isDelete,@DepId,@fuJian)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@QWBS", OleDbType.VarChar,50),
					new OleDbParameter("@ColumnId", OleDbType.VarChar,50),
					new OleDbParameter("@TF", OleDbType.VarChar,250),
					new OleDbParameter("@AddDate", OleDbType.DBDate),
					new OleDbParameter("@CWRQ", OleDbType.DBDate),
					new OleDbParameter("@FBRQ", OleDbType.DBDate),
					new OleDbParameter("@ZRZ", OleDbType.VarChar,250),
					new OleDbParameter("@Content", OleDbType.VarChar),
					new OleDbParameter("@NRGS", OleDbType.VarChar),
					new OleDbParameter("@ViewNum", OleDbType.Integer,4),
					new OleDbParameter("@Author", OleDbType.VarChar,100),
					new OleDbParameter("@IsPass", OleDbType.Integer,4),
					new OleDbParameter("@Type", OleDbType.VarChar,50),
					new OleDbParameter("@SourceURL", OleDbType.VarChar,250),
					new OleDbParameter("@ColumnCode", OleDbType.VarChar,50),
					new OleDbParameter("@SYH", OleDbType.VarChar,250),
					new OleDbParameter("@WH", OleDbType.VarChar,250),
					new OleDbParameter("@isDelete", OleDbType.Integer,4),
					new OleDbParameter("@DepId", OleDbType.VarChar,250),
					new OleDbParameter("@fuJian", OleDbType.VarChar,250)};
            parameters[0].Value = model.QWBS;
            parameters[1].Value = model.ColumnId;
            parameters[2].Value = model.TF;
            parameters[3].Value = model.AddDate;
            parameters[4].Value = model.CWRQ;
            parameters[5].Value = model.FBRQ;
            parameters[6].Value = model.ZRZ;
            parameters[7].Value = model.Content;
            parameters[8].Value = model.NRGS;
            parameters[9].Value = model.ViewNum;
            parameters[10].Value = model.Author;
            parameters[11].Value = model.IsPass;
            parameters[12].Value = model.Type;
            parameters[13].Value = model.SourceURL;
            parameters[14].Value = model.ColumnCode;
            parameters[15].Value = model.SYH;
            parameters[16].Value = model.WH;
            parameters[17].Value = model.isDelete;
            parameters[18].Value = model.DepId;
            parameters[19].Value = model.fuJian;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        #region  成员方法
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(SASCMS.Model.TB_Article model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_Article set ");
            //strSql.Append("QWBS=@QWBS,");
            strSql.Append("ViewNum=@ViewNum,");
            strSql.Append("Author=@Author,");
            strSql.Append("IsPass=@IsPass,");
            strSql.Append("Type=@Type,");
            strSql.Append("SourceURL=@SourceURL,");
            strSql.Append("ColumnCode=@ColumnCode,");
            strSql.Append("SYH=@SYH,");
            strSql.Append("WH=@WH,");
            strSql.Append("isDelete=@isDelete,");
            strSql.Append("DepId=@DepId,");
            strSql.Append("ColumnId=@ColumnId,");
            strSql.Append("fuJian=@fuJian,");
            strSql.Append("TF=@TF,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("CWRQ=@CWRQ,");
            strSql.Append("FBRQ=@FBRQ,");
            strSql.Append("ZRZ=@ZRZ,");
            strSql.Append("Content=@Content,");
            strSql.Append("NRGS=@NRGS");
            strSql.Append(" where QWBS=@QWBS ");
            OleDbParameter[] parameters = {
					
					new OleDbParameter("@ViewNum", OleDbType.Integer,4),
					new OleDbParameter("@Author", OleDbType.VarChar,0),
					new OleDbParameter("@IsPass", OleDbType.Integer,4),
					new OleDbParameter("@Type", OleDbType.VarChar,0),
					new OleDbParameter("@SourceURL", OleDbType.VarChar,0),
					new OleDbParameter("@ColumnCode", OleDbType.VarChar,0),
					new OleDbParameter("@SYH", OleDbType.VarChar,0),
					new OleDbParameter("@WH", OleDbType.VarChar,0),
					new OleDbParameter("@isDelete", OleDbType.Integer,4),
					new OleDbParameter("@DepId", OleDbType.VarChar,0),
					new OleDbParameter("@ColumnId", OleDbType.VarChar,0),
					new OleDbParameter("@fuJian", OleDbType.VarChar,0),
					new OleDbParameter("@TF", OleDbType.VarChar,0),
					new OleDbParameter("@AddDate", OleDbType.Date),
					new OleDbParameter("@CWRQ", OleDbType.Date),
					new OleDbParameter("@FBRQ", OleDbType.Date),
					new OleDbParameter("@ZRZ", OleDbType.VarChar,0),
					new OleDbParameter("@Content", OleDbType.VarChar,0),
					new OleDbParameter("@NRGS", OleDbType.VarChar,0),
                    new OleDbParameter("@QWBS", OleDbType.VarChar,0)};
            parameters[0].Value = model.ViewNum;
            parameters[1].Value = model.Author;
            parameters[2].Value = model.IsPass;
            parameters[3].Value = model.Type;
            parameters[4].Value = model.SourceURL;
            parameters[5].Value = model.ColumnCode;
            parameters[6].Value = model.SYH;
            parameters[7].Value = model.WH;
            parameters[8].Value = model.isDelete;
            parameters[9].Value = model.DepId;
            parameters[10].Value = model.ColumnId;
            parameters[11].Value = model.fuJian;
            parameters[12].Value = model.TF;
            parameters[13].Value = model.AddDate;
            parameters[14].Value = model.CWRQ;
            parameters[15].Value = model.FBRQ;
            parameters[16].Value = model.ZRZ;
            parameters[17].Value = model.Content;
            parameters[18].Value = model.NRGS;
            parameters[19].Value = model.QWBS;
          
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        #endregion  成员方法

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string QWBS)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TB_Article ");
            strSql.Append(" where QWBS=@QWBS ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@QWBS", OleDbType.VarChar,50)};
            parameters[0].Value = QWBS;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public SASCMS.Model.TB_Article GetModel(string QWBS)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select QWBS,ColumnId,TF,AddDate,CWRQ,FBRQ,ZRZ,Content,NRGS,ViewNum,Author,IsPass,Type,SourceURL,ColumnCode,SYH,WH,isDelete,DepId,fuJian from TB_Article ");
            strSql.Append(" where QWBS=@QWBS ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@QWBS", OleDbType.VarChar,50)};
            parameters[0].Value = QWBS;

            SASCMS.Model.TB_Article model = new SASCMS.Model.TB_Article();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.QWBS = ds.Tables[0].Rows[0]["QWBS"].ToString();
                model.ColumnId = ds.Tables[0].Rows[0]["ColumnId"].ToString();
                model.TF = ds.Tables[0].Rows[0]["TF"].ToString();
                if (ds.Tables[0].Rows[0]["AddDate"].ToString() != "")
                {
                    model.AddDate = DateTime.Parse(ds.Tables[0].Rows[0]["AddDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CWRQ"].ToString() != "")
                {
                    model.CWRQ = DateTime.Parse(ds.Tables[0].Rows[0]["CWRQ"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FBRQ"].ToString() != "")
                {
                    model.FBRQ = DateTime.Parse(ds.Tables[0].Rows[0]["FBRQ"].ToString());
                }
                model.ZRZ = ds.Tables[0].Rows[0]["ZRZ"].ToString();
                model.Content = ds.Tables[0].Rows[0]["Content"].ToString();
                model.NRGS = ds.Tables[0].Rows[0]["NRGS"].ToString();
                if (ds.Tables[0].Rows[0]["ViewNum"].ToString() != "")
                {
                    model.ViewNum = int.Parse(ds.Tables[0].Rows[0]["ViewNum"].ToString());
                }
                model.Author = ds.Tables[0].Rows[0]["Author"].ToString();
                if (ds.Tables[0].Rows[0]["IsPass"].ToString() != "")
                {
                    model.IsPass = int.Parse(ds.Tables[0].Rows[0]["IsPass"].ToString());
                }
                model.Type = ds.Tables[0].Rows[0]["Type"].ToString();
                model.SourceURL = ds.Tables[0].Rows[0]["SourceURL"].ToString();
                model.ColumnCode = ds.Tables[0].Rows[0]["ColumnCode"].ToString();
                model.SYH = ds.Tables[0].Rows[0]["SYH"].ToString();
                model.WH = ds.Tables[0].Rows[0]["WH"].ToString();
                if (ds.Tables[0].Rows[0]["isDelete"].ToString() != "")
                {
                    model.isDelete = int.Parse(ds.Tables[0].Rows[0]["isDelete"].ToString());
                }
                model.DepId = ds.Tables[0].Rows[0]["DepId"].ToString();
                model.fuJian = ds.Tables[0].Rows[0]["fuJian"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select QWBS,ColumnId,TF,AddDate,CWRQ,FBRQ,ZRZ,Content,NRGS,ViewNum,Author,IsPass,Type,SourceURL,ColumnCode,SYH,WH,isDelete,DepId,fuJian ");
            strSql.Append(" FROM TB_Article ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            OleDbParameter[] parameters = {
                    new OleDbParameter("@tblName", OleDbType.VarChar, 255),
                    new OleDbParameter("@fldName", OleDbType.VarChar, 255),
                    new OleDbParameter("@PageSize", OleDbType.Integer),
                    new OleDbParameter("@PageIndex", OleDbType.Integer),
                    new OleDbParameter("@IsReCount", OleDbType.Boolean),
                    new OleDbParameter("@OrderType", OleDbType.Boolean),
                    new OleDbParameter("@strWhere", OleDbType.VarChar,1000),
                    };
            parameters[0].Value = "TB_Article";
            parameters[1].Value = "ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  成员方法
    }
}

