using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class BLLDepartments : SQLHelper
    {

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Departments model)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("insert into DEPARTMENTS(");
            sb.Append("DEPTID,DEPTNAME,SUPDEPTID)");
            sb.Append(" values (");
            sb.Append("@DEPTID,@DEPTNAME,@SUPDEPTID)");
            return DbHelperSQL.ExcuteNonQuery(sb.ToString(), CommandType.Text, DbHelperSQL.CreateParamters(sb.ToString(), model));
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Departments model)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("update DEPARTMENTS set ");
            sb.Append("DEPTNAME=@DEPTNAME,");
            sb.Append("SUPDEPTID=@SUPDEPTID");
            sb.Append(" where DEPTID=@DEPTID ");
            return DbHelperSQL.ExcuteNonQuery(sb.ToString(), CommandType.Text, DbHelperSQL.CreateParamters(sb.ToString(), model));
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(string DEPTID)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("delete from DEPARTMENTS ");
            sb.Append(" where DEPTID=@DEPTID ");
            SqlParameter[] parameters =
            {
					new SqlParameter("@DEPTID", DEPTID)
            };
            return DbHelperSQL.ExcuteNonQuery(sb.ToString(), CommandType.Text, parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Departments GetModel(string DEPTID)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("select  top 1 DEPTID,DEPTNAME,SUPDEPTID from DEPARTMENTS ");
            sb.Append(" where DEPTID=@DEPTID ");
            SqlParameter[] parameters = 
            {
					new SqlParameter("@DEPTID",DEPTID)
            };
            Departments model = new Departments();
            DataSet ds = DbHelperSQL.GetDataSet(sb.ToString(), CommandType.Text, parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.DEPTID = ds.Tables[0].Rows[0]["DEPTID"].ToString();
                model.DEPTNAME = ds.Tables[0].Rows[0]["DEPTNAME"].ToString();
                model.SUPDEPTID = ds.Tables[0].Rows[0]["SUPDEPTID"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public IList<Departments> GetList(string strWhere)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT T1.[DEPTID] ");
            sb.Append(",T1.[DEPTNAME] ");
            sb.Append(",T1.[SUPDEPTID] ");
            sb.Append(",ISNULL(T2.[DEPTNAME],'') AS SUPDEPTNAME ");
            sb.Append(" FROM [DEPARTMENTS] AS T1 ");
            sb.Append(" LEFT JOIN DEPARTMENTS AS T2 ON T1.SUPDEPTID=T2.DEPTID ");
            if (strWhere.Trim() != "")
            {
                sb.Append(" where " + strWhere);
            }
            return DbHelperSQL.GetIList<Departments>(sb.ToString(), CommandType.Text);
        }
    }
}
