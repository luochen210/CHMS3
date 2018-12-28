using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Reflection;

namespace Model
{
    [Serializable]
    public class Machines : ILoadable
    {
        public Machines()
        { }
        #region Model
        private string _idx;
        private string _machinename;
        private string _connecttype;
        private string _ip;
        private string _serialport;
        private string _port;
        private string _baudrate;
        private string _machinenumber;
        private string _commpassword;
        private string _sn;
        private bool _state;
        private string _remarks = "";
        /// <summary>
        /// 连接状态
        /// </summary>
        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Idx
        {
            set { _idx = value; }
            get { return _idx; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MachineName
        {
            set { _machinename = value; }
            get { return _machinename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ConnectType
        {
            set { _connecttype = value; }
            get { return _connecttype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IP
        {
            set { _ip = value; }
            get { return _ip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SerialPort
        {
            set { _serialport = value; }
            get { return _serialport; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Port
        {
            set { _port = value; }
            get { return _port; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Baudrate
        {
            set { _baudrate = value; }
            get { return _baudrate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MachineNumber
        {
            set { _machinenumber = value; }
            get { return _machinenumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CommPassword
        {
            set { _commpassword = value; }
            get { return _commpassword; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sn
        {
            set { _sn = value; }
            get { return _sn; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool State
        {
            set { _state = value; }
            get { return _state; }
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
