using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DAL;

namespace CHMS
{
    public class TreeViewManager
    {
        public TreeViewManager()
        {
        }

        public void BindTreeViewIsNotCheckBoxes(System.Windows.Forms.TreeView tvUserInfo)
        {
            tvUserInfo.Nodes.Clear();
            DataSet ds;
            tvUserInfo.CheckBoxes = false;
            ReturnValue rtn = new BLL.BLLAttLog().CreateUserInfoTree(out ds);
            if (rtn.Result == 1)
            {
                DataView dv = ds.Tables[0].DefaultView;
                //通过DataView来过滤数据首先得到最顶层的菜单
                dv.RowFilter = "SupderID=0";
                for (int i = 0; i < dv.Count; i++)
                {
                    TreeNode child = new TreeNode(dv[i]["UserName"].ToString());
                    child.Tag = dv[i]["UserID"].ToString()+"$";
                    CreateChildNode(ref child, dv[i]["UserID"].ToString(), ds.Tables[0]);
                    tvUserInfo.Nodes.Add(child);
                }
            }
            //tvUserInfo.ExpandAll();
        }

        public void BindTreeView(System.Windows.Forms.TreeView tvUserInfo)
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
            tvUserInfo.AfterCheck += new TreeViewEventHandler(tvUserInfo_AfterCheck);
            //tvUserInfo.ExpandAll();
        }

        public string GetCheckedNodes(System.Windows.Forms.TreeView tvUserInfo)
        {
            StringBuilder sb = new StringBuilder();
            foreach (TreeNode Root in tvUserInfo.Nodes)
            {
                foreach (TreeNode item in Root.Nodes)
                {
                    if (item.Checked)
                    {
                        sb.Append(string.Format("{0}$", item.Tag.ToString()));
                    }
                }
            }
            return sb.ToString();
        }

        public string GetCheckedNodesName(System.Windows.Forms.TreeView tvUserInfo)
        {
            StringBuilder sb = new StringBuilder();
            foreach (TreeNode Root in tvUserInfo.Nodes)
            {
                foreach (TreeNode item in Root.Nodes)
                {
                    if (item.Checked)
                    {
                        sb.Append(string.Format("{0}${1}&", item.Tag.ToString(),item.Text));
                    }
                }
            }
            return sb.ToString();
        }

        public string GetCheckedValues(System.Windows.Forms.TreeView tvUserInfo)
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
            return sb.ToString();
        }
        void CreateChildNode(ref  TreeNode child, string UserID, DataTable dt)
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
        void tvUserInfo_AfterCheck(object sender, TreeViewEventArgs e)
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
        void setParentNodeCheckedState(TreeNode currNode, bool state)
        {
            TreeNode parentNode = currNode.Parent;
            parentNode.Checked = state;
            if (currNode.Parent.Parent != null)
            {
                setParentNodeCheckedState(currNode.Parent, state);
            }
        }
        //选中节点之后，选中节点的所有子节点
        void setChildNodeCheckedState(TreeNode currNode, bool state)
        {
            TreeNodeCollection nodes = currNode.Nodes;
            if (nodes.Count > 0)
                foreach (TreeNode tn in nodes)
                {
                    tn.Checked = state;
                    setChildNodeCheckedState(tn, state);
                }
        }
    }
}
