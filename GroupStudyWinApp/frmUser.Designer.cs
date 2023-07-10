namespace GroupStudyWinApp
{
    partial class frmUser
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
            btnDelete = new Button();
            dgvUserList = new DataGridView();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtUserId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            ID = new Label();
            label1 = new Label();
            txtPwd = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtAddress = new TextBox();
            label7 = new Label();
            dtpkBirthday = new DateTimePicker();
            txtRole = new TextBox();
            label8 = new Label();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUserList).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(694, 385);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 23;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(694, 338);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvUserList
            // 
            dgvUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserList.Location = new Point(45, 267);
            dgvUserList.Name = "dgvUserList";
            dgvUserList.RowHeadersWidth = 51;
            dgvUserList.RowTemplate.Height = 29;
            dgvUserList.Size = new Size(627, 171);
            dgvUserList.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Control;
            txtEmail.Location = new Point(124, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 18;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.Location = new Point(509, 84);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(250, 27);
            txtUsername.TabIndex = 17;
            // 
            // txtUserId
            // 
            txtUserId.BackColor = SystemColors.Control;
            txtUserId.Location = new Point(124, 84);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(250, 27);
            txtUserId.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 87);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 15;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 131);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 14;
            label3.Text = "Email";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(38, 87);
            ID.Name = "ID";
            ID.Size = new Size(24, 20);
            ID.TabIndex = 13;
            ID.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(263, 9);
            label1.Name = "label1";
            label1.Size = new Size(313, 46);
            label1.TabIndex = 12;
            label1.Text = "User Management";
            // 
            // txtPwd
            // 
            txtPwd.BackColor = SystemColors.Control;
            txtPwd.Location = new Point(509, 128);
            txtPwd.Name = "txtPwd";
            txtPwd.ReadOnly = true;
            txtPwd.Size = new Size(250, 27);
            txtPwd.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(413, 131);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 24;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 176);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 26;
            label6.Text = "Birthday";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Control;
            txtAddress.Location = new Point(509, 173);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(413, 176);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 28;
            label7.Text = "Address";
            // 
            // dtpkBirthday
            // 
            dtpkBirthday.Enabled = false;
            dtpkBirthday.Location = new Point(124, 175);
            dtpkBirthday.Name = "dtpkBirthday";
            dtpkBirthday.Size = new Size(250, 27);
            dtpkBirthday.TabIndex = 30;
            // 
            // txtRole
            // 
            txtRole.BackColor = SystemColors.Control;
            txtRole.Location = new Point(124, 219);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(250, 27);
            txtRole.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 222);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 36;
            label8.Text = "Role";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(694, 290);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(label8);
            Controls.Add(txtRole);
            Controls.Add(dtpkBirthday);
            Controls.Add(txtAddress);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtPwd);
            Controls.Add(label5);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(dgvUserList);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(txtUserId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ID);
            Controls.Add(label1);
            Name = "frmUser";
            Text = "Manage User";
            Load += frmUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUserList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnDelete;
        private DataGridView dgvUserList;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtUserId;
        private Label label4;
        private Label label3;
        private Label ID;
        private Label label1;
        private TextBox txtPwd;
        private Label label5;
        private Label label6;
        private TextBox txtAddress;
        private Label label7;
        private DateTimePicker dtpkBirthday;
        private TextBox txtRole;
        private Label label8;
        private Button btnUpdate;
    }
}