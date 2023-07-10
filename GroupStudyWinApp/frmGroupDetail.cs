using BusinessObjects.EntityModels;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GroupStudyWinApp
{
    public partial class frmGroupDetail : Form
    {
        public frmGroupDetail()
        {
            InitializeComponent();
        }

        public IGroupRepository groupRepository { get; set; }
        public bool AddOrUpdate { get; set; }
        public Group GroupInfo { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                Group group = new Group
                {
                    GroupId = GroupInfo.GroupId,
                    SubjectId = cbSubjectID.SelectedValue.ToString(),
                    Size = int.Parse(txtSize.Text),
                    Status = ckStatus.Checked ? true : false
                };
                if (string.IsNullOrEmpty(txtSize.Text))
                {
                    MessageBox.Show("Size is required");
                }
                else
                {
                    if (AddOrUpdate)
                    {
                        groupRepository.Add(group);
                        MessageBox.Show("Add successfully!", "Notification");
                    }
                    else
                    {
                        groupRepository.Update(group);
                        if (MessageBox.Show("Update successfully!", "Notification", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AddOrUpdate ? "Add Fail" : "Update Fail");
            }
        }

        private void frmGroupDetail_Load(object sender, EventArgs e)
        {
            LoadSubjectId();
            if (AddOrUpdate)
            {
                cbSubjectID.SelectedIndex = 0;
            }
            else
            {
                lbSubjectID.Hide();
                cbSubjectID.Hide();
            }
            txtSize.Text = GroupInfo.Size.ToString();
            ckStatus.Checked = GroupInfo.Status == true ? true : false;
        }

        public void LoadSubjectId()
        {
            try
            {
                var subjectList = groupRepository.GetSubjects();
                cbSubjectID.DataSource = subjectList;
                cbSubjectID.DisplayMember = "SubjectId";
                cbSubjectID.ValueMember = "SubjectId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of SubjectId");
            }
        }
    }
}
