using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection;
using System.Data;
using System.Collections;

namespace DAL
{
    public class SQLHelper
    {
        /// <summary>
        /// 连接对象
        /// </summary>
        protected SqlConnection Con;
        /// <summary>
        /// 事务对象
        /// </summary>
        protected SqlTransaction Trans;
        /// <summary>
        /// 命令对象
        /// </summary>
        protected SqlCommand Cmd;
        /// <summary>
        /// 构造函数
        /// </summary>
        public SQLHelper()
        {
            this.Con = new SqlConnection(AppSettings.GetConString());
        }     
        /// <summary>
        /// 得到执行命令对象
        /// </summary>
        /// <returns></returns>
        protected SqlCommand GetCommand()
        {
            this.Open();
            return this.Cmd;
        }     
        /// <summary>
        /// 打开数据库连接．
        /// </summary>
        public void Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
               this.Cmd = Con.CreateCommand();
            }
        }      
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        /// <summary>
        /// 启动事务
        /// </summary>
        public void BeginTrans()
        {
            this.Open();
            Trans = Con.BeginTransaction();
        }
        /// <summary>
        /// 提交事务
        /// </summary>
        public void CommitTrans()
        {
            Trans.Commit();
        } 
        /// <summary>
        /// 回滚事务
        /// </summary>
        public void RollbackTrans()
        {
            Trans.Rollback();
        }    
        /// <summary>
        /// 执行SQL返回影响的行数
        ///</summary>
        /// <param name="commandString">SQL语句</param>
        /// <returns>影响的行数</returns>
        public int ExcuteNonQuery(string commandString, CommandType cmdType)
        {
            Cmd = GetCommand();
            Cmd.CommandText = commandString;
            Cmd.CommandType = cmdType;
            return Cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// 执行根据SQL及参数返回影响的行数
        /// </summary>
        /// <param name="commandString">sql语句</param>
        /// <param name="parameters">参数列表</param>
        /// <returns>影响的行数</returns>
        public int ExcuteNonQuery(string commandString, CommandType cmdType, SqlParameter[] parameters)
        {
            try
            {
                Cmd = GetCommand();
                Cmd.Parameters.Clear();
                Cmd.CommandText = commandString;
                Cmd.CommandType = cmdType;
                if (parameters != null && parameters.Length > 0)
                {
                    foreach (SqlParameter param in parameters)
                    {
                        Cmd.Parameters.Add(param);
                    }
                }
                return Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                Cmd.Dispose();
                Close();
            }

        }
        /// <summary>
        /// 在同一过程中实现对多SQL语句的操作
        /// </summary>
        /// <param name="commandString">SQL语句</param>
        /// <returns>返回0或1</returns>
        public int ExcuteTransNonQuery(string commandString, CommandType cmdType)
        {
            Cmd = GetCommand();
            Cmd.Transaction = Trans;
            Cmd.CommandText = commandString;
            Cmd.CommandType = cmdType;
            return Cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// 在同一过程中实现对多SQL语句的操作
        /// </summary>
        /// <param name="commandString">SQL语句</param>
        /// <param name="parameters">参数列表</param>
        /// <returns>返回0或1</returns>
        public int ExcuteTransNonQuery(string commandString, CommandType cmdType, SqlParameter[] parameters)
        {
            Cmd = GetCommand();
            Cmd.Parameters.Clear();
            Cmd.Transaction = Trans;
            Cmd.CommandType = cmdType;
            Cmd.CommandText = commandString;
            if (parameters != null && parameters.Length > 0)
            {
                foreach (SqlParameter param in parameters)
                {
                    Cmd.Parameters.Add(param);
                }
            }
            return Cmd.ExecuteNonQuery();
        }  
        /// <summary>
        /// 批量执行多条SQL语句的事务处理
        /// </summary>
        /// <param name="SqlList">多条SQL语句</param>
        public void ExecuteTransSql(IList<string> SqlList)
        {
            try
            {
                Cmd = GetCommand();
                this.BeginTrans();
                Cmd.Transaction = Trans;
                Cmd.CommandType = CommandType.Text;
                foreach (string sql in SqlList)
                {
                    Cmd.CommandText = sql;
                    Cmd.ExecuteNonQuery();
                }
                CommitTrans();
            }
            catch (Exception ex)
            {
                this.RollbackTrans();
                throw ex;
            }
            finally
            {
                Close();
            }
        }
 
        /// <summary>
        /// 获取最大的编号
        /// </summary>
        /// <param name="TableName">表名</param>
        /// <param name="FeildName">字段</param>
        /// <returns>返回最大ID</returns>
        public string GetMaxID(string TableName, string FeildName)
        {
            Cmd = GetCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "SELECT max(" + FeildName + ") FROM " + TableName;
            object maxid = Cmd.ExecuteScalar();
            if ((object.Equals(maxid, null)) || (object.Equals(maxid, DBNull.Value)))
            {
                return "1";
            }
            else
            {
                return (int.Parse(maxid.ToString()) + 1) + "";
            }
        }    
        /// <summary>
        /// 返回第一行第一列的值
        /// </summary>
        /// <param name="commandString">SQL语句</param>
        /// <returns>返回第一行第一列的值</returns>
        public string ExecuteScalar(string commandString, CommandType cmdType)
        {
            try
            {
                Cmd = GetCommand();
                Cmd.CommandType = cmdType;
                Cmd.CommandText = commandString;
                object result = Cmd.ExecuteScalar();
                if ((object.Equals(result, null) || object.Equals(result, DBNull.Value)))
                {
                    return "";
                }
                return result.ToString();
            }
            catch
            {

                return "";
            }
        }
        public int ExecuteScalar(string commandString, CommandType cmdType, params SqlParameter[] parameters)
        {
            try
            {
                Cmd = GetCommand();
                Cmd.CommandType = cmdType;
                Cmd.CommandText = commandString;
                if (parameters != null && parameters.Length > 0)
                {
                    foreach (SqlParameter param in parameters)
                    {
                        Cmd.Parameters.Add(param);
                    }
                }
                object result = Cmd.ExecuteScalar();
                if ((object.Equals(result, null) || object.Equals(result, DBNull.Value)))
                {
                    return 0;
                }
                return int.Parse(result.ToString());
            }
            catch(Exception)
            {

                return 0;
            }
        }
    
        /// <summary>
        /// 根据SQL语句返回DataTable数据表对象
        /// </summary>zz
        /// <param name="commandString">SQL语句</param>
        /// <returns>DataTable数据表</returns>
        public DataTable GetDataTable(string commandString, CommandType cmdType)
        {
            return GetDataSet(commandString, cmdType).Tables[0];
        }
        /// <summary>
        /// 根据SQL语句(代参数)返回DataTable数据表对象
        /// </summary>
        /// <param name="commandString">SQL语句</param>
        /// <param name="parameters">IList-parameters参数对象集合</param>
        /// <returns>DataTable数据表</returns>
        public DataTable GetDataTable(string commandString, CommandType cmdType, SqlParameter[] parameters)
        {
            return GetDataSet(commandString, cmdType, parameters).Tables[0];
        }
        /// <summary>
        /// 根据SQL语句返回DataTable数据表对象
        /// </summary>zz
        /// <param name="commandString">SQL语句</param>
        /// <returns>DataTable数据表</returns>
        public DataSet GetDataSet(string commandString, CommandType cmdType)
        {
            Cmd = GetCommand();
            DataSet result = new DataSet();
            DbDataAdapter dba = GetDbAdapter();
            Cmd.CommandType = cmdType;
            Cmd.CommandText = commandString;
            dba.SelectCommand = Cmd;
            dba.Fill(result);
            return result;
        }
        /// <summary>
        /// 根据SQL语句(代参数)返回DataTable数据表对象
        /// </summary>
        /// <param name="commandString">SQL语句</param>
        /// <param name="parameters">IList-parameters参数对象集合</param>
        /// <returns>DataTable数据表</returns>
        public DataSet GetDataSet(string commandString, CommandType cmdType, SqlParameter[] parameters)
        {
            Cmd = GetCommand();
            Cmd.CommandType = cmdType;
            Cmd.CommandText = commandString;
            if (parameters != null && parameters.Length > 0)
            {
                foreach (SqlParameter param in parameters)
                {
                    Cmd.Parameters.Add(param);
                }
            }
            DbDataAdapter dbAdapter = GetDbAdapter();
            dbAdapter.SelectCommand = Cmd;
            DataSet result = new DataSet();
            dbAdapter.Fill(result);
            Cmd.Parameters.Clear();
            return result;
        }

        /// <summary>
        /// 根据SQL语句返回DataReader对象
        /// </summary>
        /// <param name="commandString">SQL语句</param>
        /// <returns>DataReader对象</returns>
        public SqlDataReader ExcuteDataReader(string commandString, CommandType cmdType)
        {
            try
            {
                Cmd = GetCommand();
                Cmd.CommandType = cmdType;
                Cmd.CommandText = commandString;
                return Cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            finally
            {
                Cmd.Dispose();
           }
        }
        /// <summary>
        /// 使用提供的参数，执行一个Command返回结果集
        /// </summary>
        /// <param name="commandString">SQL命令</param>
        /// <param name="parms">执行命令的参数对象集</param>
        /// <returns>包含结果的DataReader</returns>
        public SqlDataReader ExecuteReader(string commandString, CommandType cmdType, SqlParameter[] parameters)
        {

            Cmd = GetCommand();
            Cmd.Parameters.Clear();
            Cmd.CommandType = cmdType;
            Cmd.CommandText = commandString;
            try
            {
                if (parameters != null && parameters.Length > 0)
                {
                    foreach (SqlParameter param in parameters)
                    {
                        Cmd.Parameters.Add(param);
                    }
                }
                return Cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            finally 
            {
                Cmd.Dispose();
            }
        }

        /// <summary>
        /// 根据SQL语句返回IList对象
        /// </summary>
        /// <typeparam name="T">ILIST对象类型</typeparam>
        /// <param name="commandString">SQL语句</param>
        /// <returns>根据SQL语句返回IList-T-对象</returns>
        public IList<T> GetIList<T>(string commandString, CommandType cmdType) where T : ILoadable
        {
            IList<T> result = new List<T>();
            DbDataReader dr = ExcuteDataReader(commandString, cmdType);
            if (dr != null)
            {
                while (dr.Read())
                {
                    T obj = System.Activator.CreateInstance<T>();
                    obj.Loading(dr);
                    result.Add(obj);
                }
                dr.Close();
                Close();
            }
            return result;
        }

        /// <summary>
        /// 执行带参数的SQL语句返回的对象集
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="cmdText">SQL语句</param>
        /// <param name="parms">参数</param>
        /// <returns>对象集</returns>
        public List<T> GetIList<T>(string cmdText, CommandType cmdType, SqlParameter[] parameters) where T : ILoadable
        {
            List<T> result = new List<T>();
            SqlDataReader dr = ExecuteReader(cmdText, cmdType, parameters);
            while (dr.Read())
            {
                T obj = System.Activator.CreateInstance<T>();
                obj.Loading(dr);
                result.Add(obj);
            }
            dr.Close();
            Close();
            return result;
        }
        /// <summary>
        /// 创建参数对象
        /// </summary>
        /// <returns>参数对象</returns>
        public SqlParameter CreateParameter()
        {
            return new SqlParameter();
        }
        /// <summary>
        /// 参数列表对象对象
        /// </summary>
        /// <param name="parameterName">参数名称</param>
        /// <param name="value">参数值</param>
        /// <returns>参数列表对象对象</returns>
        public SqlParameter CreateParameter(string parameterName, object value)
        {
            return new SqlParameter(parameterName, value);
        }
        /// <summary>
        /// 返回适配器对象
        /// </summary>
        /// <returns>返回适配器对象</returns>
        public SqlDataAdapter GetDbAdapter()
        {
            return new SqlDataAdapter();
        }
        /// <summary>
        /// 根据SQL语句自动返回参数列表对象
        /// </summary>
        /// <param name="commandString">SQL语句</param>
        /// <param name="model">实现ILoadable的接口</param>
        /// <returns>参数列表对象</returns>
        public SqlParameter[] CreateParamters(string commandString, ILoadable model)
        {
            ArrayList Parameters = new ArrayList();
            PropertyInfo[] properties = model.GetType().GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                string parm = "@" + prop.Name.ToLower();
                if (commandString.ToLower().IndexOf(parm) != -1)
                {
                    Parameters.Add(CreateParameter(parm, prop.GetValue(model, null)));
                }
            }
            return (SqlParameter[])Parameters.ToArray(typeof(SqlParameter));
        }





    }
}
