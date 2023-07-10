using BusinessObjects.EntityModels;
using DataAccessObjects;
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
    public partial class frmUser : Form
    {
        IUserRepository repo = new UserRepository();
        BindingSource source;
        //-----------------------------------------------------
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            LoadUserList();
        }
        //-----------------------------------------------------
        // Clear text in textbox
        public void ClearText()
        {
            txtPwd.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtUserId.Text = string.Empty;
            txtRole.Text = string.Empty;
            dtpkBirthday.Text = string.Empty;
        }

        // Get object through textbox
        public User GetUserObject()
        {
            User user = null;
            try
            {
                IRoleRepository roleRepo = new RoleRepository();
                user = new User
                {
                    UserId = Convert.ToInt32(txtUserId.Text),
                    Username = txtUsername.Text,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    Password = txtPwd.Text,
                    RoleId = Convert.ToInt32(txtRole.Text),
                    Birthday = Convert.ToDateTime(dtpkBirthday.Text),
                    Role = roleRepo.GetRole(Convert.ToInt32(txtRole.Text))
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get user");
            }

            return user;
        }

        // Map list user to source 
        public void LoadUserList()
        {
            var list = repo.GetUsers().ToList();

            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtAddress.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPwd.DataBindings.Clear();
                txtRole.DataBindings.Clear();
                txtUserId.DataBindings.Clear();
                txtUsername.DataBindings.Clear();
                dtpkBirthday.DataBindings.Clear();

                txtAddress.DataBindings.Add("Text", source, "Address");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPwd.DataBindings.Add("Text", source, "Password"); ;
                txtRole.DataBindings.Add("Text", source, "RoleId");
                txtUserId.DataBindings.Add("Text", source, "UserId");
                txtUsername.DataBindings.Add("Text", source, "Username");
                dtpkBirthday.DataBindings.Add("Text", source, "Birthday"); ;

                dgvUserList.DataSource = null;
                dgvUserList.DataSource = source;

                dgvUserList.Columns[7].Visible = false;
                dgvUserList.Columns[8].Visible = false;
                dgvUserList.Columns[9].Visible = false;


                if (list.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load user list");
            }
        }

        //-----------------------------------------------------

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUserDetail f = new frmUserDetail
            {
                IsAdminOrUser = true,
                Repo = repo,
                UserInfo = GetUserObject(),
            };

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadUserList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var user = GetUserObject();
                DialogResult d = MessageBox.Show($"Are you sure you want to delete user \"{user.Username}\"", "Notification"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d == DialogResult.Yes)
                {
                    repo.Delete(user.UserId);
                    LoadUserList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete user");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to close", "Notification"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                Close();
            }
        }
        //-----------------------------------------------------

    }
}
