namespace GroupStudyWinApp
{
    partial class frmUserDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClose = new Button();
            dtpkBirthday = new DateTimePicker();
            btnSave = new Button();
            txtAddress = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            txtId = new TextBox();
            lbRole = new Label();
            cboRole = new ComboBox();
            txtRole = new TextBox();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(504, 358);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 27;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dtpkBirthday
            // 
            dtpkBirthday.Location = new Point(348, 223);
            dtpkBirthday.Name = "dtpkBirthday";
            dtpkBirthday.Size = new Size(250, 27);
            dtpkBirthday.TabIndex = 23;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(348, 358);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(348, 269);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 25;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(348, 181);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(348, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 17;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(348, 103);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 27);
            txtUsername.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(203, 272);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 24;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 228);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 22;
            label4.Text = "Birthday *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 144);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 20;
            label3.Text = "Email *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 184);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 18;
            label2.Text = "Password *";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 106);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 16;
            label1.Text = "Username *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(348, 9);
            label7.Name = "label7";
            label7.Size = new Size(138, 50);
            label7.TabIndex = 29;
            label7.Text = "Profile";
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 411);
            txtId.Name = "txtId";
            txtId.Size = new Size(35, 27);
            txtId.TabIndex = 30;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new Point(203, 315);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(39, 20);
            lbRole.TabIndex = 31;
            lbRole.Text = "Role";
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(348, 312);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(250, 28);
            cboRole.TabIndex = 32;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(348, 312);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(250, 27);
            txtRole.TabIndex = 33;
            // 
            // frmUserDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRole);
            Controls.Add(cboRole);
            Controls.Add(lbRole);
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(btnClose);
            Controls.Add(dtpkBirthday);
            Controls.Add(btnSave);
            Controls.Add(txtAddress);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUserDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Detail";
            Load += frmUserDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private DateTimePicker dtpkBirthday;
        private Button btnSave;
        private TextBox txtAddress;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox txtId;
        private Label lbRole;
        private ComboBox cboRole;
        private TextBox txtRole;
    }
}