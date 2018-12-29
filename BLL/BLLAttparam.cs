using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
   public class BLLAttparam:SQLHelper
    {
        public DAL.Attparam GetModel(int IDX)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select IDX,ParaType,ParaName,ParaValue from Attparam ");
			strSql.Append(" where IDX=@IDX ");
			SqlParameter[] parameters = {
					new SqlParameter("@IDX", SqlDbType.Int,4)};
			parameters[0].Value = IDX;
            IList<DAL.Attparam> result = DbHelperSQL.GetIList<DAL.Attparam>(strSql.ToString(), CommandType.Text);
	
			if(result!=null && result.Count>0)
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
		public IList<DAL.Attparam> GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select IDX,ParaType,ParaName,ParaValue ");
			strSql.Append(" FROM Attparam ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.GetIList<DAL.Attparam>(strSql.ToString(),CommandType.Text);
		}
    }    
}
