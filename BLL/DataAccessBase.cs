using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;

namespace BLL
{
    public class DataAccessBase
    {
        public SqlProvider DbHelperSQL;
        public DataAccessBase()
        {
            DbHelperSQL = new SqlProvider();
        }
    }
}
