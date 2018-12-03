using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace BLL
{

    public class BLLRunNum : DataAccessBase
    {
        public BLLRunNum()
        { }
        #region  成员方法

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.RunNum model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into RunNum(");
            strSql.Append("RunID,Name,Startdate,Enddate,Cyle,Units)");
            strSql.Append(" values (");
            strSql.Append("@RunID,@Name,@Startdate,@Enddate,@Cyle,@Units)");
            SqlParameter[] parameters =
            {
					new SqlParameter("@RunID", SqlDbType.VarChar,20),
					new SqlParameter("@Name", SqlDbType.VarChar,30),
					new SqlParameter("@Startdate", SqlDbType.DateTime),
					new SqlParameter("@Enddate", SqlDbType.DateTime),
					new SqlParameter("@Cyle", SqlDbType.SmallInt,2),
					new SqlParameter("@Units", SqlDbType.VarChar,50)
           
            };
            parameters[0].Value = model.RunID;
            parameters[1].Value = model.Name;
            parameters[2].Value = model.Startdate;
            parameters[3].Value = model.Enddate;
            parameters[4].Value = model.Cyle;
            parameters[5].Value = model.Units;
            return DbHelperSQL.ExcuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Model.RunNum model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update RunNum set ");
            strSql.Append("Name=@Name,");
            strSql.Append("Startdate=@Startdate,");
            strSql.Append("Enddate=@Enddate,");
            strSql.Append("Cyle=@Cyle,");
            strSql.Append("Units=@Units");

            strSql.Append(" where RunID=@RunID ");
            SqlParameter[] parameters = {
					new SqlParameter("@RunID", SqlDbType.VarChar,20),
					new SqlParameter("@Name", SqlDbType.VarChar,30),
					new SqlParameter("@Startdate", SqlDbType.DateTime),
					new SqlParameter("@Enddate", SqlDbType.DateTime),
					new SqlParameter("@Cyle", SqlDbType.SmallInt,2),
					new SqlParameter("@Units", SqlDbType.VarChar,50)             
                    };
            parameters[0].Value = model.RunID;
            parameters[1].Value = model.Name;
            parameters[2].Value = model.Startdate;
            parameters[3].Value = model.Enddate;
            parameters[4].Value = model.Cyle;
            parameters[5].Value = model.Units;
            return DbHelperSQL.ExcuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(string RunID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from RunNum ");
            strSql.Append(" where RunID=@RunID ");
            SqlParameter[] parameters = {
					new SqlParameter("@RunID", SqlDbType.VarChar,50)};
            parameters[0].Value = RunID;
            return DbHelperSQL.ExcuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.RunNum GetModel(string RunID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select RunID,Name,Startdate,Enddate,Cyle,Units from RunNum ");
            strSql.Append(" where  RunID=@RunID ");
            SqlParameter[] parameters = {
					new SqlParameter("@RunID", SqlDbType.VarChar,50)};
            parameters[0].Value = RunID;
            IList<Model.RunNum> result = DbHelperSQL.GetIList<Model.RunNum>(strSql.ToString(), CommandType.Text, parameters);
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
        public IList<Model.RunNum> GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select RunID,Name,Startdate,Enddate,Cyle,Units");
            strSql.Append(" FROM RunNum WHERE IsShow='1'");
            if (strWhere.Trim() != "")
            {
                strSql.Append(strWhere);
            }
            return DbHelperSQL.GetIList<Model.RunNum>(strSql.ToString(), CommandType.Text);
        }
        public IList<Model.RunNum> GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select RunID,Name,Startdate,Enddate,Cyle,Units");
            strSql.Append(" FROM RunNum ");
            return DbHelperSQL.GetIList<Model.RunNum>(strSql.ToString(), CommandType.Text);
        }
        public int AddRunNumSchclass(string strSql)
        {
            return DbHelperSQL.ExcuteNonQuery(strSql, CommandType.Text);
        }
        public IList<Model.RunNumSchclass> GetRunNumSchclassList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select RunID,SchclassID ");
            strSql.Append(" FROM RunNumSchclass WHERE 1=1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(strWhere);
            }
            return DbHelperSQL.GetIList<Model.RunNumSchclass>(strSql.ToString(), CommandType.Text);
        }

        public DataTable GetRunNumDataTable()
        {
            return DbHelperSQL.GetDataTable("SELECT [RunID],[Name] FROM [RunNum]", CommandType.Text);
        }
        #endregion  成员方法
    }
}
