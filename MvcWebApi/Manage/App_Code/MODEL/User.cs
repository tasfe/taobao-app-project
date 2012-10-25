using System;
namespace SASCMS.Model
{
    /// <summary>
    /// 实体类TB_User 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class TB_User
    {
        public TB_User()
        { }
        #region Model
        private string _id;
        private string _reg_name;
        private string _reg_pass;
        private int _sex;
        private string _email;
        private int _user_group;
        private string _state;
        private DateTime _regtime;
        private string _regip;
        private DateTime _lastime;
        private string _lastip;
        private string _comefrom;
        private int _login;
        private string _roleid;
        private string _realname;
        private int _isadmin;
        /// <summary>
        /// 
        /// </summary>
        public string Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Reg_Name
        {
            set { _reg_name = value; }
            get { return _reg_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Reg_Pass
        {
            set { _reg_pass = value; }
            get { return _reg_pass; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int User_Group
        {
            set { _user_group = value; }
            get { return _user_group; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string State
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime RegTime
        {
            set { _regtime = value; }
            get { return _regtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RegIp
        {
            set { _regip = value; }
            get { return _regip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime LasTime
        {
            set { _lastime = value; }
            get { return _lastime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LastIp
        {
            set { _lastip = value; }
            get { return _lastip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ComeFrom
        {
            set { _comefrom = value; }
            get { return _comefrom; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int login
        {
            set { _login = value; }
            get { return _login; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RoleId
        {
            set { _roleid = value; }
            get { return _roleid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RealName
        {
            set { _realname = value; }
            get { return _realname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int isAdmin
        {
            set { _isadmin = value; }
            get { return _isadmin; }
        }
        #endregion Model

    }
}

