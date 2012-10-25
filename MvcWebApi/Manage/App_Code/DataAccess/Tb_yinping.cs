using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using SASCMS.DBUtility;//请先添加引用
namespace JSFT.DAL
{
    /// <summary>
    /// 类tb_yinping。
    /// </summary>
    public class tb_yinping
    {
        public tb_yinping()
        { }
        #region Model
        private string _ypid;
        private string _zpid;
        private string _ypname;
        private int _sex;
        private DateTime _birth;
        private string _idcardnum;
        private string _zhengzhimianmao;
        private string _minzhu;
        private bool _ismarryed;
        private string _guanji;
        private string _hukou;
        private string _xunli;
        private string _school;
        private string _forlanguage;
        private string _languagelevel;
        private string _mailcode;
        private string _tel;
        private string _e_mail;
        private string _ypgangwei;
        private int _monthmoney;
        private string _educationexp;
        private string _workexp;
        private string _projectexp;
        private string _trainexp;
        private string _zhengshu;
        private DateTime _updatedate;
        private string _address;
        private string _techange;
        private string _zhuanye;
        /// <summary>
        /// 
        /// </summary>
        public string ypid
        {
            set { _ypid = value; }
            get { return _ypid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zpid
        {
            set { _zpid = value; }
            get { return _zpid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ypname
        {
            set { _ypname = value; }
            get { return _ypname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime birth
        {
            set { _birth = value; }
            get { return _birth; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IDCardNum
        {
            set { _idcardnum = value; }
            get { return _idcardnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZhengZhiMianMao
        {
            set { _zhengzhimianmao = value; }
            get { return _zhengzhimianmao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MinZhu
        {
            set { _minzhu = value; }
            get { return _minzhu; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsMarryed
        {
            set { _ismarryed = value; }
            get { return _ismarryed; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GuanJi
        {
            set { _guanji = value; }
            get { return _guanji; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Hukou
        {
            set { _hukou = value; }
            get { return _hukou; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string XunLi
        {
            set { _xunli = value; }
            get { return _xunli; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string School
        {
            set { _school = value; }
            get { return _school; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ForLanguage
        {
            set { _forlanguage = value; }
            get { return _forlanguage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LanguageLevel
        {
            set { _languagelevel = value; }
            get { return _languagelevel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MailCode
        {
            set { _mailcode = value; }
            get { return _mailcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Tel
        {
            set { _tel = value; }
            get { return _tel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string E_Mail
        {
            set { _e_mail = value; }
            get { return _e_mail; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string YpGangWei
        {
            set { _ypgangwei = value; }
            get { return _ypgangwei; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int MonthMoney
        {
            set { _monthmoney = value; }
            get { return _monthmoney; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EducationExp
        {
            set { _educationexp = value; }
            get { return _educationexp; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WorkExp
        {
            set { _workexp = value; }
            get { return _workexp; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ProjectExp
        {
            set { _projectexp = value; }
            get { return _projectexp; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TrainExp
        {
            set { _trainexp = value; }
            get { return _trainexp; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Zhengshu
        {
            set { _zhengshu = value; }
            get { return _zhengshu; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime UpdateDate
        {
            set { _updatedate = value; }
            get { return _updatedate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Techange
        {
            set { _techange = value; }
            get { return _techange; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Zhuanye
        {
            set { _zhuanye = value; }
            get { return _zhuanye; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tb_yinping(string ypid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ypid,zpid,ypname,sex,birth,IDCardNum,ZhengZhiMianMao,MinZhu,IsMarryed,GuanJi,Hukou,XunLi,School,ForLanguage,LanguageLevel,MailCode,Tel,E_Mail,YpGangWei,MonthMoney,EducationExp,WorkExp,ProjectExp,TrainExp,Zhengshu,UpdateDate,Address,Techange,Zhuanye ");
            strSql.Append(" FROM tb_yinping ");
            strSql.Append(" where ypid=@ypid ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ypid", OleDbType.VarChar,50)};
            parameters[0].Value = ypid;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ypid = ds.Tables[0].Rows[0]["ypid"].ToString();
                zpid = ds.Tables[0].Rows[0]["zpid"].ToString();
                ypname = ds.Tables[0].Rows[0]["ypname"].ToString();
                if (ds.Tables[0].Rows[0]["sex"].ToString() != "")
                {
                    sex = int.Parse(ds.Tables[0].Rows[0]["sex"].ToString());
                }
                if (ds.Tables[0].Rows[0]["birth"].ToString() != "")
                {
                    birth = DateTime.Parse(ds.Tables[0].Rows[0]["birth"].ToString());
                }
                IDCardNum = ds.Tables[0].Rows[0]["IDCardNum"].ToString();
                ZhengZhiMianMao = ds.Tables[0].Rows[0]["ZhengZhiMianMao"].ToString();
                MinZhu = ds.Tables[0].Rows[0]["MinZhu"].ToString();
                if (ds.Tables[0].Rows[0]["IsMarryed"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsMarryed"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsMarryed"].ToString().ToLower() == "true"))
                    {
                        IsMarryed = true;
                    }
                    else
                    {
                        IsMarryed = false;
                    }
                }

                GuanJi = ds.Tables[0].Rows[0]["GuanJi"].ToString();
                Hukou = ds.Tables[0].Rows[0]["Hukou"].ToString();
                XunLi = ds.Tables[0].Rows[0]["XunLi"].ToString();
                School = ds.Tables[0].Rows[0]["School"].ToString();
                ForLanguage = ds.Tables[0].Rows[0]["ForLanguage"].ToString();
                LanguageLevel = ds.Tables[0].Rows[0]["LanguageLevel"].ToString();
                MailCode = ds.Tables[0].Rows[0]["MailCode"].ToString();
                Tel = ds.Tables[0].Rows[0]["Tel"].ToString();
                E_Mail = ds.Tables[0].Rows[0]["E_Mail"].ToString();
                YpGangWei = ds.Tables[0].Rows[0]["YpGangWei"].ToString();
                if (ds.Tables[0].Rows[0]["MonthMoney"].ToString() != "")
                {
                    MonthMoney = int.Parse(ds.Tables[0].Rows[0]["MonthMoney"].ToString());
                }
                EducationExp = ds.Tables[0].Rows[0]["EducationExp"].ToString();
                WorkExp = ds.Tables[0].Rows[0]["WorkExp"].ToString();
                ProjectExp = ds.Tables[0].Rows[0]["ProjectExp"].ToString();
                TrainExp = ds.Tables[0].Rows[0]["TrainExp"].ToString();
                Zhengshu = ds.Tables[0].Rows[0]["Zhengshu"].ToString();
                if (ds.Tables[0].Rows[0]["UpdateDate"].ToString() != "")
                {
                    UpdateDate = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateDate"].ToString());
                }
                Address = ds.Tables[0].Rows[0]["Address"].ToString();
                Techange = ds.Tables[0].Rows[0]["Techange"].ToString();
                Zhuanye = ds.Tables[0].Rows[0]["Zhuanye"].ToString();
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ypid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_yinping");
            strSql.Append(" where ypid=@ypid ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@ypid", OleDbType.VarChar,50)};
            parameters[0].Value = ypid;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_yinping(");
            strSql.Append("ypid,zpid,ypname,sex,birth,IDCardNum,ZhengZhiMianMao,MinZhu,IsMarryed,GuanJi,Hukou,XunLi,School,ForLanguage,LanguageLevel,MailCode,Tel,E_Mail,YpGangWei,MonthMoney,EducationExp,WorkExp,ProjectExp,TrainExp,Zhengshu,UpdateDate,Address,Techange,Zhuanye)");
            strSql.Append(" values (");
            strSql.Append("@ypid,@zpid,@ypname,@sex,@birth,@IDCardNum,@ZhengZhiMianMao,@MinZhu,@IsMarryed,@GuanJi,@Hukou,@XunLi,@School,@ForLanguage,@LanguageLevel,@MailCode,@Tel,@E_Mail,@YpGangWei,@MonthMoney,@EducationExp,@WorkExp,@ProjectExp,@TrainExp,@Zhengshu,@UpdateDate,@Address,@Techange,@Zhuanye)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ypid", OleDbType.VarChar,50),
					new OleDbParameter("@zpid", OleDbType.VarChar,50),
					new OleDbParameter("@ypname", OleDbType.VarChar,50),
					new OleDbParameter("@sex", OleDbType.Integer,4),
					new OleDbParameter("@birth", OleDbType.Date),
					new OleDbParameter("@IDCardNum", OleDbType.VarChar,50),
					new OleDbParameter("@ZhengZhiMianMao", OleDbType.VarChar,50),
					new OleDbParameter("@MinZhu", OleDbType.VarChar,50),
					new OleDbParameter("@IsMarryed", OleDbType.Boolean),
					new OleDbParameter("@GuanJi", OleDbType.VarChar,50),
					new OleDbParameter("@Hukou", OleDbType.VarChar,50),
					new OleDbParameter("@XunLi", OleDbType.VarChar,50),
					new OleDbParameter("@School", OleDbType.VarChar,50),
					new OleDbParameter("@ForLanguage", OleDbType.VarChar,50),
					new OleDbParameter("@LanguageLevel", OleDbType.VarChar,50),
					new OleDbParameter("@MailCode", OleDbType.VarChar,50),
					new OleDbParameter("@Tel", OleDbType.VarChar,50),
					new OleDbParameter("@E_Mail", OleDbType.VarChar,50),
					new OleDbParameter("@YpGangWei", OleDbType.VarChar,50),
					new OleDbParameter("@MonthMoney", OleDbType.Integer,4),
					new OleDbParameter("@EducationExp", OleDbType.VarChar,0),
					new OleDbParameter("@WorkExp", OleDbType.VarChar,0),
					new OleDbParameter("@ProjectExp", OleDbType.VarChar,0),
					new OleDbParameter("@TrainExp", OleDbType.VarChar,0),
					new OleDbParameter("@Zhengshu", OleDbType.VarChar,50),
					new OleDbParameter("@UpdateDate", OleDbType.Date),
					new OleDbParameter("@Address", OleDbType.VarChar,50),
					new OleDbParameter("@Techange", OleDbType.VarChar,0),
					new OleDbParameter("@Zhuanye", OleDbType.VarChar,50)};
            parameters[0].Value = ypid;
            parameters[1].Value = zpid;
            parameters[2].Value = ypname;
            parameters[3].Value = sex;
            parameters[4].Value = birth;
            parameters[5].Value = IDCardNum;
            parameters[6].Value = ZhengZhiMianMao;
            parameters[7].Value = MinZhu;
            parameters[8].Value = IsMarryed;
            parameters[9].Value = GuanJi;
            parameters[10].Value = Hukou;
            parameters[11].Value = XunLi;
            parameters[12].Value = School;
            parameters[13].Value = ForLanguage;
            parameters[14].Value = LanguageLevel;
            parameters[15].Value = MailCode;
            parameters[16].Value = Tel;
            parameters[17].Value = E_Mail;
            parameters[18].Value = YpGangWei;
            parameters[19].Value = MonthMoney;
            parameters[20].Value = EducationExp;
            parameters[21].Value = WorkExp;
            parameters[22].Value = ProjectExp;
            parameters[23].Value = TrainExp;
            parameters[24].Value = Zhengshu;
            parameters[25].Value = UpdateDate;
            parameters[26].Value = Address;
            parameters[27].Value = Techange;
            parameters[28].Value = Zhuanye;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_yinping set ");
            strSql.Append("ypid=@ypid,");
            strSql.Append("zpid=@zpid,");
            strSql.Append("ypname=@ypname,");
            strSql.Append("sex=@sex,");
            strSql.Append("birth=@birth,");
            strSql.Append("IDCardNum=@IDCardNum,");
            strSql.Append("ZhengZhiMianMao=@ZhengZhiMianMao,");
            strSql.Append("MinZhu=@MinZhu,");
            strSql.Append("IsMarryed=@IsMarryed,");
            strSql.Append("GuanJi=@GuanJi,");
            strSql.Append("Hukou=@Hukou,");
            strSql.Append("XunLi=@XunLi,");
            strSql.Append("School=@School,");
            strSql.Append("ForLanguage=@ForLanguage,");
            strSql.Append("LanguageLevel=@LanguageLevel,");
            strSql.Append("MailCode=@MailCode,");
            strSql.Append("Tel=@Tel,");
            strSql.Append("E_Mail=@E_Mail,");
            strSql.Append("YpGangWei=@YpGangWei,");
            strSql.Append("MonthMoney=@MonthMoney,");
            strSql.Append("EducationExp=@EducationExp,");
            strSql.Append("WorkExp=@WorkExp,");
            strSql.Append("ProjectExp=@ProjectExp,");
            strSql.Append("TrainExp=@TrainExp,");
            strSql.Append("Zhengshu=@Zhengshu,");
            strSql.Append("UpdateDate=@UpdateDate,");
            strSql.Append("Address=@Address,");
            strSql.Append("Techange=@Techange,");
            strSql.Append("Zhuanye=@Zhuanye");
            strSql.Append(" where ypid=@ypid ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ypid", OleDbType.VarChar,50),
					new OleDbParameter("@zpid", OleDbType.VarChar,50),
					new OleDbParameter("@ypname", OleDbType.VarChar,50),
					new OleDbParameter("@sex", OleDbType.Integer,4),
					new OleDbParameter("@birth", OleDbType.Date),
					new OleDbParameter("@IDCardNum", OleDbType.VarChar,50),
					new OleDbParameter("@ZhengZhiMianMao", OleDbType.VarChar,50),
					new OleDbParameter("@MinZhu", OleDbType.VarChar,50),
					new OleDbParameter("@IsMarryed", OleDbType.Boolean),
					new OleDbParameter("@GuanJi", OleDbType.VarChar,50),
					new OleDbParameter("@Hukou", OleDbType.VarChar,50),
					new OleDbParameter("@XunLi", OleDbType.VarChar,50),
					new OleDbParameter("@School", OleDbType.VarChar,50),
					new OleDbParameter("@ForLanguage", OleDbType.VarChar,50),
					new OleDbParameter("@LanguageLevel", OleDbType.VarChar,50),
					new OleDbParameter("@MailCode", OleDbType.VarChar,50),
					new OleDbParameter("@Tel", OleDbType.VarChar,50),
					new OleDbParameter("@E_Mail", OleDbType.VarChar,50),
					new OleDbParameter("@YpGangWei", OleDbType.VarChar,50),
					new OleDbParameter("@MonthMoney", OleDbType.Integer,4),
					new OleDbParameter("@EducationExp", OleDbType.VarChar,0),
					new OleDbParameter("@WorkExp", OleDbType.VarChar,0),
					new OleDbParameter("@ProjectExp", OleDbType.VarChar,0),
					new OleDbParameter("@TrainExp", OleDbType.VarChar,0),
					new OleDbParameter("@Zhengshu", OleDbType.VarChar,50),
					new OleDbParameter("@UpdateDate", OleDbType.Date),
					new OleDbParameter("@Address", OleDbType.VarChar,50),
					new OleDbParameter("@Techange", OleDbType.VarChar,0),
					new OleDbParameter("@Zhuanye", OleDbType.VarChar,50)};
            parameters[0].Value = ypid;
            parameters[1].Value = zpid;
            parameters[2].Value = ypname;
            parameters[3].Value = sex;
            parameters[4].Value = birth;
            parameters[5].Value = IDCardNum;
            parameters[6].Value = ZhengZhiMianMao;
            parameters[7].Value = MinZhu;
            parameters[8].Value = IsMarryed;
            parameters[9].Value = GuanJi;
            parameters[10].Value = Hukou;
            parameters[11].Value = XunLi;
            parameters[12].Value = School;
            parameters[13].Value = ForLanguage;
            parameters[14].Value = LanguageLevel;
            parameters[15].Value = MailCode;
            parameters[16].Value = Tel;
            parameters[17].Value = E_Mail;
            parameters[18].Value = YpGangWei;
            parameters[19].Value = MonthMoney;
            parameters[20].Value = EducationExp;
            parameters[21].Value = WorkExp;
            parameters[22].Value = ProjectExp;
            parameters[23].Value = TrainExp;
            parameters[24].Value = Zhengshu;
            parameters[25].Value = UpdateDate;
            parameters[26].Value = Address;
            parameters[27].Value = Techange;
            parameters[28].Value = Zhuanye;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string ypid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_yinping ");
            strSql.Append(" where ypid=@ypid ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ypid", OleDbType.VarChar,50)};
            parameters[0].Value = ypid;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(string ypid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ypid,zpid,ypname,sex,birth,IDCardNum,ZhengZhiMianMao,MinZhu,IsMarryed,GuanJi,Hukou,XunLi,School,ForLanguage,LanguageLevel,MailCode,Tel,E_Mail,YpGangWei,MonthMoney,EducationExp,WorkExp,ProjectExp,TrainExp,Zhengshu,UpdateDate,Address,Techange,Zhuanye ");
            strSql.Append(" FROM tb_yinping ");
            strSql.Append(" where ypid=@ypid ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ypid", OleDbType.VarChar,50)};
            parameters[0].Value = ypid;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.ypid = ds.Tables[0].Rows[0]["ypid"].ToString();
                this.zpid = ds.Tables[0].Rows[0]["zpid"].ToString();
                this.ypname = ds.Tables[0].Rows[0]["ypname"].ToString();
                if (ds.Tables[0].Rows[0]["sex"].ToString() != "")
                {
                    this.sex = int.Parse(ds.Tables[0].Rows[0]["sex"].ToString());
                }
                if (ds.Tables[0].Rows[0]["birth"].ToString() != "")
                {
                    this.birth = DateTime.Parse(ds.Tables[0].Rows[0]["birth"].ToString());
                }
                this.IDCardNum = ds.Tables[0].Rows[0]["IDCardNum"].ToString();
                this.ZhengZhiMianMao = ds.Tables[0].Rows[0]["ZhengZhiMianMao"].ToString();
                this.MinZhu = ds.Tables[0].Rows[0]["MinZhu"].ToString();
                if (ds.Tables[0].Rows[0]["IsMarryed"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsMarryed"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsMarryed"].ToString().ToLower() == "true"))
                    {
                        this.IsMarryed = true;
                    }
                    else
                    {
                        this.IsMarryed = false;
                    }
                }
                this.GuanJi = ds.Tables[0].Rows[0]["GuanJi"].ToString();
                this.Hukou = ds.Tables[0].Rows[0]["Hukou"].ToString();
                this.XunLi = ds.Tables[0].Rows[0]["XunLi"].ToString();
                this.School = ds.Tables[0].Rows[0]["School"].ToString();
                this.ForLanguage = ds.Tables[0].Rows[0]["ForLanguage"].ToString();
                this.LanguageLevel = ds.Tables[0].Rows[0]["LanguageLevel"].ToString();
                this.MailCode = ds.Tables[0].Rows[0]["MailCode"].ToString();
                this.Tel = ds.Tables[0].Rows[0]["Tel"].ToString();
                this.E_Mail = ds.Tables[0].Rows[0]["E_Mail"].ToString();
                this.YpGangWei = ds.Tables[0].Rows[0]["YpGangWei"].ToString();
                if (ds.Tables[0].Rows[0]["MonthMoney"].ToString() != "")
                {
                    this.MonthMoney = int.Parse(ds.Tables[0].Rows[0]["MonthMoney"].ToString());
                }
                this.EducationExp = ds.Tables[0].Rows[0]["EducationExp"].ToString();
                this.WorkExp = ds.Tables[0].Rows[0]["WorkExp"].ToString();
                this.ProjectExp = ds.Tables[0].Rows[0]["ProjectExp"].ToString();
                this.TrainExp = ds.Tables[0].Rows[0]["TrainExp"].ToString();
                this.Zhengshu = ds.Tables[0].Rows[0]["Zhengshu"].ToString();
                if (ds.Tables[0].Rows[0]["UpdateDate"].ToString() != "")
                {
                    this.UpdateDate = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateDate"].ToString());
                }
                this.Address = ds.Tables[0].Rows[0]["Address"].ToString();
                this.Techange = ds.Tables[0].Rows[0]["Techange"].ToString();
                this.Zhuanye = ds.Tables[0].Rows[0]["Zhuanye"].ToString();
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM tb_yinping ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

