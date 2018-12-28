using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
//下载源码到51aspx
namespace CHMS
{
    public partial class FrmRun : Form
    {
        private string DoType = "Insert";
        private BLLRunNum Ation = new BLLRunNum();
        private DAL.SqlProvider DbHelperSQL;
        public FrmRun()
        {
            InitializeComponent();
            DbHelperSQL = new DAL.SqlProvider();
        }
        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DoType == "Insert")
            {
                if (Ation.Add(GetRunNumModel()) > 0)
                {
                    string SchclassInfo=GetSchclassInfo();
                    if (SchclassInfo != "")
                    {
                        Ation.AddRunNumSchclass(string.Format("DELETE FROM [RunNumSchclass] WHERE RunID='{0}';", txtRunID.Text.Trim())+SchclassInfo);
                    }
                    MessageBox.Show("添加成功", "班次管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindRunNumIlist();
                    btnAdd_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("添加失败", "班次管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                if (Ation.Update(GetRunNumModel()) > 0)
                {
                    string SchclassInfo = GetSchclassInfo();
                    if (SchclassInfo != "")
                    {
                        Ation.AddRunNumSchclass(string.Format("DELETE FROM [RunNumSchclass] WHERE RunID='{0}';", txtRunID.Text.Trim()) + SchclassInfo);
                    }
                    MessageBox.Show("修改成功", "班次管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BindRunNumIlist();
                    btnAdd_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("修改失败", "班次管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void BindRunNumIlist()
        {
            this.dgvRun.AutoGenerateColumns = false;
            this.dgvRun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvRun.DataSource = Ation.GetList("");
        }
        private void frmRun_Load(object sender, EventArgs e)
        {
            cbUnits.ValueMember = "ParaValue";
            cbUnits.DisplayMember = "ParaName";
            cbUnits.DataSource = new BLLAttparam().GetList(" ParaType='Periodic'");
            //
            this.BindRunNumIlist();
            //
            this.dgvSchclass.AutoGenerateColumns = false;
            this.dgvSchclass.DataSource = new BLLSchclass().GetSchclassList("");
            this.dgvSchclass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private Model.RunNum GetRunNumModel()
        {
            Model.RunNum model = new Model.RunNum();
            model.RunID = txtRunID.Text;
            model.Name = txtName.Text;
            model.Startdate = dtStartdate.Value;
            model.Cyle = int.Parse(txtCyle.Text);
            model.Units = cbUnits.SelectedValue.ToString();
            if (model.Units == "1")
            {
                model.Enddate = model.Startdate.AddDays(model.Cyle);
            }
            if (model.Units == "2")
            {
                model.Enddate = model.Startdate.AddDays(model.Cyle * 7);
            }
            if (model.Units == "3")
            {
                model.Enddate = model.Startdate.AddMonths(model.Cyle);
            }
            if (model.Units == "4")
            {
                model.Enddate = model.Startdate.AddYears(model.Cyle);
            }          
            return model;
        }

        private void dgvRun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvRun.DataSource != null && this.dgvRun.Rows.Count > 0)
            {
                if (e.RowIndex != -1)
                {
                    Model.RunNum model = this.dgvRun.CurrentRow.DataBoundItem as Model.RunNum;
                    txtRunID.Text = model.RunID;
                    txtName.Text = model.Name;
                    dtStartdate.Value = model.Startdate;
                    txtCyle.Text = model.Cyle.ToString();
                    cbUnits.SelectedValue = model.Units;
                    DoType = "Update";
                    //
                    string strWhere = string.Format("AND Schclassid IN(SELECT [SchclassID] FROM [RunNumSchclass] WHERE [RunID]  ='{0}')", model.RunID);
                  this.dgvSchclassSelect.AutoGenerateColumns = false;
                  this.dgvSchclassSelect.DataSource = new BLLSchclass().GetSchclassListByID(strWhere);
                  this.dgvSchclassSelect.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtRunID.Text = "";
            txtName.Text = "";
            dtStartdate.Value = DateTime.Now;
            txtCyle.Text = "";
            cbUnits.SelectedIndex = -1;
            DoType = "Insert";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtRunID.Text != "")
            {
                if (Ation.Delete(txtRunID.Text.Trim()) > 0)
                {
                    Ation.AddRunNumSchclass(string.Format("DELETE FROM [RunNumSchclass] WHERE RunID='{0}';", txtRunID.Text.Trim()));
                    MessageBox.Show("删除成功");
                    BindRunNumIlist();
                    btnAdd_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("删除失败!");
                    btnAdd_Click(sender, e);
                }
            }
        }
        private string GetSchclassInfo()
        {
            StringBuilder sb = new StringBuilder();
            if (this.dgvSchclass.DataSource != null && this.dgvSchclass.Rows.Count > 0)
            {
                for (int i = 0; i < dgvSchclass.Rows.Count; i++)
                {
                    Model.Schclass model = this.dgvSchclass.Rows[i].DataBoundItem as Model.Schclass;
                    if (model.IsShow)
                    {
                        sb.Append(string.Format("INSERT INTO [RunNumSchclass]([RunID],[SchclassID])VALUES('{0}','{1}');",txtRunID.Text,model.Schclassid));
                    }
                }
            }
            return sb.ToString();
        }
    }
}
