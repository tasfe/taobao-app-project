using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using SASCMS.DBUtility;//Please add references
namespace SASCMS.DataAccess
{
    /// <summary>
    /// 类TB_MEMBER。
    /// </summary>
    [Serializable]
    public partial class TB_MEMBER
    {
        public TB_MEMBER()
        { }
        #region Model
        private string _contact_name;
        private string _contact_tel;
        private string _email;
        private string _yinyezhizhao_no;
        private string _yinyezhizhao_pic;
        private string _zizhizhengshu_no;
        private string _zizhizhengshu_pic;
        private string _farendabiao_name;
        private string _farendabiao_pic;
        private string _farendabiao_sex;
        private string _anquanshengc_pic;
        private string _bank;
        private string _bank_account_name;
        private string _bank_account_no;
        private DateTime? _update_on;
        private string _member_password;
        private int? _member_status;
        private string _anquanshengchan_no;
        private string _anquanshengchan_pic;
        private string _comments;
        private string _contact_no;
        private string _company_name;
        private string _company_location;
        private string _company_address;
        private string _company_money;
        private string _company_level1;
        private string _company_level2;
        private string _company_level3;
        private string _company_level4;
        private string _company_level5;
        private string _bank_account_pic;
        private int _member_id;
        private DateTime? _create_on;
        /// <summary>
        /// 
        /// </summary>
        public string CONTACT_NAME
        {
            set { _contact_name = value; }
            get { return _contact_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONTACT_TEL
        {
            set { _contact_tel = value; }
            get { return _contact_tel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string YINYEZHIZHAO_NO
        {
            set { _yinyezhizhao_no = value; }
            get { return _yinyezhizhao_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string YINYEZHIZHAO_PIC
        {
            set { _yinyezhizhao_pic = value; }
            get { return _yinyezhizhao_pic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZIZHIZHENGSHU_NO
        {
            set { _zizhizhengshu_no = value; }
            get { return _zizhizhengshu_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZIZHIZHENGSHU_PIC
        {
            set { _zizhizhengshu_pic = value; }
            get { return _zizhizhengshu_pic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FARENDABIAO_NAME
        {
            set { _farendabiao_name = value; }
            get { return _farendabiao_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FARENDABIAO_PIC
        {
            set { _farendabiao_pic = value; }
            get { return _farendabiao_pic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FARENDABIAO_SEX
        {
            set { _farendabiao_sex = value; }
            get { return _farendabiao_sex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ANQUANSHENGC_PIC
        {
            set { _anquanshengc_pic = value; }
            get { return _anquanshengc_pic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BANK
        {
            set { _bank = value; }
            get { return _bank; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BANK_ACCOUNT_NAME
        {
            set { _bank_account_name = value; }
            get { return _bank_account_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BANK_ACCOUNT_NO
        {
            set { _bank_account_no = value; }
            get { return _bank_account_no; }
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
        public string MEMBER_PASSWORD
        {
            set { _member_password = value; }
            get { return _member_password; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? MEMBER_STATUS
        {
            set { _member_status = value; }
            get { return _member_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ANQUANSHENGCHAN_NO
        {
            set { _anquanshengchan_no = value; }
            get { return _anquanshengchan_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ANQUANSHENGCHAN_PIC
        {
            set { _anquanshengchan_pic = value; }
            get { return _anquanshengchan_pic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string COMMENTS
        {
            set { _comments = value; }
            get { return _comments; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONTACT_NO
        {
            set { _contact_no = value; }
            get { return _contact_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string COMPANY_NAME
        {
            set { _company_name = value; }
            get { return _company_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string COMPANY_LOCATION
        {
            set { _company_location = value; }
            get { return _company_location; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string COMPANY_ADDRESS
        {
            set { _company_address = value; }
            get { return _company_address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string COMPANY_MONEY
        {
            set { _company_money = value; }
            get { return _company_money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string COMPANY_LEVEL1
        {
            set { _company_level1 = value; }
            get { return _company_level1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string COMPANY_LEVEL2
        {
            set { _company_level2 = value; }
            get { return _company_level2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string COMPANY_LEVEL3
        {
            set { _company_level3 = value; }
            get { return _company_level3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string COMPANY_LEVEL4
        {
            set { _company_level4 = value; }
            get { return _company_level4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string COMPANY_LEVEL5
        {
            set { _company_level5 = value; }
            get { return _company_level5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BANK_ACCOUNT_PIC
        {
            set { _bank_account_pic = value; }
            get { return _bank_account_pic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int MEMBER_ID
        {
            set { _member_id = value; }
            get { return _member_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CREATE_ON
        {
            set { _create_on = value; }
            get { return _create_on; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public TB_MEMBER(int MEMBER_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CONTACT_NAME,CONTACT_TEL,EMAIL,YINYEZHIZHAO_NO,YINYEZHIZHAO_PIC,ZIZHIZHENGSHU_NO,ZIZHIZHENGSHU_PIC,FARENDABIAO_NAME,FARENDABIAO_PIC,FARENDABIAO_SEX,ANQUANSHENGC_PIC,BANK,BANK_ACCOUNT_NAME,BANK_ACCOUNT_NO,UPDATE_ON,MEMBER_PASSWORD,MEMBER_STATUS,ANQUANSHENGCHAN_NO,ANQUANSHENGCHAN_PIC,COMMENTS,CONTACT_NO,COMPANY_NAME,COMPANY_LOCATION,COMPANY_ADDRESS,COMPANY_MONEY,COMPANY_LEVEL1,COMPANY_LEVEL2,COMPANY_LEVEL3,COMPANY_LEVEL4,COMPANY_LEVEL5,BANK_ACCOUNT_PIC,MEMBER_ID,CREATE_ON ");
            strSql.Append(" FROM [TB_MEMBER] ");
            strSql.Append(" where MEMBER_ID=@MEMBER_ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@MEMBER_ID", OleDbType.Integer,4)};
            parameters[0].Value = MEMBER_ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["CONTACT_NAME"] != null && ds.Tables[0].Rows[0]["CONTACT_NAME"].ToString() != "")
                {
                    this.CONTACT_NAME = ds.Tables[0].Rows[0]["CONTACT_NAME"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CONTACT_TEL"] != null && ds.Tables[0].Rows[0]["CONTACT_TEL"].ToString() != "")
                {
                    this.CONTACT_TEL = ds.Tables[0].Rows[0]["CONTACT_TEL"].ToString();
                }
                if (ds.Tables[0].Rows[0]["EMAIL"] != null && ds.Tables[0].Rows[0]["EMAIL"].ToString() != "")
                {
                    this.EMAIL = ds.Tables[0].Rows[0]["EMAIL"].ToString();
                }
                if (ds.Tables[0].Rows[0]["YINYEZHIZHAO_NO"] != null && ds.Tables[0].Rows[0]["YINYEZHIZHAO_NO"].ToString() != "")
                {
                    this.YINYEZHIZHAO_NO = ds.Tables[0].Rows[0]["YINYEZHIZHAO_NO"].ToString();
                }
                if (ds.Tables[0].Rows[0]["YINYEZHIZHAO_PIC"] != null && ds.Tables[0].Rows[0]["YINYEZHIZHAO_PIC"].ToString() != "")
                {
                    this.YINYEZHIZHAO_PIC = ds.Tables[0].Rows[0]["YINYEZHIZHAO_PIC"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ZIZHIZHENGSHU_NO"] != null && ds.Tables[0].Rows[0]["ZIZHIZHENGSHU_NO"].ToString() != "")
                {
                    this.ZIZHIZHENGSHU_NO = ds.Tables[0].Rows[0]["ZIZHIZHENGSHU_NO"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ZIZHIZHENGSHU_PIC"] != null && ds.Tables[0].Rows[0]["ZIZHIZHENGSHU_PIC"].ToString() != "")
                {
                    this.ZIZHIZHENGSHU_PIC = ds.Tables[0].Rows[0]["ZIZHIZHENGSHU_PIC"].ToString();
                }
                if (ds.Tables[0].Rows[0]["FARENDABIAO_NAME"] != null && ds.Tables[0].Rows[0]["FARENDABIAO_NAME"].ToString() != "")
                {
                    this.FARENDABIAO_NAME = ds.Tables[0].Rows[0]["FARENDABIAO_NAME"].ToString();
                }
                if (ds.Tables[0].Rows[0]["FARENDABIAO_PIC"] != null && ds.Tables[0].Rows[0]["FARENDABIAO_PIC"].ToString() != "")
                {
                    this.FARENDABIAO_PIC = ds.Tables[0].Rows[0]["FARENDABIAO_PIC"].ToString();
                }
                if (ds.Tables[0].Rows[0]["FARENDABIAO_SEX"] != null && ds.Tables[0].Rows[0]["FARENDABIAO_SEX"].ToString() != "")
                {
                    this.FARENDABIAO_SEX = ds.Tables[0].Rows[0]["FARENDABIAO_SEX"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ANQUANSHENGC_PIC"] != null && ds.Tables[0].Rows[0]["ANQUANSHENGC_PIC"].ToString() != "")
                {
                    this.ANQUANSHENGC_PIC = ds.Tables[0].Rows[0]["ANQUANSHENGC_PIC"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BANK"] != null && ds.Tables[0].Rows[0]["BANK"].ToString() != "")
                {
                    this.BANK = ds.Tables[0].Rows[0]["BANK"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BANK_ACCOUNT_NAME"] != null && ds.Tables[0].Rows[0]["BANK_ACCOUNT_NAME"].ToString() != "")
                {
                    this.BANK_ACCOUNT_NAME = ds.Tables[0].Rows[0]["BANK_ACCOUNT_NAME"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BANK_ACCOUNT_NO"] != null && ds.Tables[0].Rows[0]["BANK_ACCOUNT_NO"].ToString() != "")
                {
                    this.BANK_ACCOUNT_NO = ds.Tables[0].Rows[0]["BANK_ACCOUNT_NO"].ToString();
                }
                if (ds.Tables[0].Rows[0]["UPDATE_ON"] != null && ds.Tables[0].Rows[0]["UPDATE_ON"].ToString() != "")
                {
                    this.UPDATE_ON = DateTime.Parse(ds.Tables[0].Rows[0]["UPDATE_ON"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MEMBER_PASSWORD"] != null && ds.Tables[0].Rows[0]["MEMBER_PASSWORD"].ToString() != "")
                {
                    this.MEMBER_PASSWORD = ds.Tables[0].Rows[0]["MEMBER_PASSWORD"].ToString();
                }
                if (ds.Tables[0].Rows[0]["MEMBER_STATUS"] != null && ds.Tables[0].Rows[0]["MEMBER_STATUS"].ToString() != "")
                {
                    this.MEMBER_STATUS = int.Parse(ds.Tables[0].Rows[0]["MEMBER_STATUS"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ANQUANSHENGCHAN_NO"] != null && ds.Tables[0].Rows[0]["ANQUANSHENGCHAN_NO"].ToString() != "")
                {
                    this.ANQUANSHENGCHAN_NO = ds.Tables[0].Rows[0]["ANQUANSHENGCHAN_NO"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ANQUANSHENGCHAN_PIC"] != null && ds.Tables[0].Rows[0]["ANQUANSHENGCHAN_PIC"].ToString() != "")
                {
                    this.ANQUANSHENGCHAN_PIC = ds.Tables[0].Rows[0]["ANQUANSHENGCHAN_PIC"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMMENTS"] != null && ds.Tables[0].Rows[0]["COMMENTS"].ToString() != "")
                {
                    this.COMMENTS = ds.Tables[0].Rows[0]["COMMENTS"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CONTACT_NO"] != null && ds.Tables[0].Rows[0]["CONTACT_NO"].ToString() != "")
                {
                    this.CONTACT_NO = ds.Tables[0].Rows[0]["CONTACT_NO"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_NAME"] != null && ds.Tables[0].Rows[0]["COMPANY_NAME"].ToString() != "")
                {
                    this.COMPANY_NAME = ds.Tables[0].Rows[0]["COMPANY_NAME"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_LOCATION"] != null && ds.Tables[0].Rows[0]["COMPANY_LOCATION"].ToString() != "")
                {
                    this.COMPANY_LOCATION = ds.Tables[0].Rows[0]["COMPANY_LOCATION"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_ADDRESS"] != null && ds.Tables[0].Rows[0]["COMPANY_ADDRESS"].ToString() != "")
                {
                    this.COMPANY_ADDRESS = ds.Tables[0].Rows[0]["COMPANY_ADDRESS"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_MONEY"] != null && ds.Tables[0].Rows[0]["COMPANY_MONEY"].ToString() != "")
                {
                    this.COMPANY_MONEY = ds.Tables[0].Rows[0]["COMPANY_MONEY"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_LEVEL1"] != null && ds.Tables[0].Rows[0]["COMPANY_LEVEL1"].ToString() != "")
                {
                    this.COMPANY_LEVEL1 = ds.Tables[0].Rows[0]["COMPANY_LEVEL1"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_LEVEL2"] != null && ds.Tables[0].Rows[0]["COMPANY_LEVEL2"].ToString() != "")
                {
                    this.COMPANY_LEVEL2 = ds.Tables[0].Rows[0]["COMPANY_LEVEL2"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_LEVEL3"] != null && ds.Tables[0].Rows[0]["COMPANY_LEVEL3"].ToString() != "")
                {
                    this.COMPANY_LEVEL3 = ds.Tables[0].Rows[0]["COMPANY_LEVEL3"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_LEVEL4"] != null && ds.Tables[0].Rows[0]["COMPANY_LEVEL4"].ToString() != "")
                {
                    this.COMPANY_LEVEL4 = ds.Tables[0].Rows[0]["COMPANY_LEVEL4"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_LEVEL5"] != null && ds.Tables[0].Rows[0]["COMPANY_LEVEL5"].ToString() != "")
                {
                    this.COMPANY_LEVEL5 = ds.Tables[0].Rows[0]["COMPANY_LEVEL5"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BANK_ACCOUNT_PIC"] != null && ds.Tables[0].Rows[0]["BANK_ACCOUNT_PIC"].ToString() != "")
                {
                    this.BANK_ACCOUNT_PIC = ds.Tables[0].Rows[0]["BANK_ACCOUNT_PIC"].ToString();
                }
                if (ds.Tables[0].Rows[0]["MEMBER_ID"] != null && ds.Tables[0].Rows[0]["MEMBER_ID"].ToString() != "")
                {
                    this.MEMBER_ID = int.Parse(ds.Tables[0].Rows[0]["MEMBER_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CREATE_ON"] != null && ds.Tables[0].Rows[0]["CREATE_ON"].ToString() != "")
                {
                    this.CREATE_ON = DateTime.Parse(ds.Tables[0].Rows[0]["CREATE_ON"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int MEMBER_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [TB_MEMBER]");
            strSql.Append(" where MEMBER_ID=@MEMBER_ID ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@MEMBER_ID", OleDbType.Integer,4)};
            parameters[0].Value = MEMBER_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [TB_MEMBER] (");
            strSql.Append("CONTACT_NAME,CONTACT_TEL,EMAIL,YINYEZHIZHAO_NO,YINYEZHIZHAO_PIC,ZIZHIZHENGSHU_NO,ZIZHIZHENGSHU_PIC,FARENDABIAO_NAME,FARENDABIAO_PIC,FARENDABIAO_SEX,ANQUANSHENGC_PIC,BANK,BANK_ACCOUNT_NAME,BANK_ACCOUNT_NO,UPDATE_ON,MEMBER_PASSWORD,MEMBER_STATUS,ANQUANSHENGCHAN_NO,ANQUANSHENGCHAN_PIC,COMMENTS,CONTACT_NO,COMPANY_NAME,COMPANY_LOCATION,COMPANY_ADDRESS,COMPANY_MONEY,COMPANY_LEVEL1,COMPANY_LEVEL2,COMPANY_LEVEL3,COMPANY_LEVEL4,COMPANY_LEVEL5,BANK_ACCOUNT_PIC,CREATE_ON)");
            strSql.Append(" values (");
            strSql.Append("@CONTACT_NAME,@CONTACT_TEL,@EMAIL,@YINYEZHIZHAO_NO,@YINYEZHIZHAO_PIC,@ZIZHIZHENGSHU_NO,@ZIZHIZHENGSHU_PIC,@FARENDABIAO_NAME,@FARENDABIAO_PIC,@FARENDABIAO_SEX,@ANQUANSHENGC_PIC,@BANK,@BANK_ACCOUNT_NAME,@BANK_ACCOUNT_NO,@UPDATE_ON,@MEMBER_PASSWORD,@MEMBER_STATUS,@ANQUANSHENGCHAN_NO,@ANQUANSHENGCHAN_PIC,@COMMENTS,@CONTACT_NO,@COMPANY_NAME,@COMPANY_LOCATION,@COMPANY_ADDRESS,@COMPANY_MONEY,@COMPANY_LEVEL1,@COMPANY_LEVEL2,@COMPANY_LEVEL3,@COMPANY_LEVEL4,@COMPANY_LEVEL5,@BANK_ACCOUNT_PIC,@CREATE_ON)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@CONTACT_NAME", OleDbType.VarChar,255),
					new OleDbParameter("@CONTACT_TEL", OleDbType.VarChar,255),
					new OleDbParameter("@EMAIL", OleDbType.VarChar,255),
					new OleDbParameter("@YINYEZHIZHAO_NO", OleDbType.VarChar,255),
					new OleDbParameter("@YINYEZHIZHAO_PIC", OleDbType.VarChar,255),
					new OleDbParameter("@ZIZHIZHENGSHU_NO", OleDbType.VarChar,255),
					new OleDbParameter("@ZIZHIZHENGSHU_PIC", OleDbType.VarChar,255),
					new OleDbParameter("@FARENDABIAO_NAME", OleDbType.VarChar,255),
					new OleDbParameter("@FARENDABIAO_PIC", OleDbType.VarChar,255),
					new OleDbParameter("@FARENDABIAO_SEX", OleDbType.VarChar,255),
					new OleDbParameter("@ANQUANSHENGC_PIC", OleDbType.VarChar,255),
					new OleDbParameter("@BANK", OleDbType.VarChar,255),
					new OleDbParameter("@BANK_ACCOUNT_NAME", OleDbType.VarChar,255),
					new OleDbParameter("@BANK_ACCOUNT_NO", OleDbType.VarChar,255),
					new OleDbParameter("@UPDATE_ON", OleDbType.Date),
					new OleDbParameter("@MEMBER_PASSWORD", OleDbType.VarChar,255),
					new OleDbParameter("@MEMBER_STATUS", OleDbType.Integer,4),
					new OleDbParameter("@ANQUANSHENGCHAN_NO", OleDbType.VarChar,255),
					new OleDbParameter("@ANQUANSHENGCHAN_PIC", OleDbType.VarChar,255),
					new OleDbParameter("@COMMENTS", OleDbType.VarChar,255),
					new OleDbParameter("@CONTACT_NO", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_NAME", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_LOCATION", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_ADDRESS", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_MONEY", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_LEVEL1", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_LEVEL2", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_LEVEL3", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_LEVEL4", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_LEVEL5", OleDbType.VarChar,255),
					new OleDbParameter("@BANK_ACCOUNT_PIC", OleDbType.VarChar,255),
					new OleDbParameter("@CREATE_ON", OleDbType.Date)};
            parameters[0].Value = CONTACT_NAME;
            parameters[1].Value = CONTACT_TEL;
            parameters[2].Value = EMAIL;
            parameters[3].Value = YINYEZHIZHAO_NO;
            parameters[4].Value = YINYEZHIZHAO_PIC;
            parameters[5].Value = ZIZHIZHENGSHU_NO;
            parameters[6].Value = ZIZHIZHENGSHU_PIC;
            parameters[7].Value = FARENDABIAO_NAME;
            parameters[8].Value = FARENDABIAO_PIC;
            parameters[9].Value = FARENDABIAO_SEX;
            parameters[10].Value = ANQUANSHENGC_PIC;
            parameters[11].Value = BANK;
            parameters[12].Value = BANK_ACCOUNT_NAME;
            parameters[13].Value = BANK_ACCOUNT_NO;
            parameters[14].Value = UPDATE_ON;
            parameters[15].Value = MEMBER_PASSWORD;
            parameters[16].Value = MEMBER_STATUS;
            parameters[17].Value = ANQUANSHENGCHAN_NO;
            parameters[18].Value = ANQUANSHENGCHAN_PIC;
            parameters[19].Value = COMMENTS;
            parameters[20].Value = CONTACT_NO;
            parameters[21].Value = COMPANY_NAME;
            parameters[22].Value = COMPANY_LOCATION;
            parameters[23].Value = COMPANY_ADDRESS;
            parameters[24].Value = COMPANY_MONEY;
            parameters[25].Value = COMPANY_LEVEL1;
            parameters[26].Value = COMPANY_LEVEL2;
            parameters[27].Value = COMPANY_LEVEL3;
            parameters[28].Value = COMPANY_LEVEL4;
            parameters[29].Value = COMPANY_LEVEL5;
            parameters[30].Value = BANK_ACCOUNT_PIC;
            parameters[31].Value = CREATE_ON;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [TB_MEMBER] set ");
            strSql.Append("CONTACT_NAME=@CONTACT_NAME,");
            strSql.Append("CONTACT_TEL=@CONTACT_TEL,");
            strSql.Append("EMAIL=@EMAIL,");
            strSql.Append("YINYEZHIZHAO_NO=@YINYEZHIZHAO_NO,");
            strSql.Append("YINYEZHIZHAO_PIC=@YINYEZHIZHAO_PIC,");
            strSql.Append("ZIZHIZHENGSHU_NO=@ZIZHIZHENGSHU_NO,");
            strSql.Append("ZIZHIZHENGSHU_PIC=@ZIZHIZHENGSHU_PIC,");
            strSql.Append("FARENDABIAO_NAME=@FARENDABIAO_NAME,");
            strSql.Append("FARENDABIAO_PIC=@FARENDABIAO_PIC,");
            strSql.Append("FARENDABIAO_SEX=@FARENDABIAO_SEX,");
            strSql.Append("ANQUANSHENGC_PIC=@ANQUANSHENGC_PIC,");
            strSql.Append("BANK=@BANK,");
            strSql.Append("BANK_ACCOUNT_NAME=@BANK_ACCOUNT_NAME,");
            strSql.Append("BANK_ACCOUNT_NO=@BANK_ACCOUNT_NO,");
            strSql.Append("UPDATE_ON=@UPDATE_ON,");
            strSql.Append("MEMBER_PASSWORD=@MEMBER_PASSWORD,");
            strSql.Append("MEMBER_STATUS=@MEMBER_STATUS,");
            strSql.Append("ANQUANSHENGCHAN_NO=@ANQUANSHENGCHAN_NO,");
            strSql.Append("ANQUANSHENGCHAN_PIC=@ANQUANSHENGCHAN_PIC,");
            strSql.Append("COMMENTS=@COMMENTS,");
            strSql.Append("CONTACT_NO=@CONTACT_NO,");
            strSql.Append("COMPANY_NAME=@COMPANY_NAME,");
            strSql.Append("COMPANY_LOCATION=@COMPANY_LOCATION,");
            strSql.Append("COMPANY_ADDRESS=@COMPANY_ADDRESS,");
            strSql.Append("COMPANY_MONEY=@COMPANY_MONEY,");
            strSql.Append("COMPANY_LEVEL1=@COMPANY_LEVEL1,");
            strSql.Append("COMPANY_LEVEL2=@COMPANY_LEVEL2,");
            strSql.Append("COMPANY_LEVEL3=@COMPANY_LEVEL3,");
            strSql.Append("COMPANY_LEVEL4=@COMPANY_LEVEL4,");
            strSql.Append("COMPANY_LEVEL5=@COMPANY_LEVEL5,");
            strSql.Append("BANK_ACCOUNT_PIC=@BANK_ACCOUNT_PIC,");
            strSql.Append("CREATE_ON=@CREATE_ON");
            strSql.Append(" where MEMBER_ID=@MEMBER_ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@CONTACT_NAME", OleDbType.VarChar,255),
					new OleDbParameter("@CONTACT_TEL", OleDbType.VarChar,255),
					new OleDbParameter("@EMAIL", OleDbType.VarChar,255),
					new OleDbParameter("@YINYEZHIZHAO_NO", OleDbType.VarChar,255),
					new OleDbParameter("@YINYEZHIZHAO_PIC", OleDbType.VarChar,255),
					new OleDbParameter("@ZIZHIZHENGSHU_NO", OleDbType.VarChar,255),
					new OleDbParameter("@ZIZHIZHENGSHU_PIC", OleDbType.VarChar,255),
					new OleDbParameter("@FARENDABIAO_NAME", OleDbType.VarChar,255),
					new OleDbParameter("@FARENDABIAO_PIC", OleDbType.VarChar,255),
					new OleDbParameter("@FARENDABIAO_SEX", OleDbType.VarChar,255),
					new OleDbParameter("@ANQUANSHENGC_PIC", OleDbType.VarChar,255),
					new OleDbParameter("@BANK", OleDbType.VarChar,255),
					new OleDbParameter("@BANK_ACCOUNT_NAME", OleDbType.VarChar,255),
					new OleDbParameter("@BANK_ACCOUNT_NO", OleDbType.VarChar,255),
					new OleDbParameter("@UPDATE_ON", OleDbType.Date),
					new OleDbParameter("@MEMBER_PASSWORD", OleDbType.VarChar,255),
					new OleDbParameter("@MEMBER_STATUS", OleDbType.Integer,4),
					new OleDbParameter("@ANQUANSHENGCHAN_NO", OleDbType.VarChar,255),
					new OleDbParameter("@ANQUANSHENGCHAN_PIC", OleDbType.VarChar,255),
					new OleDbParameter("@COMMENTS", OleDbType.VarChar,255),
					new OleDbParameter("@CONTACT_NO", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_NAME", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_LOCATION", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_ADDRESS", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_MONEY", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_LEVEL1", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_LEVEL2", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_LEVEL3", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_LEVEL4", OleDbType.VarChar,255),
					new OleDbParameter("@COMPANY_LEVEL5", OleDbType.VarChar,255),
					new OleDbParameter("@BANK_ACCOUNT_PIC", OleDbType.VarChar,255),
					new OleDbParameter("@CREATE_ON", OleDbType.Date),
					new OleDbParameter("@MEMBER_ID", OleDbType.Integer,4)};
            parameters[0].Value = CONTACT_NAME;
            parameters[1].Value = CONTACT_TEL;
            parameters[2].Value = EMAIL;
            parameters[3].Value = YINYEZHIZHAO_NO;
            parameters[4].Value = YINYEZHIZHAO_PIC;
            parameters[5].Value = ZIZHIZHENGSHU_NO;
            parameters[6].Value = ZIZHIZHENGSHU_PIC;
            parameters[7].Value = FARENDABIAO_NAME;
            parameters[8].Value = FARENDABIAO_PIC;
            parameters[9].Value = FARENDABIAO_SEX;
            parameters[10].Value = ANQUANSHENGC_PIC;
            parameters[11].Value = BANK;
            parameters[12].Value = BANK_ACCOUNT_NAME;
            parameters[13].Value = BANK_ACCOUNT_NO;
            parameters[14].Value = UPDATE_ON;
            parameters[15].Value = MEMBER_PASSWORD;
            parameters[16].Value = MEMBER_STATUS;
            parameters[17].Value = ANQUANSHENGCHAN_NO;
            parameters[18].Value = ANQUANSHENGCHAN_PIC;
            parameters[19].Value = COMMENTS;
            parameters[20].Value = CONTACT_NO;
            parameters[21].Value = COMPANY_NAME;
            parameters[22].Value = COMPANY_LOCATION;
            parameters[23].Value = COMPANY_ADDRESS;
            parameters[24].Value = COMPANY_MONEY;
            parameters[25].Value = COMPANY_LEVEL1;
            parameters[26].Value = COMPANY_LEVEL2;
            parameters[27].Value = COMPANY_LEVEL3;
            parameters[28].Value = COMPANY_LEVEL4;
            parameters[29].Value = COMPANY_LEVEL5;
            parameters[30].Value = BANK_ACCOUNT_PIC;
            parameters[31].Value = CREATE_ON;
            parameters[32].Value = MEMBER_ID;

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
        public bool Delete(int MEMBER_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [TB_MEMBER] ");
            strSql.Append(" where MEMBER_ID=@MEMBER_ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@MEMBER_ID", OleDbType.Integer,4)};
            parameters[0].Value = MEMBER_ID;

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
        public void GetModel(int MEMBER_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CONTACT_NAME,CONTACT_TEL,EMAIL,YINYEZHIZHAO_NO,YINYEZHIZHAO_PIC,ZIZHIZHENGSHU_NO,ZIZHIZHENGSHU_PIC,FARENDABIAO_NAME,FARENDABIAO_PIC,FARENDABIAO_SEX,ANQUANSHENGC_PIC,BANK,BANK_ACCOUNT_NAME,BANK_ACCOUNT_NO,UPDATE_ON,MEMBER_PASSWORD,MEMBER_STATUS,ANQUANSHENGCHAN_NO,ANQUANSHENGCHAN_PIC,COMMENTS,CONTACT_NO,COMPANY_NAME,COMPANY_LOCATION,COMPANY_ADDRESS,COMPANY_MONEY,COMPANY_LEVEL1,COMPANY_LEVEL2,COMPANY_LEVEL3,COMPANY_LEVEL4,COMPANY_LEVEL5,BANK_ACCOUNT_PIC,MEMBER_ID,CREATE_ON ");
            strSql.Append(" FROM [TB_MEMBER] ");
            strSql.Append(" where MEMBER_ID=@MEMBER_ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@MEMBER_ID", OleDbType.Integer,4)};
            parameters[0].Value = MEMBER_ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["CONTACT_NAME"] != null && ds.Tables[0].Rows[0]["CONTACT_NAME"].ToString() != "")
                {
                    this.CONTACT_NAME = ds.Tables[0].Rows[0]["CONTACT_NAME"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CONTACT_TEL"] != null && ds.Tables[0].Rows[0]["CONTACT_TEL"].ToString() != "")
                {
                    this.CONTACT_TEL = ds.Tables[0].Rows[0]["CONTACT_TEL"].ToString();
                }
                if (ds.Tables[0].Rows[0]["EMAIL"] != null && ds.Tables[0].Rows[0]["EMAIL"].ToString() != "")
                {
                    this.EMAIL = ds.Tables[0].Rows[0]["EMAIL"].ToString();
                }
                if (ds.Tables[0].Rows[0]["YINYEZHIZHAO_NO"] != null && ds.Tables[0].Rows[0]["YINYEZHIZHAO_NO"].ToString() != "")
                {
                    this.YINYEZHIZHAO_NO = ds.Tables[0].Rows[0]["YINYEZHIZHAO_NO"].ToString();
                }
                if (ds.Tables[0].Rows[0]["YINYEZHIZHAO_PIC"] != null && ds.Tables[0].Rows[0]["YINYEZHIZHAO_PIC"].ToString() != "")
                {
                    this.YINYEZHIZHAO_PIC = ds.Tables[0].Rows[0]["YINYEZHIZHAO_PIC"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ZIZHIZHENGSHU_NO"] != null && ds.Tables[0].Rows[0]["ZIZHIZHENGSHU_NO"].ToString() != "")
                {
                    this.ZIZHIZHENGSHU_NO = ds.Tables[0].Rows[0]["ZIZHIZHENGSHU_NO"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ZIZHIZHENGSHU_PIC"] != null && ds.Tables[0].Rows[0]["ZIZHIZHENGSHU_PIC"].ToString() != "")
                {
                    this.ZIZHIZHENGSHU_PIC = ds.Tables[0].Rows[0]["ZIZHIZHENGSHU_PIC"].ToString();
                }
                if (ds.Tables[0].Rows[0]["FARENDABIAO_NAME"] != null && ds.Tables[0].Rows[0]["FARENDABIAO_NAME"].ToString() != "")
                {
                    this.FARENDABIAO_NAME = ds.Tables[0].Rows[0]["FARENDABIAO_NAME"].ToString();
                }
                if (ds.Tables[0].Rows[0]["FARENDABIAO_PIC"] != null && ds.Tables[0].Rows[0]["FARENDABIAO_PIC"].ToString() != "")
                {
                    this.FARENDABIAO_PIC = ds.Tables[0].Rows[0]["FARENDABIAO_PIC"].ToString();
                }
                if (ds.Tables[0].Rows[0]["FARENDABIAO_SEX"] != null && ds.Tables[0].Rows[0]["FARENDABIAO_SEX"].ToString() != "")
                {
                    this.FARENDABIAO_SEX = ds.Tables[0].Rows[0]["FARENDABIAO_SEX"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ANQUANSHENGC_PIC"] != null && ds.Tables[0].Rows[0]["ANQUANSHENGC_PIC"].ToString() != "")
                {
                    this.ANQUANSHENGC_PIC = ds.Tables[0].Rows[0]["ANQUANSHENGC_PIC"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BANK"] != null && ds.Tables[0].Rows[0]["BANK"].ToString() != "")
                {
                    this.BANK = ds.Tables[0].Rows[0]["BANK"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BANK_ACCOUNT_NAME"] != null && ds.Tables[0].Rows[0]["BANK_ACCOUNT_NAME"].ToString() != "")
                {
                    this.BANK_ACCOUNT_NAME = ds.Tables[0].Rows[0]["BANK_ACCOUNT_NAME"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BANK_ACCOUNT_NO"] != null && ds.Tables[0].Rows[0]["BANK_ACCOUNT_NO"].ToString() != "")
                {
                    this.BANK_ACCOUNT_NO = ds.Tables[0].Rows[0]["BANK_ACCOUNT_NO"].ToString();
                }
                if (ds.Tables[0].Rows[0]["UPDATE_ON"] != null && ds.Tables[0].Rows[0]["UPDATE_ON"].ToString() != "")
                {
                    this.UPDATE_ON = DateTime.Parse(ds.Tables[0].Rows[0]["UPDATE_ON"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MEMBER_PASSWORD"] != null && ds.Tables[0].Rows[0]["MEMBER_PASSWORD"].ToString() != "")
                {
                    this.MEMBER_PASSWORD = ds.Tables[0].Rows[0]["MEMBER_PASSWORD"].ToString();
                }
                if (ds.Tables[0].Rows[0]["MEMBER_STATUS"] != null && ds.Tables[0].Rows[0]["MEMBER_STATUS"].ToString() != "")
                {
                    this.MEMBER_STATUS = int.Parse(ds.Tables[0].Rows[0]["MEMBER_STATUS"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ANQUANSHENGCHAN_NO"] != null && ds.Tables[0].Rows[0]["ANQUANSHENGCHAN_NO"].ToString() != "")
                {
                    this.ANQUANSHENGCHAN_NO = ds.Tables[0].Rows[0]["ANQUANSHENGCHAN_NO"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ANQUANSHENGCHAN_PIC"] != null && ds.Tables[0].Rows[0]["ANQUANSHENGCHAN_PIC"].ToString() != "")
                {
                    this.ANQUANSHENGCHAN_PIC = ds.Tables[0].Rows[0]["ANQUANSHENGCHAN_PIC"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMMENTS"] != null && ds.Tables[0].Rows[0]["COMMENTS"].ToString() != "")
                {
                    this.COMMENTS = ds.Tables[0].Rows[0]["COMMENTS"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CONTACT_NO"] != null && ds.Tables[0].Rows[0]["CONTACT_NO"].ToString() != "")
                {
                    this.CONTACT_NO = ds.Tables[0].Rows[0]["CONTACT_NO"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_NAME"] != null && ds.Tables[0].Rows[0]["COMPANY_NAME"].ToString() != "")
                {
                    this.COMPANY_NAME = ds.Tables[0].Rows[0]["COMPANY_NAME"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_LOCATION"] != null && ds.Tables[0].Rows[0]["COMPANY_LOCATION"].ToString() != "")
                {
                    this.COMPANY_LOCATION = ds.Tables[0].Rows[0]["COMPANY_LOCATION"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_ADDRESS"] != null && ds.Tables[0].Rows[0]["COMPANY_ADDRESS"].ToString() != "")
                {
                    this.COMPANY_ADDRESS = ds.Tables[0].Rows[0]["COMPANY_ADDRESS"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_MONEY"] != null && ds.Tables[0].Rows[0]["COMPANY_MONEY"].ToString() != "")
                {
                    this.COMPANY_MONEY = ds.Tables[0].Rows[0]["COMPANY_MONEY"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_LEVEL1"] != null && ds.Tables[0].Rows[0]["COMPANY_LEVEL1"].ToString() != "")
                {
                    this.COMPANY_LEVEL1 = ds.Tables[0].Rows[0]["COMPANY_LEVEL1"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_LEVEL2"] != null && ds.Tables[0].Rows[0]["COMPANY_LEVEL2"].ToString() != "")
                {
                    this.COMPANY_LEVEL2 = ds.Tables[0].Rows[0]["COMPANY_LEVEL2"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_LEVEL3"] != null && ds.Tables[0].Rows[0]["COMPANY_LEVEL3"].ToString() != "")
                {
                    this.COMPANY_LEVEL3 = ds.Tables[0].Rows[0]["COMPANY_LEVEL3"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_LEVEL4"] != null && ds.Tables[0].Rows[0]["COMPANY_LEVEL4"].ToString() != "")
                {
                    this.COMPANY_LEVEL4 = ds.Tables[0].Rows[0]["COMPANY_LEVEL4"].ToString();
                }
                if (ds.Tables[0].Rows[0]["COMPANY_LEVEL5"] != null && ds.Tables[0].Rows[0]["COMPANY_LEVEL5"].ToString() != "")
                {
                    this.COMPANY_LEVEL5 = ds.Tables[0].Rows[0]["COMPANY_LEVEL5"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BANK_ACCOUNT_PIC"] != null && ds.Tables[0].Rows[0]["BANK_ACCOUNT_PIC"].ToString() != "")
                {
                    this.BANK_ACCOUNT_PIC = ds.Tables[0].Rows[0]["BANK_ACCOUNT_PIC"].ToString();
                }
                if (ds.Tables[0].Rows[0]["MEMBER_ID"] != null && ds.Tables[0].Rows[0]["MEMBER_ID"].ToString() != "")
                {
                    this.MEMBER_ID = int.Parse(ds.Tables[0].Rows[0]["MEMBER_ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CREATE_ON"] != null && ds.Tables[0].Rows[0]["CREATE_ON"].ToString() != "")
                {
                    this.CREATE_ON = DateTime.Parse(ds.Tables[0].Rows[0]["CREATE_ON"].ToString());
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
            strSql.Append(" FROM [TB_MEMBER] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}

