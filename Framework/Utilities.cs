using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace Framework
{
    /// <summary>
    /// 常用是转换函数
    /// </summary>
    public class Utilities
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public Utilities() { }

        /// <summary>
        /// 把NULL转换成""
        /// </summary>
        /// <param name="objIn"></param>
        /// <returns></returns>
        public static string ConvertToString(object curobject)
        {
            if (curobject == null)
            {
                return "";
            }
            else
            {
                return curobject.ToString();
            }
        }
        /// <summary>
        /// 把NULL转换成"0"
        /// </summary>
        /// <param name="objIn"></param>
        /// <returns></returns>
        public static string ConvertToZero(object curobject)
        {
            if (curobject == null)
            {
                return "0";
            }
            else
            {
                return curobject.ToString();
            }
        }

        /// <summary>
        /// 把给定字符串转换成大写
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public static string ConvertToUpper(string strChar)
        {

            return strChar.ToUpper();
        }
        /// <summary>
        /// 把给的字符串转化成decimal类型的数据
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>转化成decimal类型的数据</returns>
        public static decimal ConvertToDeciamal(string curstring)
        {
            if (curstring == "")
            {
                return 0;
            }
            else
            {
                return decimal.Parse(curstring);
            }
        }

        /// <summary>
        /// 时间转化函数
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>转化成时间值</returns>
        public static DateTime ConvertDateTime(string curstring)
        {
            if (curstring == "")
            {
                return DateTime.MinValue;
            }
            else
            {
                return DateTime.Parse(curstring);
            }
        }

        /// <summary>
        /// 数字化函数
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>数字化函数</returns>
        public static int ConvertToInt(string curstring)
        {
            if (curstring == "")
            {
                return 0;
            }
            else
            {
                return int.Parse(curstring);
            }
        }
        /// <summary>
        /// 数字化函数
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>数字化函数</returns>
        public static int ConverToInt(object curobject)
        {
            if (curobject == null)
            {
                return 0;
            }
            else
            {
                return int.Parse(curobject.ToString());
            }
        }
    }
}
