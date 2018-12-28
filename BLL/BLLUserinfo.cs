using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DAL;
namespace BLL
{
    public class BLLUserinfo : DataAccessBase
    {

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Userinfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Userinfo(");
            strSql.Append("UserID,AttNumber,Ssn,Name,Gender,Title,Mobile,Birthday,Hiredday,Address,Province,City,Zip,OfficePhone,VerificationMethod,DefaultDeptid,RoleID,Att,Inlate,Outearly,Overtime,Holiday,Nationality,Password,Lunchduration,MverifyPass)");
            strSql.Append(" values (");
            strSql.Append("@UserID,@AttNumber,@Ssn,@Name,@Gender,@Title,@Mobile,@Birthday,@Hiredday,@Address,@Province,@City,@Zip,@OfficePhone,@VerificationMethod,@DefaultDeptid,@RoleID,@Att,@Inlate,@Outearly,@Overtime,@Holiday,@Nationality,@Password,@Lunchduration,@MverifyPass)");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.VarChar,10),
					new SqlParameter("@AttNumber", SqlDbType.VarChar,12),
					new SqlParameter("@Ssn", SqlDbType.VarChar,20),
					new SqlParameter("@Name", SqlDbType.VarChar,20),
					new SqlParameter("@Gender", SqlDbType.VarChar,2),
					new SqlParameter("@Title", SqlDbType.VarChar,20),
					new SqlParameter("@Mobile", SqlDbType.VarChar,20),
					new SqlParameter("@Birthday", SqlDbType.DateTime),
					new SqlParameter("@Hiredday", SqlDbType.DateTime),
					new SqlParameter("@Address", SqlDbType.VarChar,40),
					new SqlParameter("@Province", SqlDbType.VarChar,2),
					new SqlParameter("@City", SqlDbType.VarChar,2),
					new SqlParameter("@Zip", SqlDbType.VarChar,12),
					new SqlParameter("@OfficePhone", SqlDbType.VarChar,20),
					new SqlParameter("@VerificationMethod", SqlDbType.SmallInt,2),
					new SqlParameter("@DefaultDeptid", SqlDbType.VarChar,30),
					new SqlParameter("@RoleID", SqlDbType.SmallInt,2),
					new SqlParameter("@Att", SqlDbType.VarChar,20),
					new SqlParameter("@Inlate", SqlDbType.SmallInt,2),
					new SqlParameter("@Outearly", SqlDbType.SmallInt,2),
					new SqlParameter("@Overtime", SqlDbType.SmallInt,2),
					new SqlParameter("@Holiday", SqlDbType.SmallInt,2),
					new SqlParameter("@Nationality", SqlDbType.VarChar,8),
					new SqlParameter("@Password", SqlDbType.VarChar,50),
					new SqlParameter("@Lunchduration", SqlDbType.SmallInt,2),
					new SqlParameter("@MverifyPass", SqlDbType.VarChar,10)};
            parameters[0].Value = model.UserID;
            parameters[1].Value = model.AttNumber;
            parameters[2].Value = model.Ssn;
            parameters[3].Value = model.Name;
            parameters[4].Value = model.Gender;
            parameters[5].Value = model.Title;
            parameters[6].Value = model.Mobile;
            parameters[7].Value = model.Birthday;
            parameters[8].Value = model.Hiredday;
            parameters[9].Value = model.Address;
            parameters[10].Value = model.Province;
            parameters[11].Value = model.City;
            parameters[12].Value = model.Zip;
            parameters[13].Value = model.OfficePhone;
            parameters[14].Value = model.VerificationMethod;
            parameters[15].Value = model.DefaultDeptid;
            parameters[16].Value = model.RoleID;
            parameters[17].Value = model.Att;
            parameters[18].Value = model.Inlate;
            parameters[19].Value = model.Outearly;
            parameters[20].Value = model.Overtime;
            parameters[21].Value = model.Holiday;
            parameters[22].Value = model.Nationality;
            parameters[23].Value = model.Password;
            parameters[24].Value = model.Lunchduration;
            parameters[25].Value = model.MverifyPass;
            return DbHelperSQL.ExcuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Model.Userinfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Userinfo set ");
            strSql.Append("AttNumber=@AttNumber,");
            strSql.Append("Ssn=@Ssn,");
            strSql.Append("Name=@Name,");
            strSql.Append("Gender=@Gender,");
            strSql.Append("Title=@Title,");
            strSql.Append("Mobile=@Mobile,");
            strSql.Append("Birthday=@Birthday,");
            strSql.Append("Hiredday=@Hiredday,");
            strSql.Append("Address=@Address,");
            strSql.Append("Province=@Province,");
            strSql.Append("City=@City,");
            strSql.Append("Zip=@Zip,");
            strSql.Append("OfficePhone=@OfficePhone,");
            strSql.Append("VerificationMethod=@VerificationMethod,");
            strSql.Append("DefaultDeptid=@DefaultDeptid,");
            strSql.Append("RoleID=@RoleID,");
            strSql.Append("Att=@Att,");
            strSql.Append("Inlate=@Inlate,");
            strSql.Append("Outearly=@Outearly,");
            strSql.Append("Overtime=@Overtime,");
            strSql.Append("Holiday=@Holiday,");
            strSql.Append("Nationality=@Nationality,");
            strSql.Append("Password=@Password,");
            strSql.Append("Lunchduration=@Lunchduration,");
            strSql.Append("MverifyPass=@MverifyPass");
            strSql.Append(" where UserID=@UserID ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.VarChar,10),
					new SqlParameter("@AttNumber", SqlDbType.VarChar,12),
					new SqlParameter("@Ssn", SqlDbType.VarChar,20),
					new SqlParameter("@Name", SqlDbType.VarChar,20),
					new SqlParameter("@Gender", SqlDbType.VarChar,2),
					new SqlParameter("@Title", SqlDbType.VarChar,20),
					new SqlParameter("@Mobile", SqlDbType.VarChar,20),
					new SqlParameter("@Birthday", SqlDbType.DateTime),
					new SqlParameter("@Hiredday", SqlDbType.DateTime),
					new SqlParameter("@Address", SqlDbType.VarChar,40),
					new SqlParameter("@Province", SqlDbType.VarChar,2),
					new SqlParameter("@City", SqlDbType.VarChar,2),
					new SqlParameter("@Zip", SqlDbType.VarChar,12),
					new SqlParameter("@OfficePhone", SqlDbType.VarChar,20),
					new SqlParameter("@VerificationMethod", SqlDbType.SmallInt,2),
					new SqlParameter("@DefaultDeptid", SqlDbType.VarChar,30),
					new SqlParameter("@RoleID", SqlDbType.SmallInt,2),
					new SqlParameter("@Att", SqlDbType.VarChar,20),
					new SqlParameter("@Inlate", SqlDbType.SmallInt,2),
					new SqlParameter("@Outearly", SqlDbType.SmallInt,2),
					new SqlParameter("@Overtime", SqlDbType.SmallInt,2),
					new SqlParameter("@Holiday", SqlDbType.SmallInt,2),
					new SqlParameter("@Nationality", SqlDbType.VarChar,8),
					new SqlParameter("@Password", SqlDbType.VarChar,50),
					new SqlParameter("@Lunchduration", SqlDbType.SmallInt,2),
					new SqlParameter("@MverifyPass", SqlDbType.VarChar,10)};
            parameters[0].Value = model.UserID;
            parameters[1].Value = model.AttNumber;
            parameters[2].Value = model.Ssn;
            parameters[3].Value = model.Name;
            parameters[4].Value = model.Gender;
            parameters[5].Value = model.Title;
            parameters[6].Value = model.Mobile;
            parameters[7].Value = model.Birthday;
            parameters[8].Value = model.Hiredday;
            parameters[9].Value = model.Address;
            parameters[10].Value = model.Province;
            parameters[11].Value = model.City;
            parameters[12].Value = model.Zip;
            parameters[13].Value = model.OfficePhone;
            parameters[14].Value = model.VerificationMethod;
            parameters[15].Value = model.DefaultDeptid;
            parameters[16].Value = model.RoleID;
            parameters[17].Value = model.Att;
            parameters[18].Value = model.Inlate;
            parameters[19].Value = model.Outearly;
            parameters[20].Value = model.Overtime;
            parameters[21].Value = model.Holiday;
            parameters[22].Value = model.Nationality;
            parameters[23].Value = model.Password;
            parameters[24].Value = model.Lunchduration;
            parameters[25].Value = model.MverifyPass;
            return DbHelperSQL.ExcuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(string UserID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Userinfo ");
            strSql.Append(" where UserID=@UserID ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.VarChar,50)};
            parameters[0].Value = UserID;
            return DbHelperSQL.ExcuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Userinfo GetModel(string UserID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UserID,AttNumber,Ssn,Name,Gender,Title,Mobile,Birthday,Hiredday,Address,Province,City,Zip,OfficePhone,VerificationMethod,DefaultDeptid,RoleID,Att,Inlate,Outearly,Overtime,Holiday,Nationality,Password,Lunchduration,MverifyPass from Userinfo ");
            strSql.Append(" where UserID=@UserID ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.VarChar,50)};
            parameters[0].Value = UserID;
            IList<Model.Userinfo> result = DbHelperSQL.GetIList<Model.Userinfo>(strSql.ToString(), CommandType.Text, parameters);
            if (result != null && result.Count > 0)
            {
                return result[0];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public IList<Model.Userinfo> GetUserinfoIList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UserID,AttNumber,Ssn,Name,Gender,Title,Mobile,Birthday,Hiredday,Address,Province,City,Zip,OfficePhone,VerificationMethod,DefaultDeptid,RoleID,Att,Inlate,Outearly,Overtime,Holiday,Nationality,Password,Lunchduration,MverifyPass");
            strSql.Append(" FROM Userinfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.GetIList<Model.Userinfo>(strSql.ToString(), CommandType.Text);
        }

        public ReturnValue AddXlsUserInfo(string UserID, string Name, string DepartmentsName, string Att)
        {
            int iReturnValue = -10;
            string strErrInfo = "No Return Info!";
            SqlCommand cmd = new SqlCommand();
            try
            {
                string cmdText = "AddXlsUserInfo";
                cmd.Connection = new SqlConnection(AppSettings.GetConString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = cmdText;
                cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int));
                cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@DepartmentsName", DepartmentsName));
                cmd.Parameters.Add(new SqlParameter("@Att", Att));                
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
                LogManager.WriteTextLog("SQLServerDAL", "", "AddXlsUserInfo", ex.Message + ex.StackTrace);
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
