using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using SASCMS.DBUtility;//请先添加引用
namespace SASCMS.DataAccess
{
    // <summary>
    /// 类TB_DOWNLOAD。
    /// </summary>
    [Serializable]
    public partial class TB_DOWNLOAD
    {
        public TB_DOWNLOAD()
        { }
        #region Model
        private string _project_type;
        private string _check_type;
        private string _project_name;
        private string _zhaobiaogonggao;
        private string _zhaobiaowenjian;
        private string _shigongkanchabaogao;
        private string _gongchengliangqqingdan;
        private string _shejibiangeng;
        private string _xianjiatongzhi;
        private string _buchongtongzhi;
        private string _shigongshejituwenjian;
        private string _download_password;
        private int? _download_day;
        private DateTime? _update_on;
        private string _download_member;
        private DateTime? _create_on;
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        public string PROJECT_TYPE
        {
            set { _project_type = value; }
            get { return _project_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CHECK_TYPE
        {
            set { _check_type = value; }
            get { return _check_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECT_NAME
        {
            set { _project_name = value; }
            get { return _project_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZHAOBIAOGONGGAO
        {
            set { _zhaobiaogonggao = value; }
            get { return _zhaobiaogonggao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZHAOBIAOWENJIAN
        {
            set { _zhaobiaowenjian = value; }
            get { return _zhaobiaowenjian; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SHIGONGKANCHABAOGAO
        {
            set { _shigongkanchabaogao = value; }
            get { return _shigongkanchabaogao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GONGCHENGLIANGQQINGDAN
        {
            set { _gongchengliangqqingdan = value; }
            get { return _gongchengliangqqingdan; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SHEJIBIANGENG
        {
            set { _shejibiangeng = value; }
            get { return _shejibiangeng; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string XIANJIATONGZHI
        {
            set { _xianjiatongzhi = value; }
            get { return _xianjiatongzhi; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BUCHONGTONGZHI
        {
            set { _buchongtongzhi = value; }
            get { return _buchongtongzhi; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SHIGONGSHEJITUWENJIAN
        {
            set { _shigongshejituwenjian = value; }
            get { return _shigongshejituwenjian; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DOWNLOAD_PASSWORD
        {
            set { _download_password = value; }
            get { return _download_password; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? DOWNLOAD_DAY
        {
            set { _download_day = value; }
            get { return _download_day; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UPDATE_ON
        {
            set { _update_on = value; }
            get { return _update_on; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DOWNLOAD_MEMBER
        {
            set { _download_member = value; }
            get { return _download_member; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CREATE_ON
        {
            set { _create_on = value; }
            get { return _create_on; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public TB_DOWNLOAD(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select PROJECT_TYPE,CHECK_TYPE,PROJECT_NAME,ZHAOBIAOGONGGAO,ZHAOBIAOWENJIAN,SHIGONGKANCHABAOGAO,GONGCHENGLIANGQQINGDAN,SHEJIBIANGENG,XIANJIATONGZHI,BUCHONGTONGZHI,SHIGONGSHEJITUWENJIAN,DOWNLOAD_PASSWORD,DOWNLOAD_DAY,UPDATE_ON,DOWNLOAD_MEMBER,CREATE_ON,ID ");
            strSql.Append(" FROM [TB_DOWNLOAD] ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["PROJECT_TYPE"] != null && ds.Tables[0].Rows[0]["PROJECT_TYPE"].ToString() != "")
                {
                    this.PROJECT_TYPE = ds.Tables[0].Rows[0]["PROJECT_TYPE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CHECK_TYPE"] != null && ds.Tables[0].Rows[0]["CHECK_TYPE"].ToString() != "")
                {
                    this.CHECK_TYPE = ds.Tables[0].Rows[0]["CHECK_TYPE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["PROJECT_NAME"] != null && ds.Tables[0].Rows[0]["PROJECT_NAME"].ToString() != "")
                {
                    this.PROJECT_NAME = ds.Tables[0].Rows[0]["PROJECT_NAME"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ZHAOBIAOGONGGAO"] != null && ds.Tables[0].Rows[0]["ZHAOBIAOGONGGAO"].ToString() != "")
                {
                    this.ZHAOBIAOGONGGAO = ds.Tables[0].Rows[0]["ZHAOBIAOGONGGAO"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ZHAOBIAOWENJIAN"] != null && ds.Tables[0].Rows[0]["ZHAOBIAOWENJIAN"].ToString() != "")
                {
                    this.ZHAOBIAOWENJIAN = ds.Tables[0].Rows[0]["ZHAOBIAOWENJIAN"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SHIGONGKANCHABAOGAO"] != null && ds.Tables[0].Rows[0]["SHIGONGKANCHABAOGAO"].ToString() != "")
                {
                    this.SHIGONGKANCHABAOGAO = ds.Tables[0].Rows[0]["SHIGONGKANCHABAOGAO"].ToString();
                }
                if (ds.Tables[0].Rows[0]["GONGCHENGLIANGQQINGDAN"] != null && ds.Tables[0].Rows[0]["GONGCHENGLIANGQQINGDAN"].ToString() != "")
                {
                    this.GONGCHENGLIANGQQINGDAN = ds.Tables[0].Rows[0]["GONGCHENGLIANGQQINGDAN"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SHEJIBIANGENG"] != null && ds.Tables[0].Rows[0]["SHEJIBIANGENG"].ToString() != "")
                {
                    this.SHEJIBIANGENG = ds.Tables[0].Rows[0]["SHEJIBIANGENG"].ToString();
                }
                if (ds.Tables[0].Rows[0]["XIANJIATONGZHI"] != null && ds.Tables[0].Rows[0]["XIANJIATONGZHI"].ToString() != "")
                {
                    this.XIANJIATONGZHI = ds.Tables[0].Rows[0]["XIANJIATONGZHI"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BUCHONGTONGZHI"] != null && ds.Tables[0].Rows[0]["BUCHONGTONGZHI"].ToString() != "")
                {
                    this.BUCHONGTONGZHI = ds.Tables[0].Rows[0]["BUCHONGTONGZHI"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SHIGONGSHEJITUWENJIAN"] != null && ds.Tables[0].Rows[0]["SHIGONGSHEJITUWENJIAN"].ToString() != "")
                {
                    this.SHIGONGSHEJITUWENJIAN = ds.Tables[0].Rows[0]["SHIGONGSHEJITUWENJIAN"].ToString();
                }
                if (ds.Tables[0].Rows[0]["DOWNLOAD_PASSWORD"] != null && ds.Tables[0].Rows[0]["DOWNLOAD_PASSWORD"].ToString() != "")
                {
                    this.DOWNLOAD_PASSWORD = ds.Tables[0].Rows[0]["DOWNLOAD_PASSWORD"].ToString();
                }
                if (ds.Tables[0].Rows[0]["DOWNLOAD_DAY"] != null && ds.Tables[0].Rows[0]["DOWNLOAD_DAY"].ToString() != "")
                {
                    this.DOWNLOAD_DAY = int.Parse(ds.Tables[0].Rows[0]["DOWNLOAD_DAY"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UPDATE_ON"] != null && ds.Tables[0].Rows[0]["UPDATE_ON"].ToString() != "")
                {
                    this.UPDATE_ON = DateTime.Parse(ds.Tables[0].Rows[0]["UPDATE_ON"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DOWNLOAD_MEMBER"] != null && ds.Tables[0].Rows[0]["DOWNLOAD_MEMBER"].ToString() != "")
                {
                    this.DOWNLOAD_MEMBER = ds.Tables[0].Rows[0]["DOWNLOAD_MEMBER"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CREATE_ON"] != null && ds.Tables[0].Rows[0]["CREATE_ON"].ToString() != "")
                {
                    this.CREATE_ON = DateTime.Parse(ds.Tables[0].Rows[0]["CREATE_ON"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    this.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [TB_DOWNLOAD]");
            strSql.Append(" where ID=@ID ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [TB_DOWNLOAD] (");
            strSql.Append("PROJECT_TYPE,CHECK_TYPE,PROJECT_NAME,ZHAOBIAOGONGGAO,ZHAOBIAOWENJIAN,SHIGONGKANCHABAOGAO,GONGCHENGLIANGQQINGDAN,SHEJIBIANGENG,XIANJIATONGZHI,BUCHONGTONGZHI,SHIGONGSHEJITUWENJIAN,DOWNLOAD_PASSWORD,DOWNLOAD_DAY,UPDATE_ON,DOWNLOAD_MEMBER,CREATE_ON)");
            strSql.Append(" values (");
            strSql.Append("@PROJECT_TYPE,@CHECK_TYPE,@PROJECT_NAME,@ZHAOBIAOGONGGAO,@ZHAOBIAOWENJIAN,@SHIGONGKANCHABAOGAO,@GONGCHENGLIANGQQINGDAN,@SHEJIBIANGENG,@XIANJIATONGZHI,@BUCHONGTONGZHI,@SHIGONGSHEJITUWENJIAN,@DOWNLOAD_PASSWORD,@DOWNLOAD_DAY,@UPDATE_ON,@DOWNLOAD_MEMBER,@CREATE_ON)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@PROJECT_TYPE", OleDbType.VarChar,255),
					new OleDbParameter("@CHECK_TYPE", OleDbType.VarChar,255),
					new OleDbParameter("@PROJECT_NAME", OleDbType.VarChar,255),
					new OleDbParameter("@ZHAOBIAOGONGGAO", OleDbType.VarChar,0),
					new OleDbParameter("@ZHAOBIAOWENJIAN", OleDbType.VarChar,0),
					new OleDbParameter("@SHIGONGKANCHABAOGAO", OleDbType.VarChar,0),
					new OleDbParameter("@GONGCHENGLIANGQQINGDAN", OleDbType.VarChar,0),
					new OleDbParameter("@SHEJIBIANGENG", OleDbType.VarChar,0),
					new OleDbParameter("@XIANJIATONGZHI", OleDbType.VarChar,0),
					new OleDbParameter("@BUCHONGTONGZHI", OleDbType.VarChar,0),
					new OleDbParameter("@SHIGONGSHEJITUWENJIAN", OleDbType.VarChar,0),
					new OleDbParameter("@DOWNLOAD_PASSWORD", OleDbType.VarChar,255),
					new OleDbParameter("@DOWNLOAD_DAY", OleDbType.Integer,4),
					new OleDbParameter("@UPDATE_ON", OleDbType.Date),
					new OleDbParameter("@DOWNLOAD_MEMBER", OleDbType.VarChar,0),
					new OleDbParameter("@CREATE_ON", OleDbType.Date)};
            parameters[0].Value = PROJECT_TYPE;
            parameters[1].Value = CHECK_TYPE;
            parameters[2].Value = PROJECT_NAME;
            parameters[3].Value = ZHAOBIAOGONGGAO;
            parameters[4].Value = ZHAOBIAOWENJIAN;
            parameters[5].Value = SHIGONGKANCHABAOGAO;
            parameters[6].Value = GONGCHENGLIANGQQINGDAN;
            parameters[7].Value = SHEJIBIANGENG;
            parameters[8].Value = XIANJIATONGZHI;
            parameters[9].Value = BUCHONGTONGZHI;
            parameters[10].Value = SHIGONGSHEJITUWENJIAN;
            parameters[11].Value = DOWNLOAD_PASSWORD;
            parameters[12].Value = DOWNLOAD_DAY;
            parameters[13].Value = UPDATE_ON;
            parameters[14].Value = DOWNLOAD_MEMBER;
            parameters[15].Value = CREATE_ON;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [TB_DOWNLOAD] set ");
            strSql.Append("PROJECT_TYPE=@PROJECT_TYPE,");
            strSql.Append("CHECK_TYPE=@CHECK_TYPE,");
            strSql.Append("PROJECT_NAME=@PROJECT_NAME,");
            strSql.Append("ZHAOBIAOGONGGAO=@ZHAOBIAOGONGGAO,");
            strSql.Append("ZHAOBIAOWENJIAN=@ZHAOBIAOWENJIAN,");
            strSql.Append("SHIGONGKANCHABAOGAO=@SHIGONGKANCHABAOGAO,");
            strSql.Append("GONGCHENGLIANGQQINGDAN=@GONGCHENGLIANGQQINGDAN,");
            strSql.Append("SHEJIBIANGENG=@SHEJIBIANGENG,");
            strSql.Append("XIANJIATONGZHI=@XIANJIATONGZHI,");
            strSql.Append("BUCHONGTONGZHI=@BUCHONGTONGZHI,");
            strSql.Append("SHIGONGSHEJITUWENJIAN=@SHIGONGSHEJITUWENJIAN,");
            strSql.Append("DOWNLOAD_PASSWORD=@DOWNLOAD_PASSWORD,");
            strSql.Append("DOWNLOAD_DAY=@DOWNLOAD_DAY,");
            strSql.Append("UPDATE_ON=@UPDATE_ON,");
            strSql.Append("DOWNLOAD_MEMBER=@DOWNLOAD_MEMBER,");
            strSql.Append("CREATE_ON=@CREATE_ON");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@PROJECT_TYPE", OleDbType.VarChar,255),
					new OleDbParameter("@CHECK_TYPE", OleDbType.VarChar,255),
					new OleDbParameter("@PROJECT_NAME", OleDbType.VarChar,255),
					new OleDbParameter("@ZHAOBIAOGONGGAO", OleDbType.VarChar,0),
					new OleDbParameter("@ZHAOBIAOWENJIAN", OleDbType.VarChar,0),
					new OleDbParameter("@SHIGONGKANCHABAOGAO", OleDbType.VarChar,0),
					new OleDbParameter("@GONGCHENGLIANGQQINGDAN", OleDbType.VarChar,0),
					new OleDbParameter("@SHEJIBIANGENG", OleDbType.VarChar,0),
					new OleDbParameter("@XIANJIATONGZHI", OleDbType.VarChar,0),
					new OleDbParameter("@BUCHONGTONGZHI", OleDbType.VarChar,0),
					new OleDbParameter("@SHIGONGSHEJITUWENJIAN", OleDbType.VarChar,0),
					new OleDbParameter("@DOWNLOAD_PASSWORD", OleDbType.VarChar,255),
					new OleDbParameter("@DOWNLOAD_DAY", OleDbType.Integer,4),
					new OleDbParameter("@UPDATE_ON", OleDbType.Date),
					new OleDbParameter("@DOWNLOAD_MEMBER", OleDbType.VarChar,0),
					new OleDbParameter("@CREATE_ON", OleDbType.Date),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = PROJECT_TYPE;
            parameters[1].Value = CHECK_TYPE;
            parameters[2].Value = PROJECT_NAME;
            parameters[3].Value = ZHAOBIAOGONGGAO;
            parameters[4].Value = ZHAOBIAOWENJIAN;
            parameters[5].Value = SHIGONGKANCHABAOGAO;
            parameters[6].Value = GONGCHENGLIANGQQINGDAN;
            parameters[7].Value = SHEJIBIANGENG;
            parameters[8].Value = XIANJIATONGZHI;
            parameters[9].Value = BUCHONGTONGZHI;
            parameters[10].Value = SHIGONGSHEJITUWENJIAN;
            parameters[11].Value = DOWNLOAD_PASSWORD;
            parameters[12].Value = DOWNLOAD_DAY;
            parameters[13].Value = UPDATE_ON;
            parameters[14].Value = DOWNLOAD_MEMBER;
            parameters[15].Value = CREATE_ON;
            parameters[16].Value = ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [TB_DOWNLOAD] ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select PROJECT_TYPE,CHECK_TYPE,PROJECT_NAME,ZHAOBIAOGONGGAO,ZHAOBIAOWENJIAN,SHIGONGKANCHABAOGAO,GONGCHENGLIANGQQINGDAN,SHEJIBIANGENG,XIANJIATONGZHI,BUCHONGTONGZHI,SHIGONGSHEJITUWENJIAN,DOWNLOAD_PASSWORD,DOWNLOAD_DAY,UPDATE_ON,DOWNLOAD_MEMBER,CREATE_ON,ID ");
            strSql.Append(" FROM [TB_DOWNLOAD] ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["PROJECT_TYPE"] != null && ds.Tables[0].Rows[0]["PROJECT_TYPE"].ToString() != "")
                {
                    this.PROJECT_TYPE = ds.Tables[0].Rows[0]["PROJECT_TYPE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CHECK_TYPE"] != null && ds.Tables[0].Rows[0]["CHECK_TYPE"].ToString() != "")
                {
                    this.CHECK_TYPE = ds.Tables[0].Rows[0]["CHECK_TYPE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["PROJECT_NAME"] != null && ds.Tables[0].Rows[0]["PROJECT_NAME"].ToString() != "")
                {
                    this.PROJECT_NAME = ds.Tables[0].Rows[0]["PROJECT_NAME"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ZHAOBIAOGONGGAO"] != null && ds.Tables[0].Rows[0]["ZHAOBIAOGONGGAO"].ToString() != "")
                {
                    this.ZHAOBIAOGONGGAO = ds.Tables[0].Rows[0]["ZHAOBIAOGONGGAO"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ZHAOBIAOWENJIAN"] != null && ds.Tables[0].Rows[0]["ZHAOBIAOWENJIAN"].ToString() != "")
                {
                    this.ZHAOBIAOWENJIAN = ds.Tables[0].Rows[0]["ZHAOBIAOWENJIAN"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SHIGONGKANCHABAOGAO"] != null && ds.Tables[0].Rows[0]["SHIGONGKANCHABAOGAO"].ToString() != "")
                {
                    this.SHIGONGKANCHABAOGAO = ds.Tables[0].Rows[0]["SHIGONGKANCHABAOGAO"].ToString();
                }
                if (ds.Tables[0].Rows[0]["GONGCHENGLIANGQQINGDAN"] != null && ds.Tables[0].Rows[0]["GONGCHENGLIANGQQINGDAN"].ToString() != "")
                {
                    this.GONGCHENGLIANGQQINGDAN = ds.Tables[0].Rows[0]["GONGCHENGLIANGQQINGDAN"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SHEJIBIANGENG"] != null && ds.Tables[0].Rows[0]["SHEJIBIANGENG"].ToString() != "")
                {
                    this.SHEJIBIANGENG = ds.Tables[0].Rows[0]["SHEJIBIANGENG"].ToString();
                }
                if (ds.Tables[0].Rows[0]["XIANJIATONGZHI"] != null && ds.Tables[0].Rows[0]["XIANJIATONGZHI"].ToString() != "")
                {
                    this.XIANJIATONGZHI = ds.Tables[0].Rows[0]["XIANJIATONGZHI"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BUCHONGTONGZHI"] != null && ds.Tables[0].Rows[0]["BUCHONGTONGZHI"].ToString() != "")
                {
                    this.BUCHONGTONGZHI = ds.Tables[0].Rows[0]["BUCHONGTONGZHI"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SHIGONGSHEJITUWENJIAN"] != null && ds.Tables[0].Rows[0]["SHIGONGSHEJITUWENJIAN"].ToString() != "")
                {
                    this.SHIGONGSHEJITUWENJIAN = ds.Tables[0].Rows[0]["SHIGONGSHEJITUWENJIAN"].ToString();
                }
                if (ds.Tables[0].Rows[0]["DOWNLOAD_PASSWORD"] != null && ds.Tables[0].Rows[0]["DOWNLOAD_PASSWORD"].ToString() != "")
                {
                    this.DOWNLOAD_PASSWORD = ds.Tables[0].Rows[0]["DOWNLOAD_PASSWORD"].ToString();
                }
                if (ds.Tables[0].Rows[0]["DOWNLOAD_DAY"] != null && ds.Tables[0].Rows[0]["DOWNLOAD_DAY"].ToString() != "")
                {
                    this.DOWNLOAD_DAY = int.Parse(ds.Tables[0].Rows[0]["DOWNLOAD_DAY"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UPDATE_ON"] != null && ds.Tables[0].Rows[0]["UPDATE_ON"].ToString() != "")
                {
                    this.UPDATE_ON = DateTime.Parse(ds.Tables[0].Rows[0]["UPDATE_ON"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DOWNLOAD_MEMBER"] != null && ds.Tables[0].Rows[0]["DOWNLOAD_MEMBER"].ToString() != "")
                {
                    this.DOWNLOAD_MEMBER = ds.Tables[0].Rows[0]["DOWNLOAD_MEMBER"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CREATE_ON"] != null && ds.Tables[0].Rows[0]["CREATE_ON"].ToString() != "")
                {
                    this.CREATE_ON = DateTime.Parse(ds.Tables[0].Rows[0]["CREATE_ON"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    this.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [TB_DOWNLOAD] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}

