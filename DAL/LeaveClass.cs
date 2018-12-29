using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace DAL
{
    [Serializable]
    public class LeaveClass : ILoadable
    {
        public LeaveClass()
        { }
        #region Model
        private string _leaveid;
        private string _leavename;
        private decimal _minunit;
        private int _unit;
        private int _remaindproc;
        private int _remaindcount;
        private string _reportsymbol;
        private decimal _deduct;
        private string _color;
        private int _classify;
        /// <summary>
        /// 
        /// </summary>
        public string LeaveId
        {
            set { _leaveid = value; }
            get { return _leaveid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LeaveName
        {
            set { _leavename = value; }
            get { return _leavename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal MinUnit
        {
            set { _minunit = value; }
            get { return _minunit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Unit
        {
            set { _unit = value; }
            get { return _unit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int RemaindProc
        {
            set { _remaindproc = value; }
            get { return _remaindproc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int RemaindCount
        {
            set { _remaindcount = value; }
            get { return _remaindcount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ReportSymbol
        {
            set { _reportsymbol = value; }
            get { return _reportsymbol; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Deduct
        {
            set { _deduct = value; }
            get { return _deduct; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Color
        {
            set { _color = value; }
            get { return _color; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Classify
        {
            set { _classify = value; }
            get { return _classify; }
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
