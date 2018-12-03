using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    /// <summary>
    /// 
    /// </summary>
    public class CommonUtilities : DataAccessBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ParaType"></param>
        /// <returns></returns>
        public DataTable GetAttparam(string ParaType)
        {
            return DbHelperSQL.GetDataTable(string.Format("SELECT [IDX],[ParaType],[ParaName],[ParaValue] FROM [Attparam] WHERE [ParaType]='{0}'", ParaType), CommandType.Text);
        }
    }
}
