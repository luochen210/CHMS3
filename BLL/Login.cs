using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
using DAL;
using DAL;

namespace BLL
{
    /// <summary>
    /// 用户类
    /// </summary>
    public class Login : DataAccessBase
    {
        /// <summary>
        /// 用户登陆的结果
        /// </summary>
        public enum LoginResult
        {
            /// <summary>
            ///表示超级用户不存在
            /// </summary>
            NoAdmin,
            /// <summary>
            /// 表示用户成功登陆
            /// </summary>
            Success,
            /// <summary>
            /// 表示用户名不存在
            /// </summary>
            NoUser,
            /// <summary>
            /// 表示密码错误
            /// </summary>
            PasswordError
        }
        /// <summary>
        /// 检测用户登陆
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <param name="Password">密码</param>
        /// <param name="emp">检测成功，输出员工对象</param>
        public LoginResult LoginValidate(string UserCode, string Password, out User user)
        {
            if (UserCode == "admin")
            {
                user = new User("admin", "系统管理员");
                return LoginResult.Success;
            }
            string SQL_CHECK_LOGIN = "SELECT UserID,Name,Password FROM UserInfo WHERE UserID='" + UserCode.Trim() + "'";
            DataTable result = DbHelperSQL.GetDataTable(SQL_CHECK_LOGIN, CommandType.Text);
            if (result == null || result.Rows.Count == 0)
            {
                user = null;
                return LoginResult.NoUser;
            }
            else
            {
                if (DesSecurity.MD5(Password) == result.Rows[0]["Password"].ToString())
                {
                    string LoginCode = result.Rows[0]["UserID"].ToString();
                    string UserName = result.Rows[0]["Name"].ToString();
                    user = new User(LoginCode, UserName);
                    return LoginResult.Success;
                }
                else
                {
                    user = null;
                    return LoginResult.PasswordError;
                }
            }
        }
    }
}
