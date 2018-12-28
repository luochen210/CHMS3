using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using BLL;

namespace CHMS
{
    public partial class FrmUserInfoXls : Form
    {
        public FrmUserInfoXls()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUserInfo.DataSource != null && dgvUserInfo.Rows.Count > 0)
                {
                    string UserID = "";
                    string Name = "";
                    string DepartmentsName = "";
                    string Att = "";
                    BLLUserinfo user = new BLLUserinfo();
                    for (int i = 0; i < dgvUserInfo.Rows.Count; i++)
                    {
                        UserID = dgvUserInfo.Rows[i].Cells[0].Value.ToString();
                        Name = dgvUserInfo.Rows[i].Cells[1].Value.ToString();
                        DepartmentsName = dgvUserInfo.Rows[i].Cells[2].Value.ToString();
                        Att = dgvUserInfo.Rows[i].Cells[3].Value.ToString();
                        user.AddXlsUserInfo(UserID, Name, DepartmentsName, Att);
                    }
                    MessageBox.Show("导入成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteTextLog("CHMS", "frmUserInfoXls", "btnSave_Click", ex.Message + ex.StackTrace);
                MessageBox.Show("导入失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string path = openFileDialog1.FileName;
                ImportExportToExcel excl = new ImportExportToExcel();
                this.dgvUserInfo.DataSource = excl.ImportFromExcel(path);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
