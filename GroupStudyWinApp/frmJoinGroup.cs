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

namespace GroupStudyWinApp
{
    public partial class frmJoinGroup : Form
    {
        IParticipantRepository repoParticipant = new ParticipantRepository();
        IGroupRepository repoGroup = new GroupRepository();
        BindingSource source;
        //-------------------------------------------------
        public frmJoinGroup()
        {
            InitializeComponent();
        }
        public User CurrentUser { get; set; }
        //-------------------------------------------------
        private void ClearText()
        {
            txtGroupID.Text = string.Empty;
            txtSubjectID.Text = string.Empty;
            txtSize.Text = string.Empty;
            txtJoined.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }
        private Group GetCurrentGroup()
        {
            return new Group
            {
                GroupId = Convert.ToInt32(txtGroupID.Text),
                SubjectId = txtSubjectID.Text,
                Size = Convert.ToInt32(txtSize.Text),
                Status = Convert.ToBoolean(txtStatus.Text)
            };
        }
        private void LoadUnjoinedGroup()
        {
            List<Group> listGroups = (List<Group>)repoGroup.GetGroups();
            List<Participant> listP = repoParticipant.GetGroupsJoined(CurrentUser.UserId);
            foreach (var p in listP)
            {
                Group check = repoGroup.Find((int)p.GroupId);
                if (check != null)
                {
                    listGroups.Remove(check);
                }

            }
            try
            {
                source = new BindingSource();
                source.DataSource = listGroups;


                txtGroupID.DataBindings.Clear();
                txtSubjectID.DataBindings.Clear();
                txtSize.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtGroupID.DataBindings.Add("Text", source, "groupId");
                txtSubjectID.DataBindings.Add("Text", source, "subjectId");
                txtSize.DataBindings.Add("Text", source, "size");
                txtStatus.DataBindings.Add("Text", source, "status");

                dgvJoinGroup.DataSource = null;
                dgvJoinGroup.DataSource = source;

                dgvJoinGroup.Columns[4].Visible = false;
                dgvJoinGroup.Columns[5].Visible = false;
                dgvJoinGroup.Columns[6].Visible = false;
                dgvJoinGroup.Columns[7].Visible = false;

                if (listGroups.Count() == 0)
                {
                    ClearText();
                    btnJoin.Enabled = false;
                }
                else
                {
                    Group group = listGroups[0];
                    if (group != null)
                    {
                        int join = repoParticipant.NumberStudentInGroup(group.GroupId);
                        txtJoined.Text = join.ToString();
                    }
                    else
                    {
                        throw new Exception("Can not see joined");
                    }
                    btnJoin.Enabled = true;
                }
            }
            catch
            {
                throw new Exception("Load join group");
            }
        }
        //-------------------------------------------------

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmJoinGroup_Load(object sender, EventArgs e)
        {
            LoadUnjoinedGroup();
        }

        private void dgvJoinGroup_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Group group = GetCurrentGroup();
            if (group != null)
            {
                int join = repoParticipant.NumberStudentInGroup(group.GroupId);
                txtJoined.Text = join.ToString();
            }
            else
            {
                throw new Exception("Can not see joined");
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            Participant participant = new Participant
            {
                UserId = CurrentUser.UserId,
                GroupId = Convert.ToInt32(txtGroupID.Text),
                Status = 0,
            };

            repoParticipant.AddParticipant(participant);
            MessageBox.Show("Join successfully!", "Notification");
            LoadUnjoinedGroup();
        }
    }
}
