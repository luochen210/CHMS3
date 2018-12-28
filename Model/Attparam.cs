using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Reflection;

namespace Model
{
   
    [Serializable]
    public class Attparam : ILoadable
    {
        public Attparam()
        { }
        #region Model
        private int _idx;
        private string _paratype;
        private string _paraname;
        private string _paravalue;
        /// <summary>
        /// 
        /// </summary>
        public int IDX
        {
            set { _idx = value; }
            get { return _idx; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ParaType
        {
            set { _paratype = value; }
            get { return _paratype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ParaName
        {
            set { _paraname = value; }
            get { return _paraname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ParaValue
        {
            set { _paravalue = value; }
            get { return _paravalue; }
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
