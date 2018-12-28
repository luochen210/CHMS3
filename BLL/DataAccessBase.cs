using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class SQLHelper
    {
        public DAL.SQLHelper DbHelperSQL;
        public SQLHelper()
        {
            DbHelperSQL = new DAL.SQLHelper();
        }
    }
}
