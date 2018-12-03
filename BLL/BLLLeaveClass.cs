using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class BLLLeaveClass : DataAccessBase
    {
        public BLLLeaveClass()
        { }
        #region  成员方法

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.LeaveClass model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into LeaveClass(");
            strSql.Append("LeaveId,LeaveName,MinUnit,Unit,RemaindProc,RemaindCount,ReportSymbol,Deduct,Color,Classify)");
            strSql.Append(" values (");
            strSql.Append("@LeaveId,@LeaveName,@MinUnit,@Unit,@RemaindProc,@RemaindCount,@ReportSymbol,@Deduct,@Color,@Classify)");
            SqlParameter[] parameters = {
					new SqlParameter("@LeaveId", SqlDbType.VarChar,20),
					new SqlParameter("@LeaveName", SqlDbType.VarChar,20),
					new SqlParameter("@MinUnit", SqlDbType.Float,8),
					new SqlParameter("@Unit", SqlDbType.SmallInt,2),
					new SqlParameter("@RemaindProc", SqlDbType.SmallInt,2),
					new SqlParameter("@RemaindCount", SqlDbType.SmallInt,2),
					new SqlParameter("@ReportSymbol", SqlDbType.VarChar,20),
					new SqlParameter("@Deduct", SqlDbType.Float,8),
					new SqlParameter("@Color", SqlDbType.VarChar,20),
					new SqlParameter("@Classify", SqlDbType.SmallInt,2)};
            parameters[0].Value = model.LeaveId;
            parameters[1].Value = model.LeaveName;
            parameters[2].Value = model.MinUnit;
            parameters[3].Value = model.Unit;
            parameters[4].Value = model.RemaindProc;
            parameters[5].Value = model.RemaindCount;
            parameters[6].Value = model.ReportSymbol;
            parameters[7].Value = model.Deduct;
            parameters[8].Value = model.Color;
            parameters[9].Value = model.Classify;
           return DbHelperSQL.ExcuteNonQuery(strSql.ToString(),CommandType.Text,parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Model.LeaveClass model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update LeaveClass set ");
            strSql.Append("LeaveName=@LeaveName,");
            strSql.Append("MinUnit=@MinUnit,");
            strSql.Append("Unit=@Unit,");
            strSql.Append("RemaindProc=@RemaindProc,");
            strSql.Append("RemaindCount=@RemaindCount,");
            strSql.Append("ReportSymbol=@ReportSymbol,");
            strSql.Append("Deduct=@Deduct,");
            strSql.Append("Color=@Color,");
            strSql.Append("Classify=@Classify");
            strSql.Append(" where LeaveId=@LeaveId ");
            SqlParameter[] parameters = {
					new SqlParameter("@LeaveId", SqlDbType.VarChar,20),
					new SqlParameter("@LeaveName", SqlDbType.VarChar,20),
					new SqlParameter("@MinUnit", SqlDbType.Float,8),
					new SqlParameter("@Unit", SqlDbType.SmallInt,2),
					new SqlParameter("@RemaindProc", SqlDbType.SmallInt,2),
					new SqlParameter("@RemaindCount", SqlDbType.SmallInt,2),
					new SqlParameter("@ReportSymbol", SqlDbType.VarChar,20),
					new SqlParameter("@Deduct", SqlDbType.Float,8),
					new SqlParameter("@Color", SqlDbType.VarChar,20),
					new SqlParameter("@Classify", SqlDbType.SmallInt,2)};
            parameters[0].Value = model.LeaveId;
            parameters[1].Value = model.LeaveName;
            parameters[2].Value = model.MinUnit;
            parameters[3].Value = model.Unit;
            parameters[4].Value = model.RemaindProc;
            parameters[5].Value = model.RemaindCount;
            parameters[6].Value = model.ReportSymbol;
            parameters[7].Value = model.Deduct;
            parameters[8].Value = model.Color;
            parameters[9].Value = model.Classify;
           return  DbHelperSQL.ExcuteNonQuery(strSql.ToString(),CommandType.Text,parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(string LeaveId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from LeaveClass ");
            strSql.Append(" where LeaveId=@LeaveId ");
            SqlParameter[] parameters = {
					new SqlParameter("@LeaveId", SqlDbType.VarChar,50)};
            parameters[0].Value = LeaveId;
           return  DbHelperSQL.ExcuteNonQuery(strSql.ToString(),CommandType.Text,parameters);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public IList<Model.LeaveClass> GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select LeaveId,LeaveName,MinUnit,Unit,RemaindProc,RemaindCount,ReportSymbol,Deduct,Color,Classify ");
            strSql.Append(" FROM LeaveClass ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.GetIList<Model.LeaveClass>(strSql.ToString(),CommandType.Text);
        }

        public DataTable GetDataTable()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select LeaveId,LeaveName");
            strSql.Append(" FROM LeaveClass ");
            return DbHelperSQL.GetDataTable(strSql.ToString(), CommandType.Text);
        }
        #endregion  成员方法
    }
}
