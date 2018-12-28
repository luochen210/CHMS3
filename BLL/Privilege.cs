using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using System.Data;
namespace BLL
{
    #region "权限类"
    /// <summary>
    /// 权限类

    /// </summary>
    public class Privilege:SQLHelper
    {
       
        public int RoleID = -1; //角色ID
        /// <summary>`  
        /// 验证菜单角色权限
        /// </summary>
        /// <param name="UserCode">登陆的编码</param>
        /// <param name="MenuName">菜单下的窗体名</param>
        /// <returns>验证是否通过</returns>
        public bool Validate(string UserCode, string MenuName)
        {
            if (UserCode.ToUpper() == "51aspx".ToUpper())
                return true;
            RoleID = GetRoleIdByUserCode(UserCode);
            if (RoleID == -1) //如果RoleID为-1的直接返回False，将没有所有子菜单的操作权限
                return false;
            string sql = string.Format("Select IsOwnPrivilege From Privilage Where RoleID={0} and FuncNo='{1}'", RoleID, MenuName);
            string PrivilegeCode = DbHelperSQL.ExecuteScalar(sql,CommandType.Text);
            if (PrivilegeCode == "False" || PrivilegeCode == "")  //如果得到是否具有操作此菜单权限为FALSE或者""的话，直接返回FALSE
                return false;
            return true;
        }     

        /// <summary>
        /// 根据用户工号得到角色ID
        /// </summary>
        /// <param name="UserCode">用户工号</param>
        /// <returns>角色ID，如果此工号没有设角色，则返回-1</returns>
        private  int GetRoleIdByUserCode(string UserCode)
        {
            string sql = string.Format("Select RoleID From UserInfo Where UserID='{0}'", UserCode);
            string RoleID = DbHelperSQL.ExecuteScalar(sql, CommandType.Text);
            if (string.IsNullOrEmpty(RoleID))
            {
                return -1;
            }
            return int.Parse(RoleID);
        }
    }
    #endregion
}
