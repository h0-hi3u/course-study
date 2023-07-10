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
using System.Windows.Forms.VisualStyles;

namespace GroupStudyWinApp
{
    public partial class frmParticipant : Form
    {
        IParticipantRepository repoParticipant = new ParticipantRepository();
        IGroupRepository repoGroup = new GroupRepository();
        ISlotRepository slotRepo = new SlotRepository();
        IProgressRepository progressRepo = new ProgressRepository();
        //-------------------------------------------------
        public frmParticipant()
        {
            InitializeComponent();
        }

        private void frmParticipant_Load(object sender, EventArgs e)
        {
            LoadGroup();
        }
        //-------------------------------------------------
        private void LoadGroup()
        {
            var groups = repoGroup.GetGroups();
            try
            {
                dgvGroup.DataSource = null;
                dgvGroup.DataSource = groups;

                dgvGroup.Columns[4].Visible = false;
                dgvGroup.Columns[5].Visible = false;
                dgvGroup.Columns[6].Visible = false;
                dgvGroup.Columns[7].Visible = false;
            }
            catch
            {
                throw new Exception("Load group in manage participant");
            }
        }
        private void LoadParticipantPending(int groupID, int status)
        {
            List<Participant> listParticipants = repoParticipant.GetParticipantsInGroupPending(groupID, status);
            try
            {
                dgvPending.DataSource = null;
                dgvPending.DataSource = listParticipants;

                dgvPending.Columns[3].Visible = false;
                dgvPending.Columns[4].Visible = false;
            }
            catch
            {
                throw new Exception("Load pending in manage participant");
            }
        }
        private void LoadParticipantAccepted(int groupID, int status)
        {
            List<Participant> listParticipants = repoParticipant.GetParticipantsInGroupAccepted(groupID, status);
            try
            {
                dgvAccepted.DataSource = null;
                dgvAccepted.DataSource = listParticipants;

                dgvAccepted.Columns[3].Visible = false;
                dgvAccepted.Columns[4].Visible = false;
            }
            catch
            {
                throw new Exception("Load accepted in manage participant");
            }
        }
        //-------------------------------------------------

        private void dgvGroup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int groupID = Convert.ToInt32(dgvGroup.CurrentRow.Cells[0].Value);
            LoadParticipantPending(groupID, 0);
            LoadParticipantAccepted(groupID, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(dgvPending.CurrentRow.Cells[0].Value);
            int groupID = Convert.ToInt32(dgvPending.CurrentRow.Cells[1].Value);
            repoParticipant.UpdateParticipant(userID, groupID, 1);
            // Add progress for user
            var list = slotRepo.GetSlotsByGroupId(groupID).ToList();
            var listProgress = progressRepo.GetProgressesByUserInGroup(userID, groupID);
            // if user havent joined this group before, add progress
            if (listProgress.Count == 0) progressRepo.AddRange(userID, list);
            

            LoadParticipantPending(groupID, 0);
            LoadParticipantAccepted(groupID, 0);
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(dgvAccepted.CurrentRow.Cells[0].Value);
            int groupID = Convert.ToInt32(dgvAccepted.CurrentRow.Cells[1].Value);
            repoParticipant.UpdateParticipant(userID, groupID, 2);
            LoadParticipantPending(groupID, 0);
            LoadParticipantAccepted(groupID, 0);
        }

        private void btnUnban_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(dgvAccepted.CurrentRow.Cells[0].Value);
            int groupID = Convert.ToInt32(dgvAccepted.CurrentRow.Cells[1].Value);
            repoParticipant.UpdateParticipant(userID, groupID, 1);
            LoadParticipantPending(groupID, 0);
            LoadParticipantAccepted(groupID, 0);
        }
    }
}
