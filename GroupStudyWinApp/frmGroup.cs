using BusinessObjects.EntityModels;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GroupStudyWinApp
{
    public partial class frmGroup : Form
    {
        IGroupRepository repo = new GroupRepository();
        BindingSource source;
        public frmGroup()
        {
            InitializeComponent();
        }

        private void frmGroup_Load(object sender, EventArgs e)
        {
            LoadGroupList();
        }
        private void LoadGroupList()
        {
            var list = repo.GetGroups();
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtGroupID.DataBindings.Clear();
                txtSubjectID.DataBindings.Clear();
                txtSize.DataBindings.Clear();
                ckStatus.DataBindings.Clear();

                txtGroupID.DataBindings.Add("Text", source, "GroupId");
                txtSubjectID.DataBindings.Add("Text", source, "SubjectId");
                txtSize.DataBindings.Add("Text", source, "Size");
                ckStatus.DataBindings.Add("Checked", source, "Status", true, DataSourceUpdateMode.OnPropertyChanged);

                dgvGroupList.DataSource = null;
                dgvGroupList.DataSource = source;

                dgvGroupList.Columns[4].Visible = false;
                dgvGroupList.Columns[5].Visible = false;
                dgvGroupList.Columns[6].Visible = false;
                dgvGroupList.Columns[7].Visible = false;
                if (list.Count() == 0)
                {
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadGroupList(IEnumerable<Group> list)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtGroupID.DataBindings.Clear();
                txtSubjectID.DataBindings.Clear();
                txtSize.DataBindings.Clear();
                ckStatus.DataBindings.Clear();

                txtGroupID.DataBindings.Add("Text", source, "GroupId");
                txtSubjectID.DataBindings.Add("Text", source, "SubjectId");
                txtSize.DataBindings.Add("Text", source, "Size");
                ckStatus.DataBindings.Add("Checked", source, "Status", true, DataSourceUpdateMode.OnPropertyChanged);

                dgvGroupList.DataSource = null;
                dgvGroupList.DataSource = source;

                if (list.Count() == 0)
                {
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "FlowerBouquet Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                repo.Delete(int.Parse(txtGroupID.Text));
                LoadGroupList();
            }
        }
        private void btnClose_Click(object sender, EventArgs e) => Close();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmGroupDetail f = new frmGroupDetail
            {
                Text = "Add group",
                groupRepository = repo,
                AddOrUpdate = true,
                GroupInfo = new Group()
            };

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadGroupList();
                source.Position = source.Count - 1;
            }
            LoadGroupList();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Group group = new Group
            {
                GroupId = int.Parse(txtGroupID.Text),
                SubjectId = txtSubjectID.Text,
                Size = int.Parse(txtSize.Text),
                Status = ckStatus.Checked ? true : false
            };
            frmGroupDetail f = new frmGroupDetail
            {
                Text = "Update group",
                groupRepository = repo,
                AddOrUpdate = false,
                GroupInfo = group
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadGroupList();
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<Group> ListSearch;
            if (txtSearch.Text == null || txtSearch.Text == "Search Subject here")
            {
                ListSearch = repo.GetGroups();
            }
            else
            {
                ListSearch = repo.GetGroups().Where(gr => gr.SubjectId.ToUpper().Contains(txtSearch.Text.ToUpper())).ToList();
            }
            LoadGroupList(ListSearch);
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Subject here")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search Subject here";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void dgvGroupList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmGroupUser f = new frmGroupUser
            {
                GroupId = int.Parse(txtGroupID.Text)
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadGroupList();
            }
        }

    }
}
