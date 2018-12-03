using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace Framework
{
    /// <summary>
    /// ������ת������
    /// </summary>
    public class Utilities
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        public Utilities() { }

        /// <summary>
        /// ��NULLת����""
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
        /// ��NULLת����"0"
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
        /// �Ѹ����ַ���ת���ɴ�д
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public static string ConvertToUpper(string strChar)
        {

            return strChar.ToUpper();
        }
        /// <summary>
        /// �Ѹ����ַ���ת����decimal���͵�����
        /// </summary>
        /// <param name="str">�ַ���</param>
        /// <returns>ת����decimal���͵�����</returns>
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
        /// ʱ��ת������
        /// </summary>
        /// <param name="str">�ַ���</param>
        /// <returns>ת����ʱ��ֵ</returns>
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
        /// ���ֻ�����
        /// </summary>
        /// <param name="str">�ַ���</param>
        /// <returns>���ֻ�����</returns>
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
        /// ���ֻ�����
        /// </summary>
        /// <param name="str">�ַ���</param>
        /// <returns>���ֻ�����</returns>
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
