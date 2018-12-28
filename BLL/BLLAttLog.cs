using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class BLLAttLog
    {
        public static ReturnValue AddAttLog(int idwEnrollNumber, int iMachineNumber, int idwVerifyMode, int idwInOutMode, string sTime)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            SqlCommand cmd = new SqlCommand();
            try
            {
                string cmdText = "AddAttLog";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@ClockId", idwEnrollNumber));
                cmd.Parameters.Add(new SqlParameter("@MachineId", iMachineNumber));
                cmd.Parameters.Add(new SqlParameter("@VerifyMode", idwVerifyMode));
                cmd.Parameters.Add(new SqlParameter("@InOutMode", idwInOutMode));
                cmd.Parameters.Add(new SqlParameter("@ClockRecord", sTime));
                cmd.Parameters.Add(new SqlParameter("@strErrInfo", SqlDbType.NVarChar, 512));
                cmd.Parameters["@strErrInfo"].Direction = ParameterDirection.Output;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                iReturnValue = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                strErrInfo = cmd.Parameters["@strErrInfo"].Value.ToString();
            }
            catch (Exception ex)
            {
                iReturnValue = -11;
                strErrInfo = "未知";
                LogManager.WriteTextLog("SQLServerDAL", "", "AddAttLog", ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }

            return new ReturnValue(iReturnValue, strErrInfo);
        }

        public static ReturnValue AddDownUserInfo(string UserID, string Name, string AttNumber, string Privilege, string MverifyPass, string Enabled)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            SqlCommand cmd = new SqlCommand();
            try
            {
                if (Name.Contains("\0"))
                {
                    Name = Name.Substring(0, Name.IndexOf("\0"));
                }
                string cmdText = "AddDownUserInfo";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@AttNumber", AttNumber));
                cmd.Parameters.Add(new SqlParameter("@Privilege", Privilege));
                cmd.Parameters.Add(new SqlParameter("@MverifyPass", MverifyPass));
                cmd.Parameters.Add(new SqlParameter("@Enabled", Enabled));
                cmd.Parameters.Add(new SqlParameter("@strErrInfo", SqlDbType.NVarChar, 512));
                cmd.Parameters["@strErrInfo"].Direction = ParameterDirection.Output;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                iReturnValue = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                strErrInfo = (string)cmd.Parameters["@strErrInfo"].Value;
            }
            catch (Exception ex)
            {
                iReturnValue = -11;
                strErrInfo = "系统出现异常,请查看系统日志!";
                LogManager.WriteTextLog("SQLServerDAL", "", "AddDownUserInfo", ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
            return new ReturnValue(iReturnValue, strErrInfo);
        }

        public static ReturnValue AddDownUserTemplate(string UserID, int Fingerid, string Template)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            SqlCommand cmd = new SqlCommand();
            try
            {
                string cmdText = "AddDownUserTemplate";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
                cmd.Parameters.Add(new SqlParameter("@Fingerid", Fingerid));
                cmd.Parameters.Add(new SqlParameter("@Template", Template));
                cmd.Parameters.Add(new SqlParameter("@strErrInfo", SqlDbType.NVarChar, 512));
                cmd.Parameters["@strErrInfo"].Direction = ParameterDirection.Output;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                iReturnValue = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                strErrInfo = (string)cmd.Parameters["@strErrInfo"].Value;
            }
            catch (Exception ex)
            {
                iReturnValue = -11;
                strErrInfo = "系统出现异常,请查看系统日志!";
                LogManager.WriteTextLog("SQLServerDAL", "", "AddDownUserTemplate", ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }

            return new ReturnValue(iReturnValue, strErrInfo);
        }
        public static ReturnValue QueryUploadByUserID(string UserID, out DataSet ds)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter ad = new SqlDataAdapter();
            try
            {
                string cmdText = "QueryUploadByUserID";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
                cmd.Parameters.Add(new SqlParameter("@strErrInfo", SqlDbType.NVarChar, 512));
                cmd.Parameters["@strErrInfo"].Direction = ParameterDirection.Output;
                ad.SelectCommand = cmd;
                ad.Fill(ds);
                iReturnValue = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                strErrInfo = (string)cmd.Parameters["@strErrInfo"].Value;
            }
            catch (Exception ex)
            {
                iReturnValue = -11;
                strErrInfo = "系统出现异常,请查看系统日志!";
                LogManager.WriteTextLog("SQLServerDAL", "", "QueryUploadByUserID", ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
                ad.Dispose();
            }

            return new ReturnValue(iReturnValue, strErrInfo);
        }

        public ReturnValue QueryAttRecordLog(string UserID, string Name, string AttNumber, string StartDate, string EndDate, string Deptid, out DataSet ds)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter ad = new SqlDataAdapter();
            try
            {
                string cmdText = "QueryAttRecordLog";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@AttNumber", AttNumber));
                cmd.Parameters.Add(new SqlParameter("@StartDate", StartDate));
                cmd.Parameters.Add(new SqlParameter("@EndDate", EndDate));
                cmd.Parameters.Add(new SqlParameter("@Deptid", Deptid));
                cmd.Parameters.Add(new SqlParameter("@strErrInfo", SqlDbType.NVarChar, 512));
                cmd.Parameters["@strErrInfo"].Direction = ParameterDirection.Output;
                ad.SelectCommand = cmd;
                ad.Fill(ds);
                iReturnValue = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                strErrInfo = (string)cmd.Parameters["@strErrInfo"].Value;
            }
            catch (Exception ex)
            {
                iReturnValue = -11;
                strErrInfo = "系统出现异常,请查看系统日志!";
                LogManager.WriteTextLog("SQLServerDAL", "", "QueryAttRecordLog", ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
                ad.Dispose();
            }

            return new ReturnValue(iReturnValue, strErrInfo);
        }
        public ReturnValue CreateUserAttLog(string StartDateTime, string EndDateTime, string UserInfo, int Range)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            SqlCommand cmd = new SqlCommand();
            try
            {
                string cmdText = "CreateUserAttLog";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@StartDateTime", StartDateTime));
                cmd.Parameters.Add(new SqlParameter("@EndDateTime", EndDateTime));
                cmd.Parameters.Add(new SqlParameter("@UserInfo", UserInfo));
                cmd.Parameters.Add(new SqlParameter("@Range", Range));
                cmd.Parameters.Add(new SqlParameter("@strErrInfo", SqlDbType.NVarChar, 512));
                cmd.Parameters["@strErrInfo"].Direction = ParameterDirection.Output;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                iReturnValue = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                strErrInfo = (string)cmd.Parameters["@strErrInfo"].Value;
            }
            catch (Exception ex)
            {
                iReturnValue = -11;
                strErrInfo = "系统出现异常,请查看系统日志!";
                LogManager.WriteTextLog("SQLServerDAL", "", "CreateUserAttLog", ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }

            return new ReturnValue(iReturnValue, strErrInfo);
        }

        public ReturnValue CreateUserInfoTree(out DataSet ds)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter ad = new SqlDataAdapter();
            try
            {
                string cmdText = "CreateUserInfoTree";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@strErrInfo", SqlDbType.NVarChar, 512));
                cmd.Parameters["@strErrInfo"].Direction = ParameterDirection.Output;
                ad.SelectCommand = cmd;
                ad.Fill(ds);
                iReturnValue = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                strErrInfo = (string)cmd.Parameters["@strErrInfo"].Value;
            }
            catch (Exception ex)
            {
                iReturnValue = -11;
                strErrInfo = "系统出现异常,请查看系统日志!";
                LogManager.WriteTextLog("SQLServerDAL", "", "CreateUserInfoTree", ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
                ad.Dispose();
            }

            return new ReturnValue(iReturnValue, strErrInfo);
        }

        public ReturnValue AddUserSpeday(string UserID, string LeaveId, DateTime StartDate, DateTime EndDate, DateTime ApproveDate, string Approver, string Remark)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            SqlCommand cmd = new SqlCommand();
            try
            {
                string cmdText = "AddUserSpeday";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
                cmd.Parameters.Add(new SqlParameter("@LeaveId", LeaveId));
                cmd.Parameters.Add(new SqlParameter("@StartDate", StartDate));
                cmd.Parameters.Add(new SqlParameter("@EndDate", EndDate));
                cmd.Parameters.Add(new SqlParameter("@ApproveDate", ApproveDate));
                cmd.Parameters.Add(new SqlParameter("@Approver", Approver));
                cmd.Parameters.Add(new SqlParameter("@Remark", Remark));
                cmd.Parameters.Add(new SqlParameter("@strErrInfo", SqlDbType.NVarChar, 512));
                cmd.Parameters["@strErrInfo"].Direction = ParameterDirection.Output;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                iReturnValue = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                strErrInfo = (string)cmd.Parameters["@strErrInfo"].Value;
            }
            catch (Exception ex)
            {
                iReturnValue = -11;
                strErrInfo = "系统出现异常,请查看系统日志!";
                LogManager.WriteTextLog("SQLServerDAL", "", "AddUserSpeday", ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }

            return new ReturnValue(iReturnValue, strErrInfo);
        }

        public ReturnValue QueryUserSpeday(string UserInfo, string StartDate, string EndDate, out DataSet ds)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter ad = new SqlDataAdapter();
            try
            {
                string cmdText = "QueryUserSpeday";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@UserInfo", UserInfo));
                cmd.Parameters.Add(new SqlParameter("@StartDate", StartDate));
                cmd.Parameters.Add(new SqlParameter("@EndDate", EndDate));
                cmd.Parameters.Add(new SqlParameter("@strErrInfo", SqlDbType.NVarChar, 512));
                cmd.Parameters["@strErrInfo"].Direction = ParameterDirection.Output;
                ad.SelectCommand = cmd;
                ad.Fill(ds);
                iReturnValue = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                strErrInfo = (string)cmd.Parameters["@strErrInfo"].Value;
            }
            catch (Exception ex)
            {
                iReturnValue = -11;
                strErrInfo = "系统出现异常,请查看系统日志!";
                LogManager.WriteTextLog("SQLServerDAL", "", "QueryUserSpeday", ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
                ad.Dispose();
            }

            return new ReturnValue(iReturnValue, strErrInfo);
        }

        public ReturnValue QueryUserMonthLog(string UserInfo, DateTime StartDateTime, DateTime EndDateTime, out DataSet ds)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter ad = new SqlDataAdapter();
            try
            {
                string cmdText = "QueryUserMonthLog";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@UserInfo", UserInfo));
                cmd.Parameters.Add(new SqlParameter("@StartDateTime", StartDateTime));
                cmd.Parameters.Add(new SqlParameter("@EndDateTime", EndDateTime));
                cmd.Parameters.Add(new SqlParameter("@strErrInfo", SqlDbType.NVarChar, 512));
                cmd.Parameters["@strErrInfo"].Direction = ParameterDirection.Output;
                ad.SelectCommand = cmd;
                ad.Fill(ds);
                iReturnValue = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                strErrInfo = (string)cmd.Parameters["@strErrInfo"].Value;
            }
            catch (Exception ex)
            {
                iReturnValue = -11;
                strErrInfo = "系统出现异常,请查看系统日志!";
                LogManager.WriteTextLog("SQLServerDAL", "", "QueryUserMonthLog", ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
                ad.Dispose();
            }

            return new ReturnValue(iReturnValue, strErrInfo);
        }

        public ReturnValue QueryUserDayLog(string UserInfo, DateTime StartDateTime, DateTime EndDateTime, out DataSet ds)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter ad = new SqlDataAdapter();
            try
            {
                string cmdText = "QueryUserDayLog";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@UserInfo", UserInfo));
                cmd.Parameters.Add(new SqlParameter("@StartDateTime", StartDateTime));
                cmd.Parameters.Add(new SqlParameter("@EndDateTime", EndDateTime));
                cmd.Parameters.Add(new SqlParameter("@strErrInfo", SqlDbType.NVarChar, 512));
                cmd.Parameters["@strErrInfo"].Direction = ParameterDirection.Output;
                ad.SelectCommand = cmd;
                ad.Fill(ds);
                iReturnValue = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                strErrInfo = (string)cmd.Parameters["@strErrInfo"].Value;
            }
            catch (Exception ex)
            {
                iReturnValue = -11;
                strErrInfo = "系统出现异常,请查看系统日志!";
                LogManager.WriteTextLog("SQLServerDAL", "", "QueryUserDayLog", ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
                ad.Dispose();
            }

            return new ReturnValue(iReturnValue, strErrInfo);
        }
        public ReturnValue AddAttExceptionLog(string UserInfo, DateTime StartDate, DateTime EndDate, string StartTime, string EndTime, int Range, string Reserved)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            SqlCommand cmd = new SqlCommand();
            try
            {
                string cmdText = "AddAttExceptionLog";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@UserInfo", UserInfo));
                cmd.Parameters.Add(new SqlParameter("@StartDate", StartDate));
                cmd.Parameters.Add(new SqlParameter("@EndDate", EndDate));
                cmd.Parameters.Add(new SqlParameter("@StartTime", StartTime));
                cmd.Parameters.Add(new SqlParameter("@EndTime", EndTime));
                cmd.Parameters.Add(new SqlParameter("@Range", Range));
                cmd.Parameters.Add(new SqlParameter("@Reserved", Reserved));
                cmd.Parameters.Add(new SqlParameter("@strErrInfo", SqlDbType.NVarChar, 512));
                cmd.Parameters["@strErrInfo"].Direction = ParameterDirection.Output;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                iReturnValue = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                strErrInfo = (string)cmd.Parameters["@strErrInfo"].Value;
            }
            catch (Exception ex)
            {
                iReturnValue = -11;
                strErrInfo = "系统出现异常,请查看系统日志!";
                LogManager.WriteTextLog("SQLServerDAL", "", "AddAttExceptionLog", ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }

            return new ReturnValue(iReturnValue, strErrInfo);
        }
        public ReturnValue CheckUserAttLog(DateTime StartDateTime, DateTime EndDateTime, string UserInfo)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            SqlCommand cmd = new SqlCommand();
            try
            {
                string cmdText = "CheckUserAttLog";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@StartDateTime", StartDateTime));
                cmd.Parameters.Add(new SqlParameter("@EndDateTime", EndDateTime));
                cmd.Parameters.Add(new SqlParameter("@UserInfo", UserInfo));
                cmd.Parameters.Add(new SqlParameter("@strErrInfo", SqlDbType.NVarChar, 512));
                cmd.Parameters["@strErrInfo"].Direction = ParameterDirection.Output;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                iReturnValue = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                strErrInfo = (string)cmd.Parameters["@strErrInfo"].Value;
            }
            catch (Exception ex)
            {
                iReturnValue = -11;
                strErrInfo = "系统出现异常,请查看系统日志!";
                LogManager.WriteTextLog("SQLServerDAL", "", "CheckUserAttLog", ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }

            return new ReturnValue(iReturnValue, strErrInfo);
        }


    }
}
