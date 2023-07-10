namespace GroupStudyWinApp
{
    partial class frmGroup
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
            lbfrmGroup = new Label();
            lbGroupID = new Label();
            lbSubjectID = new Label();
            dgvGroupList = new DataGridView();
            lbStatus = new Label();
            lbSize = new Label();
            btnClose = new Button();
            btnDelete = new Button();
            txtGroupID = new TextBox();
            txtSubjectID = new TextBox();
            txtSize = new TextBox();
            ckStatus = new CheckBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvGroupList).BeginInit();
            SuspendLayout();
            // 
            // lbfrmGroup
            // 
            lbfrmGroup.AutoSize = true;
            lbfrmGroup.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbfrmGroup.Location = new Point(229, 20);
            lbfrmGroup.Name = "lbfrmGroup";
            lbfrmGroup.Size = new Size(275, 37);
            lbfrmGroup.TabIndex = 0;
            lbfrmGroup.Text = "Group Management";
            // 
            // lbGroupID
            // 
            lbGroupID.AutoSize = true;
            lbGroupID.Location = new Point(35, 75);
            lbGroupID.Name = "lbGroupID";
            lbGroupID.Size = new Size(65, 20);
            lbGroupID.TabIndex = 1;
            lbGroupID.Text = "GroupID";
            // 
            // lbSubjectID
            // 
            lbSubjectID.AutoSize = true;
            lbSubjectID.Location = new Point(35, 116);
            lbSubjectID.Name = "lbSubjectID";
            lbSubjectID.Size = new Size(73, 20);
            lbSubjectID.TabIndex = 2;
            lbSubjectID.Text = "SubjectID";
            // 
            // dgvGroupList
            // 
            dgvGroupList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGroupList.Location = new Point(26, 214);
            dgvGroupList.Name = "dgvGroupList";
            dgvGroupList.RowHeadersWidth = 51;
            dgvGroupList.RowTemplate.Height = 29;
            dgvGroupList.Size = new Size(542, 217);
            dgvGroupList.TabIndex = 4;
            dgvGroupList.CellDoubleClick += dgvGroupList_CellDoubleClick;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(345, 116);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 6;
            lbStatus.Text = "Status";
            // 
            // lbSize
            // 
            lbSize.AutoSize = true;
            lbSize.Location = new Point(345, 75);
            lbSize.Name = "lbSize";
            lbSize.Size = new Size(36, 20);
            lbSize.TabIndex = 5;
            lbSize.Text = "Size";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(602, 403);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 102;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(602, 343);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 101;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtGroupID
            // 
            txtGroupID.BackColor = SystemColors.Control;
            txtGroupID.Location = new Point(122, 75);
            txtGroupID.Name = "txtGroupID";
            txtGroupID.ReadOnly = true;
            txtGroupID.Size = new Size(190, 27);
            txtGroupID.TabIndex = 103;
            // 
            // txtSubjectID
            // 
            txtSubjectID.BackColor = SystemColors.Control;
            txtSubjectID.Location = new Point(122, 116);
            txtSubjectID.Name = "txtSubjectID";
            txtSubjectID.ReadOnly = true;
            txtSubjectID.Size = new Size(190, 27);
            txtSubjectID.TabIndex = 104;
            // 
            // txtSize
            // 
            txtSize.BackColor = SystemColors.Control;
            txtSize.Location = new Point(418, 75);
            txtSize.Name = "txtSize";
            txtSize.ReadOnly = true;
            txtSize.Size = new Size(190, 27);
            txtSize.TabIndex = 105;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.Enabled = false;
            ckStatus.Location = new Point(418, 122);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(18, 17);
            ckStatus.TabIndex = 106;
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(601, 214);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 107;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(602, 278);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 108;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtSearch
            // 
            txtSearch.ForeColor = SystemColors.ControlDark;
            txtSearch.Location = new Point(26, 172);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(242, 27);
            txtSearch.TabIndex = 109;
            txtSearch.Text = "Search Subject here";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // frmGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 446);
            Controls.Add(txtSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(ckStatus);
            Controls.Add(txtSize);
            Controls.Add(txtSubjectID);
            Controls.Add(txtGroupID);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(lbStatus);
            Controls.Add(lbSize);
            Controls.Add(dgvGroupList);
            Controls.Add(lbSubjectID);
            Controls.Add(lbGroupID);
            Controls.Add(lbfrmGroup);
            Name = "frmGroup";
            Text = "frmGroup";
            Load += frmGroup_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGroupList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbfrmGroup;
        private Label lbGroupID;
        private Label lbSubjectID;
        private DataGridView dgvGroupList;
        private Label lbStatus;
        private Label lbSize;
        private Button btnSort;
        private Button btnClose;
        private Button btnDelete;
        private TextBox txtGroupID;
        private TextBox txtSubjectID;
        private TextBox txtSize;
        private CheckBox ckStatus;
        private Button btnAdd;
        private Button btnUpdate;
        private ComboBox cbOption;
        private TextBox txtSearch;
    }
}