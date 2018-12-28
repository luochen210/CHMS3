using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class UserInfoDepartments : SQLHelper
    {

        public DataTable GetUserInfoDepartments(string DefaultDeptid, string strName)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT T1.[UserID],T1.[Name],T2.Deptname,T1.IsEnabled");
            sb.Append(" FROM [Userinfo] AS T1 ");
            sb.Append(" LEFT JOIN Departments AS T2 ON T1.DefaultDeptid=T2.Deptid WHERE 1=1");
            if (DefaultDeptid != "")
            {
                sb.Append(" AND T1.DefaultDeptid='" + DefaultDeptid + "'");
            }
            if (strName != "")
            {
                sb.Append(" AND T1.[Name] LIKE'%" + strName + "%'");
            }
            return DbHelperSQL.GetDataTable(sb.ToString(), CommandType.Text);
        }

        public DataTable QueryUserInfo(string DefaultDeptid, string strName, string UserID, string AttNumber)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ui.UserID,ui.AttNumber,ui.Ssn,ui.[Name], ui.Gender,");
	        sb.Append("ui.Title,ui.Mobile,ui.Birthday,ui.Hiredday,ui.[Address],");
            sb.Append(" ui.Province,ui.City,ui.Zip,ui.OfficePhone,ui.VerificationMethod,");
            sb.Append("	ui.DefaultDeptid,ui.RoleID,ui.Att,ui.Inlate,ui.Outearly,");
	        sb.Append(" ui.Overtime,ui.Holiday,ui.Nationality,ui.[Password],ui.Lunchduration,");
            sb.Append("	ui.MverifyPass,ui.Photo,ui.Privilege,ui.[Enabled],ui.IsEnabled,");
            sb.Append("	d.Deptname,ui.Remark");
            sb.Append(" FROM UserInfo ui ");
            sb.Append(" LEFT JOIN Departments d ON ui.DefaultDeptid=d.Deptid ");
            sb.Append(" WHERE 1=1");
            if (DefaultDeptid != "")
            {
                sb.Append(" AND d.Deptid='" + DefaultDeptid + "'");
            }
            if (strName != "")
            {
                sb.Append(" AND ui.[Name] LIKE'%" + strName + "%'");
            }
            if (UserID != "")
            {
                sb.Append(" AND ui.UserID='" + UserID + "'");
            }
            if (AttNumber != "")
            {
                sb.Append(" AND ui.AttNumber='" + AttNumber + "'");
            }
            return DbHelperSQL.GetDataTable(sb.ToString(), CommandType.Text);
        }
    }
}
