using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using BLL;
namespace CHMS
{
    public class Parameter
    {
        /// <summary>
        /// 登陆系统的当前管理员
        /// </summary>
        public static User CurrentUser { get; set; }
        public static Company CurrentCompany 
        {
            get
            {
               return new BLLCompany().GetModel();
            }
        }
    }
}
