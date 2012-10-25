using System;
namespace sharejoy.Model
{
    /// <summary>
    /// share:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class share 
    {
        public share()
        { }
        #region Model
        private int _id;
        private int _category;
        private string _category_title;
        private string _content;
        private string _resource;
        private DateTime? _update_date;
        private DateTime _create_date;
        private string _update_user;
        private string _create_user;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int category
        {
            set { _category = value; }
            get { return _category; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string category_title
        {
            set { _category_title = value; }
            get { return _category_title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string content
        {
            set { _content = value; }
            get { return _content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string resource
        {
            set { _resource = value; }
            get { return _resource; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? update_date
        {
            set { _update_date = value; }
            get { return _update_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime create_date
        {
            set { _create_date = value; }
            get { return _create_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string update_user
        {
            set { _update_user = value; }
            get { return _update_user; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string create_user
        {
            set { _create_user = value; }
            get { return _create_user; }
        }
        #endregion Model

    }
}
