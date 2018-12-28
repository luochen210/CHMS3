using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Reflection;

namespace Model
{

    [Serializable]
    public class RunNum : ILoadable
    {
        public RunNum()
        { }
        #region Model
        private string _runid;
        private string _name;
        private DateTime _startdate;
        private DateTime _enddate;
        private int _cyle;
        private string _units;     
        /// <summary>
        /// 
        /// </summary>
        public string RunID
        {
            set { _runid = value; }
            get { return _runid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Startdate
        {
            set { _startdate = value; }
            get { return _startdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Enddate
        {
            set { _enddate = value; }
            get { return _enddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Cyle
        {
            set { _cyle = value; }
            get { return _cyle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Units
        {
            set { _units = value; }
            get { return _units; }
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