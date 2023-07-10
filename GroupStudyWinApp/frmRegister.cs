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
    public partial class frmRegister : Form
    {
        IUserRepository repo = new UserRepository();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
        //------------------------------------------------------

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            dtpkBirthday.Text = string.Empty;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool isPasswordConfirm = txtPassword.Text == txtConfirmPassword.Text ? true : false;
            bool isEmailValid = txtEmail.Text == "" ? false : true;
            bool isUsernameValid = txtUsername.Text == "" ? false : true;
            bool isPasswordValid = txtPassword.Text == "" ? false : true;
            bool isPasswordConfirmValid = txtConfirmPassword.Text == "" ? false : true;
            bool isAgeValid = DateTime.Now.Year - dtpkBirthday.Value.Year >= 10 ? true : false;

            if (isEmailValid && isUsernameValid && isPasswordValid && isPasswordConfirmValid)
            {
                if (isPasswordConfirm)
                {
                    if (isAgeValid)
                    {
                        try
                        {
                            User user = new User
                            {
                                Username = txtUsername.Text,
                                Email = txtEmail.Text,
                                Password = txtPassword.Text,
                                Birthday = Convert.ToDateTime(dtpkBirthday.Text),
                                RoleId = 2,
                            };

                            repo.AddNew(user);
                            MessageBox.Show("Create successfully", "Notification");

                            // Open login form
                            frmLogin f = new frmLogin();
                            f.Show();
                            this.Hide();
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
                else MessageBox.Show("Password confirm is not match!", "Warning");
            }
            else MessageBox.Show("Please fill in all the necessary fields!", "Warning");


        }

        //------------------------------------------------------
    }
}
