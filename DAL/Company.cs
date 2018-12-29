using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace DAL
{
    /// <summary>
    /// 实体类COMPANY 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class Company : ILoadable
    {
        public Company()
        { }
        #region Models
        private string _companyid;
        private string _city;
        private string _country;
        private string _addr;
        private string _principal;
        private string _chinesename;
        private string _englishname;
        private string _tel;
        private string _mobile;
        private string _fax;
        private string _email;
        private string _zip;
        private string _reamark;
        private string _website;
        /// <summary>
        /// 
        /// </summary>
        public string CompanyID
        {
            set { _companyid = value; }
            get { return _companyid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string City
        {
            set { _city = value; }
            get { return _city; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Country
        {
            set { _country = value; }
            get { return _country; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Addr
        {
            set { _addr = value; }
            get { return _addr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Principal
        {
            set { _principal = value; }
            get { return _principal; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ChineseName
        {
            set { _chinesename = value; }
            get { return _chinesename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EnglishName
        {
            set { _englishname = value; }
            get { return _englishname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Tel
        {
            set { _tel = value; }
            get { return _tel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mobile
        {
            set { _mobile = value; }
            get { return _mobile; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Fax
        {
            set { _fax = value; }
            get { return _fax; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Zip
        {
            set { _zip = value; }
            get { return _zip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Reamark
        {
            set { _reamark = value; }
            get { return _reamark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WebSite
        {
            set { _website = value; }
            get { return _website; }
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
