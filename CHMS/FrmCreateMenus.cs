using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
//下载源码到51aspx
namespace CHMS
{
    public partial class FrmCreateMenus : Form
    {
        public FrmCreateMenus()
        {
            InitializeComponent();
        }

        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string strSql="INSERT INTO[Func]([No],[Moduleid],[Name])VALUES('{0}','{1}','{2}')";
            DataSet ds = new DataSet();
            ds.ReadXml(Application.StartupPath + @"\Menu.xml");
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["ParentItemID"].ToString() != "0")
                {
                    new SqlProvider().ExcuteNonQuery(string.Format(strSql, dt.Rows[i]["FormName"].ToString(), dt.Rows[i]["ParentItemID"].ToString(), dt.Rows[i]["Text"].ToString()), CommandType.Text);
                }                
            }
        }
        private void frmCreateMenus_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Application.StartupPath + @"\Menu.xml");
            dgvMenus.DataSource = ds.Tables[0];
        }
    }
}
