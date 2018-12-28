using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Reflection;

namespace Model
{

    [Serializable]
    public class Userinfo : ILoadable
    {
        public Userinfo()
        { }
        #region Model
        private string _userid;
        private string _attnumber;
        private string _ssn;
        private string _name;
        private string _gender;
        private string _title;
        private string _mobile;
        private DateTime _birthday;
        private DateTime _hiredday;
        private string _address;
        private string _province;
        private string _city;
        private string _zip;
        private string _officephone;
        private int _verificationmethod;
        private string _defaultdeptid;
        private int _roleid;
        private string _att;
        private int _inlate;
        private int _outearly;
        private int _overtime;
        private int _holiday;
        private string _nationality;
        private string _password;
        private int _lunchduration;
        private string _mverifypass;
       // private byte[] _photo;
        /// <summary>
        /// 
        /// </summary>
        public string UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AttNumber
        {
            set { _attnumber = value; }
            get { return _attnumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Ssn
        {
            set { _ssn = value; }
            get { return _ssn; }
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
        public string Gender
        {
            set { _gender = value; }
            get { return _gender; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
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
        public DateTime Birthday
        {
            set { _birthday = value; }
            get { return _birthday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Hiredday
        {
            set { _hiredday = value; }
            get { return _hiredday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Province
        {
            set { _province = value; }
            get { return _province; }
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
        public string Zip
        {
            set { _zip = value; }
            get { return _zip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OfficePhone
        {
            set { _officephone = value; }
            get { return _officephone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int VerificationMethod
        {
            set { _verificationmethod = value; }
            get { return _verificationmethod; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DefaultDeptid
        {
            set { _defaultdeptid = value; }
            get { return _defaultdeptid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int RoleID
        {
            set { _roleid = value; }
            get { return _roleid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Att
        {
            set { _att = value; }
            get { return _att; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Inlate
        {
            set { _inlate = value; }
            get { return _inlate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Outearly
        {
            set { _outearly = value; }
            get { return _outearly; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Overtime
        {
            set { _overtime = value; }
            get { return _overtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Holiday
        {
            set { _holiday = value; }
            get { return _holiday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Nationality
        {
            set { _nationality = value; }
            get { return _nationality; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Lunchduration
        {
            set { _lunchduration = value; }
            get { return _lunchduration; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MverifyPass
        {
            set { _mverifypass = value; }
            get { return _mverifypass; }
        }
        /// <summary>
        /// 
        /// </summary>
        //public byte[] Photo
        //{
        //    set { _photo = value; }
        //    get { return _photo; }
        //}
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
