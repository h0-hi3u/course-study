using BusinessObjects.EntityModels;
using Microsoft.IdentityModel.Tokens;
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

namespace GroupStudyWinApp
{
    public partial class frmMyGroup : Form
    {
        IParticipantRepository participantRepo = new ParticipantRepository();
        IUserRepository userRepo = new UserRepository();
        IGroupRepository groupRepo = new GroupRepository();
        BindingSource source;
        //---------------------------------------------------
        public frmMyGroup()
        {
            InitializeComponent();
        }

        public User CurrentUser { get; set; }
        //---------------------------------------------------
        private void frmYourGroup_Load(object sender, EventArgs e)
        {
            LoadGroupList();
            if (!txtGroupId.Text.IsNullOrEmpty())
            {
                int joined = participantRepo.NumberStudentInGroup(Convert.ToInt32(txtGroupId.Text));
                txtJoined.Text = joined.ToString();
            }

        }
        //---------------------------------------------------
        public void ClearText()
        {
            txtGroupId.Text = string.Empty;
            txtSize.Text = string.Empty;
            txtStatus.Text = string.Empty;
            txtSubjectId.Text = string.Empty;
            txtJoined.Text = string.Empty;  
        }

        public void LoadGroupList()
        {
            var list = participantRepo.GetListByUserId(CurrentUser.UserId);
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtGroupId.DataBindings.Clear();
                txtSubjectId.DataBindings.Clear();
                txtSize.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtGroupId.DataBindings.Add("Text", source, "GroupId");
                txtSubjectId.DataBindings.Add("Text", source, "SubjectId");
                txtSize.DataBindings.Add("Text", source, "Size");
                txtStatus.DataBindings.Add("Text", source, "Status");

                dgvGroupList.DataSource = null;
                dgvGroupList.DataSource = source;

                dgvGroupList.Columns[4].Visible = false;
                dgvGroupList.Columns[5].Visible = false;
                dgvGroupList.Columns[6].Visible = false;
                dgvGroupList.Columns[7].Visible = false;

                if (list.Count() == 0)
                {
                    ClearText();
                    txtJoined.Text = string.Empty;
                    btnOut.Enabled = false;
                }
                else btnOut.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load list");
            }
        }
        //---------------------------------------------------
        private void btnOut_Click(object sender, EventArgs e)
        {
            Participant participant = new Participant
            {
                UserId = CurrentUser.UserId,
                GroupId = Convert.ToInt32(txtGroupId.Text),
            };

            DialogResult d = MessageBox.Show("Are you sure you want to out this group", "Notification"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                participantRepo.DeleteParticipant(participant);
                LoadGroupList();
            }
        }

        private void dgvGroupList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int joined = participantRepo.NumberStudentInGroup(Convert.ToInt32(txtGroupId.Text));
            txtJoined.Text = joined.ToString();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            frmGroupStudy f = new frmGroupStudy
            {
                CurrentGroup = groupRepo.Find(Convert.ToInt32(txtGroupId.Text)),
                CurrentUser = this.CurrentUser,
            };

            f.Show();
        }

        private void dgvGroupList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmGroupStudy f = new frmGroupStudy
            {
                CurrentGroup = groupRepo.Find(Convert.ToInt32(txtGroupId.Text)),
                CurrentUser = this.CurrentUser,
            };

            f.Show();
        }
    }
}
