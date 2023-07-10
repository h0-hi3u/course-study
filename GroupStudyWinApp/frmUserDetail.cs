using BusinessObjects.EntityModels;
using Microsoft.IdentityModel.Tokens;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupStudyWinApp
{
    public partial class frmUserDetail : Form
    {
        IRoleRepository roleRepo = new RoleRepository();
        public event EventHandler DialogOk;
        public frmUserDetail()
        {
            InitializeComponent();
        }

        //-------------------------------------------
        public bool IsAdminOrUser { get; set; }
        public User UserInfo { get; set; }
        public IUserRepository Repo { get; set; }
        //-------------------------------------------
        private void frmUserDetail_Load(object sender, EventArgs e)
        {
            txtId.Visible = false;
            txtId.Text = UserInfo.UserId.ToString();
            txtUsername.Text = UserInfo.Username;
            txtPassword.Text = UserInfo.Password;
            txtEmail.Text = UserInfo.Email;
            txtAddress.Text = UserInfo.Address;
            dtpkBirthday.Text = UserInfo.Birthday.ToString();

            if (!IsAdminOrUser)
            {
                cboRole.Visible = false;
                txtRole.Text = UserInfo.Role.RoleName;
                txtRole.ReadOnly = true;
            }
            else
            {
                txtRole.Visible = false;
                cboRole.DataSource = roleRepo.GetRoles().Select(x => x.RoleName).ToList();
                cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
                cboRole.Text = UserInfo.Role.RoleName;
            }
        }

        //-------------------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to close", "Notification",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = null;

            try
            {
                bool isEmailValid = txtEmail.Text == "" ? false : true;
                bool isUsernameValid = txtUsername.Text == "" ? false : true;
                bool isPasswordValid = txtPassword.Text == "" ? false : true;
                bool isAgeValid = DateTime.Now.Year - dtpkBirthday.Value.Year >= 10 ? true : false;

                if (isEmailValid && isUsernameValid && isPasswordValid)
                {
                    if (isAgeValid)
                    {
                        try
                        {
                            int role = 0;
                            if (cboRole.Text == "Admin") role = 1;
                            else role = 2;

                            user = new User
                            {
                                UserId = Convert.ToInt32(txtId.Text),
                                Username = txtUsername.Text,
                                Password = txtPassword.Text,
                                Email = txtEmail.Text,
                                Address = txtAddress.Text,
                                Birthday = Convert.ToDateTime(dtpkBirthday.Text),
                                RoleId = role,
                            };

                            Repo.Update(user);
                            MessageBox.Show("Update successfully", "Notification");
                            DialogOk?.Invoke(this, EventArgs.Empty);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Resgister");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must be at least 10 years old!", "Warning");
                    }
                }
                else MessageBox.Show("Please fill in all the necessary fields!", "Warning");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
        }
        //-------------------------------------------

    }
}
