namespace GroupStudyWinApp
{
    partial class frmGroupUser
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
            lbfrmUserInGroup = new Label();
            dgvUserInGroup = new DataGridView();
            btnDelete = new Button();
            btnClose = new Button();
            label8 = new Label();
            txtRole = new TextBox();
            dtpkBirthday = new DateTimePicker();
            txtAddress = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtUserId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            ID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUserInGroup).BeginInit();
            SuspendLayout();
            // 
            // lbfrmUserInGroup
            // 
            lbfrmUserInGroup.AutoSize = true;
            lbfrmUserInGroup.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbfrmUserInGroup.Location = new Point(297, 9);
            lbfrmUserInGroup.Name = "lbfrmUserInGroup";
            lbfrmUserInGroup.Size = new Size(194, 37);
            lbfrmUserInGroup.TabIndex = 1;
            lbfrmUserInGroup.Text = "User In Group";
            // 
            // dgvUserInGroup
            // 
            dgvUserInGroup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserInGroup.Location = new Point(18, 203);
            dgvUserInGroup.Name = "dgvUserInGroup";
            dgvUserInGroup.RowHeadersWidth = 51;
            dgvUserInGroup.RowTemplate.Height = 29;
            dgvUserInGroup.Size = new Size(513, 246);
            dgvUserInGroup.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(590, 258);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(590, 319);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(393, 100);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 50;
            label8.Text = "Role";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(489, 97);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(250, 27);
            txtRole.TabIndex = 49;
            // 
            // dtpkBirthday
            // 
            dtpkBirthday.Enabled = false;
            dtpkBirthday.Location = new Point(104, 128);
            dtpkBirthday.Name = "dtpkBirthday";
            dtpkBirthday.Size = new Size(250, 27);
            dtpkBirthday.TabIndex = 48;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(489, 130);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(393, 133);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 46;
            label7.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 133);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 45;
            label6.Text = "Birthday";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(104, 97);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 42;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(489, 64);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(250, 27);
            txtUsername.TabIndex = 41;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(104, 64);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(250, 27);
            txtUserId.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 67);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 39;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 100);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 38;
            label3.Text = "Email";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(18, 67);
            ID.Name = "ID";
            ID.Size = new Size(24, 20);
            ID.TabIndex = 37;
            ID.Text = "ID";
            // 
            // frmGroupUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 474);
            Controls.Add(label8);
            Controls.Add(txtRole);
            Controls.Add(dtpkBirthday);
            Controls.Add(txtAddress);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(txtUserId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ID);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(dgvUserInGroup);
            Controls.Add(lbfrmUserInGroup);
            Name = "frmGroupUser";
            Text = "frmGroupUser";
            Load += frmGroupUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUserInGroup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbfrmUserInGroup;
        private DataGridView dgvUserInGroup;
        private Button btnDelete;
        private Button btnClose;
        private Label label8;
        private TextBox txtRole;
        private DateTimePicker dtpkBirthday;
        private TextBox txtAddress;
        private Label label7;
        private Label label6;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtUserId;
        private Label label4;
        private Label label3;
        private Label ID;

    }
}