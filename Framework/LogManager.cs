using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;

namespace Framework
{
    public class LogManager
    {
        #region д��ģ��������־
        /// <summary>
        /// д��ģ��������־
        /// </summary>
        /// <param name="strSubject">����</param>
        /// <param name="strModule">ģ��</param>
        /// <param name="strMethod">����</param>
        /// <param name="strContent">����</param>
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
                throw new Exception("д����־ʧ�ܣ�����·�����ļ�ϵͳ����Ȩ�ޣ�");
            }
        }

        #endregion

        #region д��ģ������־
        /// <summary>
        /// д��ģ������־
        /// </summary>
        /// <param name="strSubject">����</param>
        /// <param name="strModule">ģ��</param>
        /// <param name="strMethod">����</param>
        /// <param name="strContent">����</param>
        /// <param name="strPath">����Ŀ¼</param>
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
                    throw new Exception("û�д���LogĿ¼��Ȩ��!"+ex.Message);
                }
            }
            string strFName = LogPath + "\\" + strSubject + "_" + DateTime.Now.ToString("yyyy_MM_dd") + ".log";
            System.IO.FileInfo fInfo = new FileInfo(strFName);
            using (FileStream fs = fInfo.OpenWrite())
            {
                StreamWriter sw = new StreamWriter(fs);    //�������洴�����ļ�������д������
                sw.BaseStream.Seek(0, SeekOrigin.End);     //����д����������ʼλ��Ϊ�ļ�����ĩβ
                string strLog = ((("Date:" + DateTime.Now.ToString() + "\r\n") + "Module:" + strModule + "\r\n") + "Method:" + strMethod + "\r\n");
                sw.Write(strLog);
                for (int i = 0; i < strCon.Length; i++)//д����־���ݲ�����
                {
                    sw.Write(strCon[i].ToString() + "\n\r");
                    sw.Write("\n");
                }
                sw.Flush();//��ջ��������ݣ����ѻ���������д�������
                sw.Close();//�ر�д������
            }
        }
        #endregion

        #region ��ȡ�ļ���¼
        /// <summary>
        /// ��ȡ�ļ���¼
        /// </summary>
        /// <param name="path">�ļ�����·��</param>
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
                throw new Exception("��ȡ��־ʧ�ܣ�");
            }
        }

        #endregion

        #region ɾ�������ļ�
        /// <summary>
        ///  ɾ�������ļ�
        /// </summary>
        /// <param name="path">�ļ�����·��</param>
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
                throw new Exception("ɾ�������ļ�ʧ�ܣ�");
            }
        }

        #endregion

        #region �����ļ�
        /// <summary>
        ///�����ļ�
        /// </summary>
        /// <param name="_FileName">ԭ�ļ�</param>
        /// <param name="_CopySource">Ŀ���ļ�</param>
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

        #region ��ȡWeb.Config����־Ŀ¼
        /// <summary>
        /// ��ȡWeb.Config����־Ŀ¼
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

        #region �ж��ļ�·���Ƿ����
        /// <summary>
        /// �ж��ļ�·���Ƿ����
        /// </summary>
        /// <param name="path">����·��</param>
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
                throw new Exception("����Ŀ¼���ļ���ʧ�ܣ�");
            }
            return bIsok;

        }
        #endregion 
    }
}
