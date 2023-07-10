namespace GroupStudyWinApp
{
    partial class frmSlot
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
            txtSearch = new TextBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            ckStatus = new CheckBox();
            txtSlotIndex = new TextBox();
            txtSlotID = new TextBox();
            txtGroupID = new TextBox();
            btnClose = new Button();
            btnDelete = new Button();
            lbStatus = new Label();
            lbSlotIndex = new Label();
            dgvSlotList = new DataGridView();
            lbSlotID = new Label();
            lbGroupID = new Label();
            lbfrmSlot = new Label();
            txtSlotName = new TextBox();
            lbSlotName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSlotList).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.ForeColor = SystemColors.ControlDark;
            txtSearch.Location = new Point(38, 157);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(242, 27);
            txtSearch.TabIndex = 125;
            txtSearch.Text = "Search Name here";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(611, 248);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 124;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(611, 199);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 123;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.Enabled = false;
            ckStatus.Location = new Point(421, 151);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(18, 17);
            ckStatus.TabIndex = 122;
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // txtSlotIndex
            // 
            txtSlotIndex.BackColor = SystemColors.Control;
            txtSlotIndex.Location = new Point(421, 60);
            txtSlotIndex.Name = "txtSlotIndex";
            txtSlotIndex.ReadOnly = true;
            txtSlotIndex.Size = new Size(190, 27);
            txtSlotIndex.TabIndex = 121;
            // 
            // txtSlotID
            // 
            txtSlotID.BackColor = SystemColors.Control;
            txtSlotID.Location = new Point(134, 60);
            txtSlotID.Name = "txtSlotID";
            txtSlotID.ReadOnly = true;
            txtSlotID.Size = new Size(190, 27);
            txtSlotID.TabIndex = 120;
            // 
            // txtGroupID
            // 
            txtGroupID.BackColor = SystemColors.Control;
            txtGroupID.Location = new Point(134, 101);
            txtGroupID.Name = "txtGroupID";
            txtGroupID.ReadOnly = true;
            txtGroupID.Size = new Size(190, 27);
            txtGroupID.TabIndex = 119;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(611, 339);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 118;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(611, 293);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 117;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(357, 145);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 115;
            lbStatus.Text = "Status";
            // 
            // lbSlotIndex
            // 
            lbSlotIndex.AutoSize = true;
            lbSlotIndex.Location = new Point(357, 60);
            lbSlotIndex.Name = "lbSlotIndex";
            lbSlotIndex.Size = new Size(45, 20);
            lbSlotIndex.TabIndex = 114;
            lbSlotIndex.Text = "Index";
            // 
            // dgvSlotList
            // 
            dgvSlotList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSlotList.Location = new Point(38, 199);
            dgvSlotList.Name = "dgvSlotList";
            dgvSlotList.RowHeadersWidth = 51;
            dgvSlotList.RowTemplate.Height = 29;
            dgvSlotList.Size = new Size(542, 217);
            dgvSlotList.TabIndex = 113;
            // 
            // lbSlotID
            // 
            lbSlotID.AutoSize = true;
            lbSlotID.Location = new Point(47, 60);
            lbSlotID.Name = "lbSlotID";
            lbSlotID.Size = new Size(50, 20);
            lbSlotID.TabIndex = 112;
            lbSlotID.Text = "SlotID";
            // 
            // lbGroupID
            // 
            lbGroupID.AutoSize = true;
            lbGroupID.Location = new Point(47, 101);
            lbGroupID.Name = "lbGroupID";
            lbGroupID.Size = new Size(65, 20);
            lbGroupID.TabIndex = 111;
            lbGroupID.Text = "GroupID";
            // 
            // lbfrmSlot
            // 
            lbfrmSlot.AutoSize = true;
            lbfrmSlot.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbfrmSlot.Location = new Point(244, 5);
            lbfrmSlot.Name = "lbfrmSlot";
            lbfrmSlot.Size = new Size(246, 37);
            lbfrmSlot.TabIndex = 110;
            lbfrmSlot.Text = "Slot Management";
            // 
            // txtSlotName
            // 
            txtSlotName.BackColor = SystemColors.Control;
            txtSlotName.Location = new Point(421, 101);
            txtSlotName.Name = "txtSlotName";
            txtSlotName.ReadOnly = true;
            txtSlotName.Size = new Size(190, 27);
            txtSlotName.TabIndex = 127;
            // 
            // lbSlotName
            // 
            lbSlotName.AutoSize = true;
            lbSlotName.Location = new Point(357, 101);
            lbSlotName.Name = "lbSlotName";
            lbSlotName.Size = new Size(49, 20);
            lbSlotName.TabIndex = 126;
            lbSlotName.Text = "Name";
            // 
            // frmSlot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 436);
            Controls.Add(txtSlotName);
            Controls.Add(lbSlotName);
            Controls.Add(txtSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(ckStatus);
            Controls.Add(txtSlotIndex);
            Controls.Add(txtSlotID);
            Controls.Add(txtGroupID);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(lbStatus);
            Controls.Add(lbSlotIndex);
            Controls.Add(dgvSlotList);
            Controls.Add(lbSlotID);
            Controls.Add(lbGroupID);
            Controls.Add(lbfrmSlot);
            Name = "frmSlot";
            Text = "frmSlot";
            Load += frmSlot_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSlotList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnUpdate;
        private Button btnAdd;
        private CheckBox ckStatus;
        private TextBox txtSlotIndex;
        private TextBox txtSlotID;
        private TextBox txtGroupID;
        private Button btnClose;
        private Button btnDelete;
        private Label lbStatus;
        private Label lbSlotIndex;
        private DataGridView dgvSlotList;
        private Label lbSlotID;
        private Label lbGroupID;
        private Label lbfrmSlot;
        private TextBox txtSlotName;
        private Label lbSlotName;
    }
}