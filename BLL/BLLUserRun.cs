using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLUserRun : SQLHelper
    {

        public ReturnValue AddRunUser(string UserID, string RunID, DateTime StartDate, DateTime EndDate, int Sunday, int Saturday, string SchclassInfo)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            SqlCommand cmd = new SqlCommand();
            try
            {
                string cmdText = "AddRunUser";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@UserInfo", UserID));
                cmd.Parameters.Add(new SqlParameter("@RunID", RunID));
                cmd.Parameters.Add(new SqlParameter("@SchclassInfo", SchclassInfo));
                cmd.Parameters.Add(new SqlParameter("@StartDate", StartDate));
                cmd.Parameters.Add(new SqlParameter("@EndDate", EndDate));
                cmd.Parameters.Add(new SqlParameter("@Sunday", Sunday));
                cmd.Parameters.Add(new SqlParameter("@Saturday", Saturday));
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
                strErrInfo = "Execute Proc Error!";
                LogManager.WriteTextLog("BLLUserRun", "AddRunUser", "AddRunUser", ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
            return new ReturnValue(iReturnValue, strErrInfo);
        }
        public ReturnValue QueryRunUser(string UserID, DateTime StartDate, DateTime EndDate, out DataSet ds)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter ad = new SqlDataAdapter();
            try
            {
                string cmdText = "QueryRunUser";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@UserInfo", UserID));
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
                strErrInfo = "Execute Proc Error!";
                LogManager.WriteTextLog("SQLServerDAL", "", "QueryRunUser", ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
                ad.Dispose();
            }

            return new ReturnValue(iReturnValue, strErrInfo);
        }

        public ReturnValue QueryRunUserLog(string UserInfo, DateTime StartDate, DateTime EndDate, out DataSet ds)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter ad = new SqlDataAdapter();
            try
            {
                string cmdText = "QueryRunUserLog";
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
                LogManager.WriteTextLog("SQLServerDAL", "", "QueryRunUserLog", ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
                ad.Dispose();
            }

            return new ReturnValue(iReturnValue, strErrInfo);
        }

        public ReturnValue AddRunUserDaily(string UserID, string RunID, string RunDate, string SchclassInfo)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            SqlCommand cmd = new SqlCommand();
            try
            {
                string cmdText = "AddRunUserDaily";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
                cmd.Parameters.Add(new SqlParameter("@RunID", RunID));
                cmd.Parameters.Add(new SqlParameter("@RunDate", RunDate));
                cmd.Parameters.Add(new SqlParameter("@SchclassInfo", SchclassInfo));
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
                LogManager.WriteTextLog("SQLServerDAL", "", "AddRunUserDaily", ex.Message + ex.StackTrace);
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
