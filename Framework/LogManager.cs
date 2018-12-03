using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;

namespace Framework
{
    public class LogManager
    {
        #region 写入模块整体日志
        /// <summary>
        /// 写入模块整体日志
        /// </summary>
        /// <param name="strSubject">主题</param>
        /// <param name="strModule">模块</param>
        /// <param name="strMethod">方法</param>
        /// <param name="strContent">内容</param>
        public static void WriteTextLog(string strSubject, string strModule, string strMethod, string strContent)
        {
            try
            {
                FileStream FS = new FileStream(GetLogPath() + strSubject + "_" + DateTime.Now.ToString("yyyy_MM_dd") + ".log", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                string strLog = ((("Date:" + DateTime.Now.ToString() + "\r\n") + "Module:" + strModule + "\r\n") + "Method:" + strMethod + "\r\n") + "Error:" + strContent + "\r\n";
                byte[] Log = Encoding.Default.GetBytes(strLog);
                FS.Write(Log, 0, Log.Length);
                FS.Close();
            }
            catch(Exception)
            {
                throw new Exception("写入日志失败！请检查路径及文件系统访问权限！");
            }
        }

        #endregion

        #region 写入模块拆分日志
        /// <summary>
        /// 写入模块拆分日志
        /// </summary>
        /// <param name="strSubject">主题</param>
        /// <param name="strModule">模块</param>
        /// <param name="strMethod">方法</param>
        /// <param name="strContent">内容</param>
        /// <param name="strPath">附加目录</param>
        public static void WriteWinLog(string strSubject, string strModule, string strMethod, string strContent, string strPath)
        {
            string[] strCon = strContent.Split(new char[]{'/'});
            string LogPath = GetLogPath() + strPath;
            if (strPath.Trim().Length > 0)
            {
                try
                {
                    if (!Directory.Exists(LogPath))
                    {
                        Directory.CreateDirectory(LogPath);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("没有创建Log目录的权限!"+ex.Message);
                }
            }
            string strFName = LogPath + "\\" + strSubject + "_" + DateTime.Now.ToString("yyyy_MM_dd") + ".log";
            System.IO.FileInfo fInfo = new FileInfo(strFName);
            using (FileStream fs = fInfo.OpenWrite())
            {
                StreamWriter sw = new StreamWriter(fs);    //根据上面创建的文件流创建写数据流
                sw.BaseStream.Seek(0, SeekOrigin.End);     //设置写数据流的起始位置为文件流的末尾
                string strLog = ((("Date:" + DateTime.Now.ToString() + "\r\n") + "Module:" + strModule + "\r\n") + "Method:" + strMethod + "\r\n");
                sw.Write(strLog);
                for (int i = 0; i < strCon.Length; i++)//写入日志内容并换行
                {
                    sw.Write(strCon[i].ToString() + "\n\r");
                    sw.Write("\n");
                }
                sw.Flush();//清空缓冲区内容，并把缓冲区内容写入基础流
                sw.Close();//关闭写数据流
            }
        }
        #endregion

        #region 读取文件记录
        /// <summary>
        /// 读取文件记录
        /// </summary>
        /// <param name="path">文件物理路径</param>
        /// <returns></returns>
        public static StringBuilder ReadFile(string path)
        {
            try
            {
                StringBuilder strBuild = null;
                string line = string.Empty;
                using (StreamReader sr = new StreamReader(path,System.Text.Encoding.Default))
                {
                    strBuild = new StringBuilder();
                    while ((line = sr.ReadLine()) != null)
                    {
                        strBuild.Append(line);
                    } 
                }
                return strBuild;
            }
            catch(Exception)
            {
                throw new Exception("读取日志失败！");
            }
        }

        #endregion

        #region 删除磁盘文件
        /// <summary>
        ///  删除磁盘文件
        /// </summary>
        /// <param name="path">文件物理路径</param>
        public static void DelFile(string path)
        {
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            try
            {
                if (file.Exists)
                {
                    file.Delete();
                }
            }
            catch (Exception)
            {
                throw new Exception("删除磁盘文件失败！");
            }
        }

        #endregion

        #region 复制文件
        /// <summary>
        ///复制文件
        /// </summary>
        /// <param name="_FileName">原文件</param>
        /// <param name="_CopySource">目标文件</param>
        /// <returns></returns>
        public static bool Copy(string _FileName, string _CopySource)
        {
            bool boolReturn = false;
            FileInfo fi = new FileInfo(_FileName);
            FileInfo fisource = new FileInfo(_CopySource);
            if (!fi.Exists)
            {
                fisource.CopyTo(_FileName);
            }

            return boolReturn;
        }
        #endregion

        #region 获取Web.Config中日志目录
        /// <summary>
        /// 获取Web.Config中日志目录
        /// </summary>
        /// <returns></returns>
        private static string GetLogPath()
        {
            string strLogPath = ConfigurationManager.AppSettings["LogPath"];
            switch (strLogPath)
            {
                case null:
                case "":
                    strLogPath = @"C:\";
                    break;
            }
            return strLogPath;
        }
        #endregion

        #region 判断文件路径是否存在
        /// <summary>
        /// 判断文件路径是否存在
        /// </summary>
        /// <param name="path">物理路径</param>
        /// <returns></returns>
        public static bool IsExist(string path)
        {
            bool bIsok = false;
            try
            {

                bool bIsExsist = false;
                bIsExsist = System.IO.Directory.Exists(path);
                bIsok = bIsExsist;
                if (!bIsExsist)
                {
                    System.IO.Directory.CreateDirectory(path);
                    bIsok = true;
                }

            }
            catch (Exception)
            {
                throw new Exception("创建目录或文件夹失败！");
            }
            return bIsok;

        }
        #endregion 
    }
}
