using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using System.Data.SqlClient;
namespace BLL
{
   
   /// <summary>
   /// 角色组操作对象
   /// </summary>
   public class BLLRole:SQLHelper
   {
       /// <summary>
       /// 添加角色组
       /// </summary>
       /// <param name="model">实体对象</param>
       /// <returns>0或1</returns>
       public int Add(Models.Role model)
       {
           StringBuilder sb = new StringBuilder();
           sb.Append("INSERT INTO Role ([Idx], CName, DoUserCode, DoDateTime, Notes, RptCount,State)");
           sb.Append(" VALUES (@Idx, @CName, @DoUserCode, @DoDateTime, @Notes, @RptCount,@State)");
           return DbHelperSQL.ExcuteNonQuery(sb.ToString(),CommandType.Text,DbHelperSQL.CreateParamters(sb.ToString(), model));

       }
       /// <summary>
       /// 修改角色组
       /// </summary>
       /// <param name="model">实体对象</param>
       /// <returns>0或1</returns>
       public int Update(Models.Role model)
       {
           StringBuilder sb = new StringBuilder();
           sb.Append("UPDATE Role SET CName =@CName, DoUserCode=@DoUserCode, DoDateTime=@DoDateTime, ");
           sb.Append(" Notes =@Notes, RptCount =@RptCount, State =@State WHERE Idx=@Idx");
           return DbHelperSQL.ExcuteNonQuery(sb.ToString(),CommandType.Text,DbHelperSQL.CreateParamters(sb.ToString(), model));
       }

       /// <summary>
       /// 删除角色组
       /// </summary>
       /// <param name="ID">角色组编号</param>
       /// <returns>0或1</returns>
       public int Delete(string ID)
       {
           return DbHelperSQL.ExcuteNonQuery("DELETE FROM Role WHERE [Idx]=" + int.Parse(ID) + "", CommandType.Text);
       }
       /// <summary>
       /// 角色组ILIST对象
       /// </summary>
       /// <returns>角色组ILIST对象</returns>
       public IList<Models.Role> GetRoleIlist()
       {
           return DbHelperSQL.GetIList<Models.Role>("SELECT Idx, CName, DoUserCode, DoDateTime, Notes,RptCount, State FROM Role", CommandType.Text);
       }
       /// <summary>
       /// 获得角色组的最大编号
       /// </summary>
       /// <returns>获得角色组的最大编号</returns>
       public string GetMaxRoleID()
       {
           return DbHelperSQL.GetMaxID("Role", "Idx");
       }

       public IList<Models.Module> GetModuleList(string strWhere)
       {
           StringBuilder strSql = new StringBuilder();
           strSql.Append("select Id,Name,Signcode,Syscode ");
           strSql.Append(" FROM Module ");
           if (strWhere.Trim() != "")
           {
               strSql.Append(" where " + strWhere);
           }
           return DbHelperSQL.GetIList<Models.Module>(strSql.ToString(),CommandType.Text);
       }

       public DataTable GetFuncnoDataTable(int ModuleID)
       {
           StringBuilder sb = new StringBuilder();
           sb.Append("SELECT f.[No] ,f.[Name] ,ISNULL(p.Isownprivilege, f.[State]) Isownprivilege ");
           sb.Append(" FROM Func f LEFT JOIN Privilage  p ON f.[No]=p.Funcno WHERE F.Moduleid=" + ModuleID + "");
           return DbHelperSQL.GetDataTable(sb.ToString(), CommandType.Text);
       }
       public ReturnValue AddPrivilage(int Roleid, string Funcno, bool Isownprivilege)
       {
           int iReturnValue = -10;
           string strErrInfo = "No Return Info!";
           SqlCommand cmd = new SqlCommand();
           try
           {
               string cmdText = "AddPrivilage";
               cmd.Connection = new SqlConnection(AppSettings.GetConString());
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = cmdText;
               cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
               cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
               cmd.Parameters.Add(new SqlParameter("@Roleid", Roleid));
               cmd.Parameters.Add(new SqlParameter("@Funcno", Funcno));
               cmd.Parameters.Add(new SqlParameter("@Isownprivilege", Isownprivilege));
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
               LogManager.WriteTextLog("SQLServerDAL", "", "AddPrivilage", ex.Message + ex.StackTrace);
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
