using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Reflection;

namespace Model
{

    public class Holidays : ILoadable
    {
        public Holidays()
        { }
        #region Model
        private int _holidayid;
        private DateTime _holidaydate;
        private string _leaveid;
        private string _leavename;
        /// <summary>
        /// 
        /// </summary>
        public string LeaveName
        {
            get { return _leavename; }
            set { _leavename = value; }
        }
        public int Holidayid
        {
            set { _holidayid = value; }
            get { return _holidayid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime HolidayDate
        {
            set { _holidaydate = value; }
            get { return _holidaydate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LeaveId
        {
            set { _leaveid = value; }
            get { return _leaveid; }
        }
        #endregion Model

        #region ILoadable 成员

        void ILoadable.Loading(System.Data.IDataReader dr)
        {
            for (int i = 0; i < dr.FieldCount; i++)
            {
                if (!object.Equals(dr[i], DBNull.Value))
                {
                    FieldInfo field = this.GetType().GetField("_" + dr.GetName(i).ToLower(), BindingFlags.NonPublic | BindingFlags.Instance);
                    if (field != null)
                    {
                        switch (field.FieldType.Name)
                        {
                            case "DateTime":
                                {
                                    field.SetValue(this, DateTime.Parse(dr[i].ToString()));
                                    break;
                                }
                            case "Decimal":
                                {
                                    field.SetValue(this, decimal.Parse(dr[i].ToString()));
                                    break;
                                }
                            case "Int32":
                                {
                                    field.SetValue(this, int.Parse(dr[i].ToString()));
                                    break;
                                }
                            case "Boolean":
                                {
                                    field.SetValue(this, Convert.ToBoolean(dr[i]));
                                    break;
                                }
                            default:
                                {
                                    field.SetValue(this, dr[i].ToString());
                                    break;
                                }
                        }
                    }
                }
            }
        }

        #endregion

    }
}
