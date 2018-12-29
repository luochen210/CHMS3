using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class BLLHolidays : SQLHelper
    {
        public ReturnValue AddHolidays(DateTime StartDate, DateTime EndDate, string LeaveId)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            SqlCommand cmd = new SqlCommand();
            try
            {
                string cmdText = "AddHolidays";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@StartDate", StartDate));
                cmd.Parameters.Add(new SqlParameter("@EndDate", EndDate));
                cmd.Parameters.Add(new SqlParameter("@LeaveId", LeaveId));
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
                LogManager.WriteTextLog("SQLServerDAL", "", "AddHolidays", ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }

            return new ReturnValue(iReturnValue, strErrInfo);
        }
        public IList<DAL.Holidays> GetHolidaysIList(string strWhere)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT h.[Holidayid],h.[HolidayDate],h.[LeaveId],lc.[LeaveName]");
            sb.Append("	FROM Holidays h  ");
            sb.Append("	INNER JOIN  LeaveClass lc ON h.LeaveId=lc.LeaveId ");
            return DbHelperSQL.GetIList<DAL.Holidays>(sb.ToString(), CommandType.Text);
        }
        public int Delete(string Holidayid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Holidays ");
            strSql.Append(" where Holidayid=@Holidayid ");
            SqlParameter[] parameters = {
					new SqlParameter("@Holidayid", SqlDbType.Int,4)};
            parameters[0].Value = Holidayid;
            return DbHelperSQL.ExcuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
        }
    }
}
