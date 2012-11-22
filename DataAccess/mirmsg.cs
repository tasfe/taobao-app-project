using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using DBUtility;//请先添加引用

namespace weibo.DataAccess
{
    /// <summary>
    /// 类mirmsg。
    /// </summary>
    [Serializable]
    public partial class mirmsg
    {
        public mirmsg()
        { }
        #region Model
        private DateTime? _createdat;
        private double? _id;
        private string _text;
        private string _source;
        private string _thumbnailpictureurl;
        private string _middlesizepictureurl;
        private string _originalpictureurl;
        private DateTime? _createon;
        private string _note;

        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreatedAt
        {
            set { _createdat = value; }
            get { return _createdat; }
        }
        /// <summary>
        /// 
        /// </summary>
        public double? ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Text
        {
            set { _text = value; }
            get { return _text; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Source
        {
            set { _source = value; }
            get { return _source; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ThumbnailPictureUrl
        {
            set { _thumbnailpictureurl = value; }
            get { return _thumbnailpictureurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MiddleSizePictureUrl
        {
            set { _middlesizepictureurl = value; }
            get { return _middlesizepictureurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OriginalPictureUrl
        {
            set { _originalpictureurl = value; }
            get { return _originalpictureurl; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateOn
        {
            set { _createon = value; }
            get { return _createon; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Note
        {
            set { _note = value; }
            get { return _note; }
        }
        #endregion Model
    }
}

