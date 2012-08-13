using System;
using System.Text;
using System.IO;


namespace ShopUtil
{
    /// <summary>
    /// 日志类
    /// </summary>
    public class LogInfo
    {
        /// <summary>
        /// 日志文件大小
        /// </summary>
        private static int fileSize = 2048 * 1024;


        /// <summary>
        /// 日志文件的路径
        /// </summary>
        private static string fileLogPath;


        /// <summary>
        /// 日志文件的名称
        /// </summary>
        private static string logFileName;

        
        /// <summary>
        /// 构造函数,初始化日志文件大小[2M]
        /// 可以使用相关属性对其进行更改.
        /// </summary>
        public LogInfo()
        {
            //初始化大于2M日志文件将自动删除;
            fileSize=2048*1024;//2M
            //默认路径
            fileLogPath=@"c:\logFils\";
            logFileName="web日志.txt";
        }
        
        /// <summary>
        /// 获取或设置定义日志文件大小
        /// </summary>
        public static int FileSize
        {
            set
            {
                fileSize=value;
            }
            get
            {
                return fileSize;
            }
        }


        /// <summary>
        /// 获取或设置日志文件的路径
        /// </summary>
        public static string FileLogPath
        {
            set
            {
                fileLogPath=value;
            }
            get
            {
                return fileLogPath;
            }
        }

        
        /// <summary>
        /// 获取或设置日志文件的名称
        /// </summary>
        public static string LogFileName
        {
            set
            {
                logFileName=value;
            }
            get
            {
                return logFileName;
            }
            
        }

        

        /// <summary>
        /// 向指定目录中的指定的文件中追加日志文件
        /// </summary>
        /// <param name="Message">要写入的内容</param>
        public static void WriteLog(string Message)
        {
            WriteLog(logFileName,Message);
        }



        /// <summary>
        /// 向指定目录中的文件中追加日志文件,日志文件的名称将由传递的参数决定.
        /// </summary>
        /// <param name="LogFileName">日志文件的名称,如:mylog.txt ,如果没有自动创建,如果存在将追加写入日志</param>
        /// <param name="Message">要写入的内容</param>
        public static void WriteLog(string LogFileName,string Message)
        {      
            //DirectoryInfo path=new DirectoryInfo(LogFileName);
            //如果日志文件目录不存在,则创建
            if(!Directory.Exists(fileLogPath))
            {
                Directory.CreateDirectory(fileLogPath);
            }
            string filePath = Path.Combine(fileLogPath, LogFileName);
            FileInfo finfo = new FileInfo(filePath);
            //if(finfo.Exists&&finfo.Length>fileSize)
            //{
            //    filePath = Path.Combine(fileLogPath, DateTime.Now.ToString("yyyyMMddhhmmss")+ LogFileName);
            //    //finfo.Delete();
            //}
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Append);
                StreamWriter strwriter=new StreamWriter(fs);
                try
                {
                    
                    DateTime d=DateTime.Now;
                    strwriter.WriteLine("时间:"+d.ToString());
                    strwriter.WriteLine(Message);
                    strwriter.WriteLine();
                    strwriter.Flush();
                }
                catch(Exception ee)
                {
                    Console.WriteLine("日志文件写入失败信息:"+ee.ToString());    
                }
                finally
                {
                    strwriter.Close();
                    strwriter=null;
                    fs.Close();
                    fs=null;
                }
            }
            catch(Exception ee)
            {
                Console.WriteLine("日志文件没有打开,详细信息如下:"+ee.ToString());
                
            }
        }
    }
}
