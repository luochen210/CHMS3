using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace DAL
{
    [Serializable]
    public class Role : ILoadable
    {
        public Role()
        { }
        #region Model
        private int _idx;
        private string _ename;
        private string _cname;
        private string _dousercode;
        private DateTime _dodatetime;
        private string _notes;
        private int _rptcount;
        private bool _state;
        /// <summary>
        /// 
        /// </summary>
        public int Idx
        {
            set { _idx = value; }
            get { return _idx; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EName
        {
            set { _ename = value; }
            get { return _ename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CName
        {
            set { _cname = value; }
            get { return _cname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DoUserCode
        {
            set { _dousercode = value; }
            get { return _dousercode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DoDateTime
        {
            set { _dodatetime = value; }
            get { return _dodatetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Notes
        {
            set { _notes = value; }
            get { return _notes; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int RptCount
        {
            set { _rptcount = value; }
            get { return _rptcount; }
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