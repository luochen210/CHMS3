using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;
using System.Data.Common;
using System.Data;
namespace BLL
{
    /// <summary>
    /// 数据访问类COMPANY。
    /// </summary>
    public class BLLCompany:SQLHelper
    {
        public BLLCompany()
        { }

        #region  成员方法

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Insert(Models.Company model)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("insert into COMPANY(");
            sb.Append("COMPANYID,City,Country,Addr,Principal,ChineseName,EnglishName,Tel,Mobile,Fax,Email,ZIP,Reamark,WebSite)");
            sb.Append(" values (");
            sb.Append("@COMPANYID,@City,@Country,@Addr,@Principal,@ChineseName,@EnglishName,@Tel,@Mobile,@Fax,@Email,@ZIP,@Reamark,@WebSite)");
            return DbHelperSQL.ExcuteNonQuery(sb.ToString(), CommandType.Text, DbHelperSQL.CreateParamters(sb.ToString(), model));
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Models.Company model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update COMPANY set ");
            strSql.Append("City=@City,");
            strSql.Append("Country=@Country,");
            strSql.Append("Addr=@Addr,");
            strSql.Append("Principal=@Principal,");
            strSql.Append("ChineseName=@ChineseName,");
            strSql.Append("EnglishName=@EnglishName,");
            strSql.Append("Tel=@Tel,");
            strSql.Append("Mobile=@Mobile,");
            strSql.Append("Fax=@Fax,");
            strSql.Append("Email=@Email,");
            strSql.Append("ZIP=@ZIP,");
            strSql.Append("Reamark=@Reamark,");
            strSql.Append("WebSite=@WebSite");
            strSql.Append(" where COMPANYID=@COMPANYID ");
            return DbHelperSQL.ExcuteNonQuery(strSql.ToString(),CommandType.Text,DbHelperSQL.CreateParamters(strSql.ToString(), model));

        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Models.Company GetModel()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 COMPANYID,City,Country,Addr,Principal,ChineseName,EnglishName,Tel,Mobile,Fax,Email,ZIP,Reamark,WebSite from COMPANY ");
            IList<Models.Company> result = DbHelperSQL.GetIList<Models.Company>(strSql.ToString(),CommandType.Text);
            if (result != null && result.Count > 0)
            {
                return result[0];
            }
            return null;

        }
        #endregion  成员方法
    }
}
