using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;

namespace CHMS
{
    public partial class FrmRunUser : Form
    {
        private UserInfoDepartments Ation = new UserInfoDepartments();
        public FrmRunUser()
        {
            InitializeComponent();
        }

        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (TreeNode Root in tvUserInfo.Nodes)
                {
                    foreach (TreeNode item in Root.Nodes)
                    {
                        if (item.Checked)
                        {
                            sb.Append(string.Format("INSERT INTO #TempUser(UserID)VALUES('{0}');", item.Tag.ToString()));
                        }
                    }
                }
                string UserInfo = sb.ToString();
                if (UserInfo == "")
                {
                    MessageBox.Show("请选择人员信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string RunID = "";
                if (cbRun.SelectedValue != null)
                {
                    RunID = cbRun.SelectedValue.ToString();
                }
                if (RunID == "")
                {
                    MessageBox.Show("请选择班次!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string SchclassInfo = GetSchclassInfo(RunID);
                if (SchclassInfo == "")
                {
                    MessageBox.Show("请选择时段信息!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DateTime StartDate = dtStartDate.Value;
                DateTime EndDate = dtEndDate.Value;
                int Sunday = chkSunday.Checked == true ? 1 : 0;
                int Saturday = chkSaturday.Checked == true ? 1 : 0;
                ReturnValue rtn = new BLLUserRun().AddRunUser(UserInfo, RunID, StartDate, EndDate, Sunday, Saturday, SchclassInfo);
                if (rtn.Result == 1)
                {
                    MessageBox.Show("排班成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("排班失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteTextLog("CHMS", "frmRunUser", "btnSave_Click", ex.Message + ex.StackTrace);
            }
        }
        private void BindUserInfoDepartments()
        {
            tvUserInfo.Nodes.Clear();
            DataSet ds;
            ReturnValue rtn = new BLL.BLLAttLog().CreateUserInfoTree(out ds);
            if (rtn.Result == 1)
            {
                DataView dv = ds.Tables[0].DefaultView;
                //通过DataView来过滤数据首先得到最顶层的菜单
                dv.RowFilter = "SupderID=0";
                for (int i = 0; i < dv.Count; i++)
                {
                    TreeNode child = new TreeNode(dv[i]["UserName"].ToString());
                    child.Tag = dv[i]["UserID"].ToString();
                    CreateChildNode(ref child, dv[i]["UserID"].ToString(), ds.Tables[0]);
                    tvUserInfo.Nodes.Add(child);
                }
            }
            tvUserInfo.ExpandAll();
        }
        private void CreateChildNode(ref  TreeNode child, string UserID, DataTable dt)
        {
            DataView dv = new DataView(dt);
            //通过DataView来过滤数据首先得到最顶层的菜单
            dv.RowFilter = "SupderID=" + UserID;
            for (int i = 0; i < dv.Count; i++)
            {
                TreeNode childr = new TreeNode(dv[i]["UserName"].ToString());
                childr.Tag = dv[i]["UserID"].ToString();
                child.Nodes.Add(childr);
            }
        }

        private void frmRunUser_Load(object sender, EventArgs e)
        {
            //
            cbRun.DataSource = new BLLRunNum().GetList("");
            cbRun.ValueMember = "RunID";
            cbRun.DisplayMember = "Name";
            //
            BindUserInfoDepartments();
            //
        }
        private void tvUserInfo_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {
                if (e.Node.Checked)
                {
                    //取消节点选中状态之后，取消所有父节点的选中状态
                    setChildNodeCheckedState(e.Node, true);
                }
                else
                {
                    //取消节点选中状态之后，取消所有父节点的选中状态
                    setChildNodeCheckedState(e.Node, false);
                    //如果节点存在父节点，取消父节点的选中状态
                    if (e.Node.Parent != null)
                    {
                        setParentNodeCheckedState(e.Node, false);
                    }
                }
            }
        }
        //取消节点选中状态之后，取消所有父节点的选中状态
        private void setParentNodeCheckedState(TreeNode currNode, bool state)
        {
            TreeNode parentNode = currNode.Parent;
            parentNode.Checked = state;
            if (currNode.Parent.Parent != null)
            {
                setParentNodeCheckedState(currNode.Parent, state);
            }
        }
        //选中节点之后，选中节点的所有子节点
        private void setChildNodeCheckedState(TreeNode currNode, bool state)
        {
            TreeNodeCollection nodes = currNode.Nodes;
            if (nodes.Count > 0)
                foreach (TreeNode tn in nodes)
                {

                    tn.Checked = state;
                    setChildNodeCheckedState(tn, state);
                }
        }
        private string GetSchclassInfo(string RunID)
        {
            StringBuilder sb = new StringBuilder();
            BLLRunNum CurBLLRunNum = new BLLRunNum();
            IList<Model.RunNumSchclass> result = CurBLLRunNum.GetRunNumSchclassList(string.Format(" AND RunID='{0}'", RunID));
            foreach (Model.RunNumSchclass model in result)
            {
                 sb.Append(string.Format("INSERT INTO #TempSchclass(SchclassID)VALUES('{0}');", model.SchclassID));
            }
            return sb.ToString();
        }
    }
}
