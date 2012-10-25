using System;
namespace SASCMS.Model
{
    /// <summary>
    /// 实体类TB_Column 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class TB_Column
    {
        public TB_Column()
        { }
        #region Model
        private string _id;
        private string _title;
        private string _parentid;
        private DateTime _updatetime;
        private string _code;
        private int _isurl;
        private string _url;
        private string _shortname;
        private string _transid;
        private int _isvisible;
        private string  _toppic;
        public string TopPic
        {
            set { _toppic = value; }
            get { return _toppic; }
        }
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
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ParentId
        {
            set { _parentid = value; }
            get { return _parentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime updateTime
        {
            set { _updatetime = value; }
            get { return _updatetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Code
        {
            set { _code = value; }
            get { return _code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int isUrl
        {
            set { _isurl = value; }
            get { return _isurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string url
        {
            set { _url = value; }
            get { return _url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string shortName
        {
            set { _shortname = value; }
            get { return _shortname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string transId
        {
            set { _transid = value; }
            get { return _transid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsVisible
        {
            set { _isvisible = value; }
            get { return _isvisible; }
        }
        #endregion Model

    }
}

