using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace Framework
{
   /// <summary>
    /// 配置文件类
   /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// 配置文件类
        /// </summary>
        /// <returns>配置文件的路径</returns>
        public static string AppConfig()
        {
            //此处配置文件在程序目录下
            return System.IO.Path.Combine(Application.StartupPath, "App.config");
        }
        /// <summary>
        /// 获取数据库连接字符串
        /// </summary>
        /// <returns></returns>
        public static string GetConString()
        {
            return String.Format(@"SERVER={0};UID={1};PWD={2};DATABASE={3};", AppSettings.GetValue("SERVER"), AppSettings.GetValue("UID"), AppSettings.GetValue("PWD"), AppSettings.GetValue("DATABASE"));
        }
        /// <summary>
        /// 读取APP.Congig文件的值
        /// </summary>
        /// <param name="appKey">关键字及KEY</param>
        /// <returns>根据关键字及KEY得到对应的VALUE值</returns>
        public static string GetValue(string appKey)
        {
            XmlDocument xDoc = new XmlDocument();
            try
            {
                xDoc.Load(AppSettings.AppConfig());
                XmlNode xNode;
                XmlElement xElem;
                xNode = xDoc.SelectSingleNode("//appSettings");
                xElem = (XmlElement)xNode.SelectSingleNode("//add[@key='" + appKey + "']");
                if (xElem != null)
                    return xElem.GetAttribute("value");
                else
                    return "";
            }
            catch (Exception)
            {
                return "";
            }
        }

        /// <summary>
        /// 写入关键字及KEY的值
        /// </summary>
        /// <param name="AppKey">关键字及KEY</param>
        /// <param name="AppValue">要写入KEY对应的值</param>
        public static void SetValue(string AppKey, string AppValue)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(AppSettings.AppConfig());
            XmlNode xNode;
            XmlElement xElem1;
            XmlElement xElem2;
            xNode = xDoc.SelectSingleNode("//appSettings");
            xElem1 = (XmlElement)xNode.SelectSingleNode("//add[@key='" + AppKey + "']");
            if (xElem1 != null)
            {
                xElem1.SetAttribute("value", AppValue);
            }
            else
            {
                xElem2 = xDoc.CreateElement("add");
                xElem2.SetAttribute("key", AppKey);
                xElem2.SetAttribute("value", AppValue);
                xNode.AppendChild(xElem2);
            }
            xDoc.Save(AppSettings.AppConfig());
        }
    }
}
