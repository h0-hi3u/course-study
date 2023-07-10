namespace GroupStudyWinApp
{
    partial class frmSlotDetail
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
            btnCancel = new Button();
            btnSave = new Button();
            ckStatus = new CheckBox();
            lbStatus = new Label();
            lbSlotIndex = new Label();
            lbSlotName = new Label();
            lbGroupId = new Label();
            txtGroupId = new TextBox();
            txtSlotName = new TextBox();
            txtSlotIndex = new TextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(268, 201);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 121;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(140, 201);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 120;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.Location = new Point(140, 160);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(18, 17);
            ckStatus.TabIndex = 119;
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(53, 157);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 118;
            lbStatus.Text = "Status";
            // 
            // lbSlotIndex
            // 
            lbSlotIndex.AutoSize = true;
            lbSlotIndex.Location = new Point(53, 88);
            lbSlotIndex.Name = "lbSlotIndex";
            lbSlotIndex.Size = new Size(45, 20);
            lbSlotIndex.TabIndex = 122;
            lbSlotIndex.Text = "Index";
            // 
            // lbSlotName
            // 
            lbSlotName.AutoSize = true;
            lbSlotName.Location = new Point(53, 121);
            lbSlotName.Name = "lbSlotName";
            lbSlotName.Size = new Size(49, 20);
            lbSlotName.TabIndex = 123;
            lbSlotName.Text = "Name";
            // 
            // lbGroupId
            // 
            lbGroupId.AutoSize = true;
            lbGroupId.Location = new Point(53, 55);
            lbGroupId.Name = "lbGroupId";
            lbGroupId.Size = new Size(63, 20);
            lbGroupId.TabIndex = 124;
            lbGroupId.Text = "GroupId";
            // 
            // txtGroupId
            // 
            txtGroupId.Location = new Point(140, 52);
            txtGroupId.Name = "txtGroupId";
            txtGroupId.Size = new Size(222, 27);
            txtGroupId.TabIndex = 125;
            // 
            // txtSlotName
            // 
            txtSlotName.Location = new Point(140, 118);
            txtSlotName.Name = "txtSlotName";
            txtSlotName.Size = new Size(222, 27);
            txtSlotName.TabIndex = 126;
            // 
            // txtSlotIndex
            // 
            txtSlotIndex.Location = new Point(140, 85);
            txtSlotIndex.Name = "txtSlotIndex";
            txtSlotIndex.Size = new Size(222, 27);
            txtSlotIndex.TabIndex = 127;
            // 
            // frmSlotDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 281);
            Controls.Add(txtSlotIndex);
            Controls.Add(txtSlotName);
            Controls.Add(txtGroupId);
            Controls.Add(lbGroupId);
            Controls.Add(lbSlotName);
            Controls.Add(lbSlotIndex);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(ckStatus);
            Controls.Add(lbStatus);
            Name = "frmSlotDetail";
            Text = "frmSlotDetail";
            Load += frmSlotDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private CheckBox ckStatus;
        private Label lbStatus;
        private Label lbSlotIndex;
        private Label lbSlotName;
        private Label lbGroupId;
        private TextBox txtGroupId;
        private TextBox txtSlotName;
        private TextBox txtSlotIndex;
    }
}