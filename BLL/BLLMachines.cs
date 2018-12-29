using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace BLL
{

    /// <summary>
    /// 数据访问类Machines。
    /// </summary>
    public class BLLMachines : SQLHelper
    {
        public BLLMachines()
        { }
        #region  成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(DAL.Machines model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Machines(");
            strSql.Append("Idx,MachineName,ConnectType,IP,SerialPort,Port,Baudrate,MachineNumber,CommPassword,sn,State)");
            strSql.Append(" values (");
            strSql.Append("@Idx,@MachineName,@ConnectType,@IP,@SerialPort,@Port,@Baudrate,@MachineNumber,@CommPassword,@sn,@State)");
            SqlParameter[] parameters = 
            {
				    new SqlParameter("@Idx", SqlDbType.VarChar,10),
					new SqlParameter("@MachineName", SqlDbType.NVarChar,20),
					new SqlParameter("@ConnectType", SqlDbType.VarChar,10),
					new SqlParameter("@IP", SqlDbType.NVarChar,20),
					new SqlParameter("@Port", SqlDbType.NVarChar,20),
					new SqlParameter("@SerialPort", SqlDbType.NVarChar,20),
					new SqlParameter("@Baudrate", SqlDbType.NVarChar,20),
					new SqlParameter("@MachineNumber", SqlDbType.NVarChar,20),
					new SqlParameter("@CommPassword", SqlDbType.NVarChar,12),
					new SqlParameter("@sn", SqlDbType.NVarChar,20),
					new SqlParameter("@State", SqlDbType.Bit,1)
            };
            parameters[0].Value = model.Idx;
            parameters[1].Value = model.MachineName;
            parameters[2].Value = model.ConnectType;
            parameters[3].Value = model.IP;
            parameters[4].Value = model.Port;
            parameters[5].Value = model.SerialPort;
            parameters[6].Value = model.Baudrate;
            parameters[7].Value = model.MachineNumber;
            parameters[8].Value = model.CommPassword;
            parameters[9].Value = model.sn;
            parameters[10].Value = model.State;
            return DbHelperSQL.ExcuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(DAL.Machines model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Machines set ");
            strSql.Append("MachineName=@MachineName,");
            strSql.Append("ConnectType=@ConnectType,");
            strSql.Append("IP=@IP,");
            strSql.Append("SerialPort=@SerialPort,");
            strSql.Append("Port=@Port,");
            strSql.Append("Baudrate=@Baudrate,");
            strSql.Append("MachineNumber=@MachineNumber,");
            strSql.Append("CommPassword=@CommPassword,");
            strSql.Append("sn=@sn,");
            strSql.Append("State=@State");
            strSql.Append(" where Idx=@Idx ");
            SqlParameter[] parameters = 
            {	new SqlParameter("@Idx", SqlDbType.VarChar,10),
					new SqlParameter("@MachineName", SqlDbType.NVarChar,20),
					new SqlParameter("@ConnectType", SqlDbType.VarChar,10),
					new SqlParameter("@IP", SqlDbType.NVarChar,20),
					new SqlParameter("@Port", SqlDbType.NVarChar,20),
					new SqlParameter("@SerialPort", SqlDbType.NVarChar,20),
					new SqlParameter("@Baudrate", SqlDbType.NVarChar,20),
					new SqlParameter("@MachineNumber", SqlDbType.NVarChar,20),
					new SqlParameter("@CommPassword", SqlDbType.NVarChar,12),
					new SqlParameter("@sn", SqlDbType.NVarChar,20),
					new SqlParameter("@State", SqlDbType.Bit,1)
            };
            parameters[0].Value = model.Idx;
            parameters[1].Value = model.MachineName;
            parameters[2].Value = model.ConnectType;
            parameters[3].Value = model.IP;
            parameters[4].Value = model.Port;
            parameters[5].Value = model.SerialPort;
            parameters[6].Value = model.Baudrate;
            parameters[7].Value = model.MachineNumber;
            parameters[8].Value = model.CommPassword;
            parameters[9].Value = model.sn;
            parameters[10].Value = model.State;
            return DbHelperSQL.ExcuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(string Idx)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Machines ");
            strSql.Append(" where Idx=@Idx ");
            SqlParameter[] parameters = 
            {
					new SqlParameter("@Idx", SqlDbType.VarChar,50)
            };
            parameters[0].Value = Idx;
            return DbHelperSQL.ExcuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DAL.Machines GetModel(string Idx)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Idx,MachineName,ConnectType,IP,SerialPort,Port,Baudrate,MachineNumber,CommPassword,sn,State from Machines ");
            strSql.Append(" where Idx=@Idx ");
            SqlParameter[] parameters =
            {
					new SqlParameter("@Idx", SqlDbType.VarChar,50)
            };
            parameters[0].Value = Idx;
            IList<DAL.Machines> result = DbHelperSQL.GetIList<DAL.Machines>(strSql.ToString(), CommandType.Text, parameters);
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
        public IList<DAL.Machines> GetMachinesList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Idx,MachineName,ConnectType,IP,SerialPort,Port,Baudrate,MachineNumber,CommPassword,sn,State,'' Remarks");
            strSql.Append(" FROM Machines ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.GetIList<DAL.Machines>(strSql.ToString(), CommandType.Text);
        }
        #endregion  成员方法
    }
}
