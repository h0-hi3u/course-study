using Repositories;

namespace GroupStudyWinApp
{
    public partial class frmLogin : Form
    {
        IUserRepository repo = new UserRepository();

        //------------------------------------------
        public frmLogin()
        {
            InitializeComponent();
        }

        //------------------------------------------
        //Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isEmailValid = txtEmail.Text == "" ? false : true;
            bool isPwdValid = txtPassword.Text == "" ? false : true;

            if (!isEmailValid && !isPwdValid) MessageBox.Show("Please fill in the fields!", "Warning");
            else if (isPwdValid && !isEmailValid) MessageBox.Show("Please fill in email!", "Warning");
            else if (isEmailValid && !isPwdValid) MessageBox.Show("Please fill in password!", "Warning");
            else
            {
                var cus = repo.GetUsers().FirstOrDefault(x => x.Email == txtEmail.Text && x.Password == txtPassword.Text);
                if (cus == null)
                {
                    MessageBox.Show("Incorrect email or password!", "Warning");
                    return;
                }
                else
                {
                    if (cus.RoleId == 1)
                    {
                        frmMain f = new frmMain
                        {
                            IsAdminOrStudent = true,
                            CurrentUser = cus,
                            Repo = repo,
                        };

                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        frmMain f = new frmMain
                        {
                            IsAdminOrStudent = false,
                            CurrentUser = cus,
                            Repo = repo,
                        };

                        f.Show();
                        this.Hide();
                    }
                }
            }
        }

        // Register account
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister f = new frmRegister();

            f.Show();
            this.Hide();
        }
        //------------------------------------------
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "admin@gmail.com";
            txtPassword.Text = "1";
        }

    }
}