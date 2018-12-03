using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Reflection;

namespace Model
{

    [Serializable]
    public class Schclass : ILoadable
    {
        public Schclass()
        { }
        #region Model
        private string _schclassid;
        private string _schname;
        private string _starttime;
        private string _endtime;
        private int _lateminutes;
        private int _earlyminutes;
        private int _checkin;
        private int _checkout;
        private string _checkintime1;
        private string _checkintime2;
        private string _checkouttime1;
        private string _checkouttime2;
        private int _color;
        private decimal _autobind;
        private bool _isshow = true;
        /// <summary>
        /// 
        /// </summary>


        public bool IsShow
        {
            get { return _isshow; }
            set { _isshow = value; }
        }
        public string Schclassid
        {
            set { _schclassid = value; }
            get { return _schclassid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Schname
        {
            set { _schname = value; }
            get { return _schname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Starttime
        {
            set { _starttime = value; }
            get { return _starttime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Endtime
        {
            set { _endtime = value; }
            get { return _endtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Lateminutes
        {
            set { _lateminutes = value; }
            get { return _lateminutes; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Earlyminutes
        {
            set { _earlyminutes = value; }
            get { return _earlyminutes; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Checkin
        {
            set { _checkin = value; }
            get { return _checkin; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Checkout
        {
            set { _checkout = value; }
            get { return _checkout; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Checkintime1
        {
            set { _checkintime1 = value; }
            get { return _checkintime1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Checkintime2
        {
            set { _checkintime2 = value; }
            get { return _checkintime2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Checkouttime1
        {
            set { _checkouttime1 = value; }
            get { return _checkouttime1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Checkouttime2
        {
            set { _checkouttime2 = value; }
            get { return _checkouttime2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Color
        {
            set { _color = value; }
            get { return _color; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Autobind
        {
            set { _autobind = value; }
            get { return _autobind; }
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
