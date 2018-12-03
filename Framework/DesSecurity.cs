using  System;  
using  System.Security.Cryptography;  
using  System.IO;  
using  System.Text;
using System.Web.Security;

namespace Framework
{
    /// <summary>
    /// 加密与解密类
    /// </summary>
    public class DesSecurity
    {
       /// <summary>
      /// MD5加密算法
      /// </summary>
      /// <param name="Password">要加密的字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string MD5(string Password)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(Password, "MD5").ToLower();
        }
    }
}