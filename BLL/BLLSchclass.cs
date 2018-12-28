using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
   
    public class BLLSchclass:SQLHelper
	{
		public BLLSchclass()
		{}
		#region  成员方法

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Models.Schclass model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Schclass(");
			strSql.Append("Schclassid,Schname,Starttime,Endtime,Lateminutes,Earlyminutes,Checkin,Checkout,Checkintime1,Checkintime2,Checkouttime1,Checkouttime2,Color,Autobind)");
			strSql.Append(" values (");
			strSql.Append("@Schclassid,@Schname,@Starttime,@Endtime,@Lateminutes,@Earlyminutes,@Checkin,@Checkout,@Checkintime1,@Checkintime2,@Checkouttime1,@Checkouttime2,@Color,@Autobind)");
			SqlParameter[] parameters = {
					new SqlParameter("@Schclassid", SqlDbType.VarChar,20),
					new SqlParameter("@Schname", SqlDbType.VarChar,20),
					new SqlParameter("@Starttime", SqlDbType.VarChar,20),
					new SqlParameter("@Endtime", SqlDbType.VarChar,20),
					new SqlParameter("@Lateminutes", SqlDbType.Int,4),
					new SqlParameter("@Earlyminutes", SqlDbType.Int,4),
					new SqlParameter("@Checkin", SqlDbType.Int,4),
					new SqlParameter("@Checkout", SqlDbType.Int,4),
					new SqlParameter("@Checkintime1", SqlDbType.VarChar,20),
					new SqlParameter("@Checkintime2", SqlDbType.VarChar,20),
					new SqlParameter("@Checkouttime1", SqlDbType.VarChar,20),
					new SqlParameter("@Checkouttime2", SqlDbType.VarChar,20),
					new SqlParameter("@Color", SqlDbType.Int,4),
					new SqlParameter("@Autobind", SqlDbType.Decimal,9)};
			parameters[0].Value = model.Schclassid;
			parameters[1].Value = model.Schname;
			parameters[2].Value = model.Starttime;
			parameters[3].Value = model.Endtime;
			parameters[4].Value = model.Lateminutes;
			parameters[5].Value = model.Earlyminutes;
			parameters[6].Value = model.Checkin;
			parameters[7].Value = model.Checkout;
			parameters[8].Value = model.Checkintime1;
			parameters[9].Value = model.Checkintime2;
			parameters[10].Value = model.Checkouttime1;
			parameters[11].Value = model.Checkouttime2;
			parameters[12].Value = model.Color;
			parameters[13].Value = model.Autobind;
		 return	DbHelperSQL.ExcuteNonQuery(strSql.ToString(),CommandType.Text,parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Models.Schclass model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Schclass set ");
			strSql.Append("Schname=@Schname,");
			strSql.Append("Starttime=@Starttime,");
			strSql.Append("Endtime=@Endtime,");
			strSql.Append("Lateminutes=@Lateminutes,");
			strSql.Append("Earlyminutes=@Earlyminutes,");
			strSql.Append("Checkin=@Checkin,");
			strSql.Append("Checkout=@Checkout,");
			strSql.Append("Checkintime1=@Checkintime1,");
			strSql.Append("Checkintime2=@Checkintime2,");
			strSql.Append("Checkouttime1=@Checkouttime1,");
			strSql.Append("Checkouttime2=@Checkouttime2,");
			strSql.Append("Color=@Color,");
			strSql.Append("Autobind=@Autobind");
			strSql.Append(" where Schclassid=@Schclassid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Schclassid", SqlDbType.VarChar,20),
					new SqlParameter("@Schname", SqlDbType.VarChar,20),
					new SqlParameter("@Starttime", SqlDbType.VarChar,20),
					new SqlParameter("@Endtime", SqlDbType.VarChar,20),
					new SqlParameter("@Lateminutes", SqlDbType.Int,4),
					new SqlParameter("@Earlyminutes", SqlDbType.Int,4),
					new SqlParameter("@Checkin", SqlDbType.Int,4),
					new SqlParameter("@Checkout", SqlDbType.Int,4),
					new SqlParameter("@Checkintime1", SqlDbType.VarChar,20),
					new SqlParameter("@Checkintime2", SqlDbType.VarChar,20),
					new SqlParameter("@Checkouttime1", SqlDbType.VarChar,20),
					new SqlParameter("@Checkouttime2", SqlDbType.VarChar,20),
					new SqlParameter("@Color", SqlDbType.Int,4),
					new SqlParameter("@Autobind", SqlDbType.Decimal,9)};
			parameters[0].Value = model.Schclassid;
			parameters[1].Value = model.Schname;
			parameters[2].Value = model.Starttime;
			parameters[3].Value = model.Endtime;
			parameters[4].Value = model.Lateminutes;
			parameters[5].Value = model.Earlyminutes;
			parameters[6].Value = model.Checkin;
			parameters[7].Value = model.Checkout;
			parameters[8].Value = model.Checkintime1;
			parameters[9].Value = model.Checkintime2;
			parameters[10].Value = model.Checkouttime1;
			parameters[11].Value = model.Checkouttime2;
			parameters[12].Value = model.Color;
			parameters[13].Value = model.Autobind;
		 return	DbHelperSQL.ExcuteNonQuery(strSql.ToString(),CommandType.Text,parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(string Schclassid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Schclass ");
			strSql.Append(" where Schclassid=@Schclassid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Schclassid", SqlDbType.VarChar,50)};
			parameters[0].Value = Schclassid;

			return DbHelperSQL.ExcuteNonQuery(strSql.ToString(),CommandType.Text,parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Models.Schclass GetModel(string Schclassid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Schclassid,Schname,Starttime,Endtime,Lateminutes,Earlyminutes,Checkin,Checkout,Checkintime1,Checkintime2,Checkouttime1,Checkouttime2,Color,Autobind from Schclass ");
			strSql.Append(" where Schclassid=@Schclassid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Schclassid", SqlDbType.VarChar,50)};
			parameters[0].Value = Schclassid;
            IList<Models.Schclass> result = DbHelperSQL.GetIList<Models.Schclass>(strSql.ToString(), CommandType.Text, parameters);
            if (result!=null && result.Count > 0)
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
        public IList<Models.Schclass> GetSchclassList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select Schclassid,Schname,Starttime,Endtime,Lateminutes,Earlyminutes,Checkin,Checkout,Checkintime1,Checkintime2,Checkouttime1,Checkouttime2,Color,Autobind,IsShow");
            strSql.Append(" FROM Schclass where 1=1");
			if(strWhere.Trim()!="")
			{
				strSql.Append(strWhere);
			}
			return DbHelperSQL.GetIList<Models.Schclass>(strSql.ToString(),CommandType.Text);
		}
        public IList<Models.Schclass> GetSchclassListByID(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Schclassid,Schname,Starttime,Endtime,Lateminutes,Earlyminutes,Checkin,Checkout,Checkintime1,Checkintime2,Checkouttime1,Checkouttime2,Color,Autobind,IsShow");
            strSql.Append(" FROM Schclass WHERE  1=1");
            if (strWhere.Trim() != "")
            {
                strSql.Append(strWhere);
            }
            return DbHelperSQL.GetIList<Models.Schclass>(strSql.ToString(), CommandType.Text);
        }	

		#endregion  成员方法
	}
}
