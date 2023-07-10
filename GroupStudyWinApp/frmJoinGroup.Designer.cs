namespace GroupStudyWinApp
{
    partial class frmJoinGroup
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtGroupID = new TextBox();
            txtSubjectID = new TextBox();
            txtJoined = new TextBox();
            txtSize = new TextBox();
            txtStatus = new TextBox();
            dgvJoinGroup = new DataGridView();
            btnJoin = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJoinGroup).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(257, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 46);
            label1.TabIndex = 1;
            label1.Text = "Join Group";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 85);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "GroupID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 129);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 3;
            label3.Text = "Size";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 181);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 4;
            label4.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(361, 85);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 5;
            label5.Text = "SubjectID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(361, 129);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 6;
            label6.Text = "Joined";
            // 
            // txtGroupID
            // 
            txtGroupID.Location = new Point(155, 82);
            txtGroupID.Name = "txtGroupID";
            txtGroupID.ReadOnly = true;
            txtGroupID.Size = new Size(147, 27);
            txtGroupID.TabIndex = 7;
            // 
            // txtSubjectID
            // 
            txtSubjectID.Location = new Point(452, 82);
            txtSubjectID.Name = "txtSubjectID";
            txtSubjectID.ReadOnly = true;
            txtSubjectID.Size = new Size(147, 27);
            txtSubjectID.TabIndex = 8;
            // 
            // txtJoined
            // 
            txtJoined.Location = new Point(452, 129);
            txtJoined.Name = "txtJoined";
            txtJoined.ReadOnly = true;
            txtJoined.Size = new Size(147, 27);
            txtJoined.TabIndex = 9;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(155, 126);
            txtSize.Name = "txtSize";
            txtSize.ReadOnly = true;
            txtSize.Size = new Size(147, 27);
            txtSize.TabIndex = 10;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(155, 178);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(147, 27);
            txtStatus.TabIndex = 11;
            // 
            // dgvJoinGroup
            // 
            dgvJoinGroup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJoinGroup.Location = new Point(73, 250);
            dgvJoinGroup.Name = "dgvJoinGroup";
            dgvJoinGroup.RowHeadersWidth = 51;
            dgvJoinGroup.RowTemplate.Height = 29;
            dgvJoinGroup.Size = new Size(472, 188);
            dgvJoinGroup.TabIndex = 12;
            dgvJoinGroup.CellMouseClick += dgvJoinGroup_CellMouseClick;
            // 
            // btnJoin
            // 
            btnJoin.Location = new Point(551, 330);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(94, 29);
            btnJoin.TabIndex = 14;
            btnJoin.Text = "Join";
            btnJoin.UseVisualStyleBackColor = true;
            btnJoin.Click += btnJoin_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(551, 409);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmJoinGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 450);
            Controls.Add(btnClose);
            Controls.Add(btnJoin);
            Controls.Add(dgvJoinGroup);
            Controls.Add(txtStatus);
            Controls.Add(txtSize);
            Controls.Add(txtJoined);
            Controls.Add(txtSubjectID);
            Controls.Add(txtGroupID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmJoinGroup";
            Text = "Join Group";
            Load += frmJoinGroup_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJoinGroup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtGroupID;
        private TextBox txtSubjectID;
        private TextBox txtJoined;
        private TextBox txtSize;
        private TextBox txtStatus;
        private DataGridView dgvJoinGroup;
        private Button btnJoin;
        private Button btnClose;
    }
}