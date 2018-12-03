using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CHMS
{
    public enum SelectionType
    {
        清空,
        反选,
        全选,
    }
    [ProvideProperty("SelectionSource", typeof(Control))]
    [ProvideProperty("SelectionType", typeof(Control))]
    public partial class FastSelect : Component, IExtenderProvider
    {
        private Dictionary<Control, Control> sourceControlsDict;

        private Dictionary<Control, SelectionType> typeDict;

        public FastSelect() : this(null) { }

        public FastSelect(IContainer container)
        {
            InitializeComponent();

            if (container != null) container.Add(this);

            sourceControlsDict = new Dictionary<Control, Control>();
            typeDict = new Dictionary<Control, SelectionType>();
        }

        #region IExtenderProvider 成员

        public bool CanExtend(object extendee)
        {
            if (extendee == null) return false;
            if (extendee is Button || extendee is Label || extendee is PictureBox) return true;
            return false;
        }

        #endregion

        #region CollectionControl
        [Category("速选"), Description("速选源控件"), Localizable(true)]
        public Control GetSelectionSource(Control control)
        {
            if (sourceControlsDict.ContainsKey(control)) return sourceControlsDict[control];
            else return null;
        }

        public void SetSelectionSource(Control control, Control selectionSource)
        {
            if (selectionSource != null)
            {
                if (sourceControlsDict.ContainsKey(control) && sourceControlsDict[control] != selectionSource)
                    SetSelectionSource(control, null);
                sourceControlsDict.Add(control, selectionSource);
                typeDict.Add(control, SelectionType.清空);
                control.Click += new EventHandler(control_Click);
            }
            else
            {
                sourceControlsDict.Remove(control);
                typeDict.Remove(control);
                control.Click -= new EventHandler(control_Click);
            }
        }
        #endregion


        #region SelectType
        [Category("速选"), Description("速选方式"), DefaultValue(SelectionType.清空), Localizable(true)]
        public SelectionType GetSelectionType(Control control)
        {
            if (typeDict.ContainsKey(control))
                return typeDict[control];
            else
                return SelectionType.清空;
        }

        public void SetSelectionType(Control control, SelectionType selectionType)
        {
            if (typeDict.ContainsKey(control))
                typeDict[control] = selectionType;
            else
                typeDict.Add(control, selectionType);
        }
        #endregion

        void control_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;
            Control selectionSource = sourceControlsDict[control];
            SelectionType selectType = typeDict[control];

            if (selectionSource is DataGridView)
            {
                DataGridView dataGridView = selectionSource as DataGridView;
                foreach (DataGridViewRow row in dataGridView.Rows)
                    row.Selected = ChangeSelected(row.Selected, selectType);
            }
            else if (selectionSource is CheckedListBox)
            {
                CheckedListBox checkedListBox = selectionSource as CheckedListBox;
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    bool _selected = checkedListBox.GetItemChecked(i);
                    _selected = ChangeSelected(_selected, selectType);
                    checkedListBox.SetItemChecked(i, _selected);
                    checkedListBox.SetSelected(i, _selected);
                }
            }
            else if (selectionSource is TreeView)
            {
                TreeView treeView = selectionSource as TreeView;
                foreach (TreeNode treeNode in GetTreeNodes(treeView))
                {
                    treeNode.Checked = ChangeSelected(treeNode.Checked, selectType);                   
                }
            }
            else if (selectionSource.Controls.Count > 0)
            {
                foreach (Control subControl in selectionSource.Controls)
                {
                    if (subControl is CheckBox)
                    {
                        CheckBox checkBox = subControl as CheckBox;
                        checkBox.Checked = ChangeSelected(checkBox.Checked, selectType);
                    }
                }
            }
        }

        private bool ChangeSelected(bool isSelected, SelectionType type)
        {
            if (type == SelectionType.清空) return false;
            else if (type == SelectionType.全选) return true;
            else if (type == SelectionType.反选) return !isSelected;
            else throw new NotImplementedException();
        }

        #region 获取TreeView节点

        private IEnumerable<TreeNode> GetTreeNodes(TreeView view)
        {
            foreach (TreeNode node in view.Nodes)
            {
                yield return node;
                foreach (TreeNode subNode in GetTreeNodes(node))
                    yield return subNode;
            }
        }

        private IEnumerable<TreeNode> GetTreeNodes(TreeNode treeNode)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                yield return node;
                foreach (TreeNode subNode in GetTreeNodes(node))
                    yield return subNode;
            }
        }
        #endregion
    }
}
