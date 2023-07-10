
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
    public partial class frmGroupUser : Form
    {
        IParticipantRepository participantRepository = new ParticipantRepository();
        IUserRepository userRepository = new UserRepository();
        BindingSource source;
        public int GroupId { get; set; }
        public frmGroupUser()
        {
            InitializeComponent();
        }

        private void frmGroupUser_Load(object sender, EventArgs e)
        {
            LoadUserList();
        }

        public void LoadUserList()
        {
            var list = participantRepository.GetListUserInGroup(GroupId);
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtAddress.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtRole.DataBindings.Clear();
                txtUserId.DataBindings.Clear();
                txtUsername.DataBindings.Clear();
                dtpkBirthday.DataBindings.Clear();

                txtAddress.DataBindings.Add("Text", source, "Address");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtRole.DataBindings.Add("Text", source, "RoleId");
                txtUserId.DataBindings.Add("Text", source, "UserId");
                txtUsername.DataBindings.Add("Text", source, "Username");
                dtpkBirthday.DataBindings.Add("Text", source, "Birthday"); ;

                dgvUserInGroup.DataSource = null;
                dgvUserInGroup.DataSource = source;

                dgvUserInGroup.Columns[7].Visible = false;
                dgvUserInGroup.Columns[8].Visible = false;
                dgvUserInGroup.Columns[9].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show($"Are you sure you want to delete", "Notification"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d == DialogResult.Yes)
                {
                    var participant = new Participant
                    {
                        UserId = int.Parse(txtUserId.Text),
                        GroupId = GroupId
                    };
                    participantRepository.DeleteParticipant(participant);
                    LoadUserList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete user");
            }
        }
    }
}
