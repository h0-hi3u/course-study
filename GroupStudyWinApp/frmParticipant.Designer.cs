namespace GroupStudyWinApp
{
    partial class frmParticipant
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
            dgvGroup = new DataGridView();
            dgvPending = new DataGridView();
            dgvAccepted = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            btnAccept = new Button();
            btnBan = new Button();
            btnClose = new Button();
            btnUnban = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGroup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPending).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAccepted).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(289, 9);
            label1.Name = "label1";
            label1.Size = new Size(346, 46);
            label1.TabIndex = 0;
            label1.Text = "Manage Particitpant";
            // 
            // dgvGroup
            // 
            dgvGroup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGroup.Location = new Point(12, 300);
            dgvGroup.Name = "dgvGroup";
            dgvGroup.RowHeadersWidth = 51;
            dgvGroup.RowTemplate.Height = 29;
            dgvGroup.Size = new Size(790, 188);
            dgvGroup.TabIndex = 1;
            dgvGroup.CellDoubleClick += dgvGroup_CellDoubleClick;
            // 
            // dgvPending
            // 
            dgvPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPending.Location = new Point(12, 99);
            dgvPending.Name = "dgvPending";
            dgvPending.RowHeadersWidth = 51;
            dgvPending.RowTemplate.Height = 29;
            dgvPending.Size = new Size(392, 162);
            dgvPending.TabIndex = 2;
            // 
            // dgvAccepted
            // 
            dgvAccepted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccepted.Location = new Point(510, 99);
            dgvAccepted.Name = "dgvAccepted";
            dgvAccepted.RowHeadersWidth = 51;
            dgvAccepted.RowTemplate.Height = 29;
            dgvAccepted.Size = new Size(392, 162);
            dgvAccepted.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(144, 65);
            label2.Name = "label2";
            label2.Size = new Size(98, 31);
            label2.TabIndex = 4;
            label2.Text = "Pending";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(665, 55);
            label3.Name = "label3";
            label3.Size = new Size(111, 31);
            label3.TabIndex = 5;
            label3.Text = "Accepted";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(410, 99);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(94, 29);
            btnAccept.TabIndex = 6;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnBan
            // 
            btnBan.Location = new Point(410, 162);
            btnBan.Name = "btnBan";
            btnBan.Size = new Size(94, 29);
            btnBan.TabIndex = 7;
            btnBan.Text = "Ban";
            btnBan.UseVisualStyleBackColor = true;
            btnBan.Click += btnBan_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(808, 459);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUnban
            // 
            btnUnban.Location = new Point(410, 232);
            btnUnban.Name = "btnUnban";
            btnUnban.Size = new Size(94, 29);
            btnUnban.TabIndex = 10;
            btnUnban.Text = "Unban";
            btnUnban.UseVisualStyleBackColor = true;
            btnUnban.Click += btnUnban_Click;
            // 
            // frmParticipant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 503);
            Controls.Add(btnUnban);
            Controls.Add(btnClose);
            Controls.Add(btnBan);
            Controls.Add(btnAccept);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvAccepted);
            Controls.Add(dgvPending);
            Controls.Add(dgvGroup);
            Controls.Add(label1);
            Name = "frmParticipant";
            Text = "Participant";
            Load += frmParticipant_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGroup).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPending).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAccepted).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvGroup;
        private DataGridView dgvPending;
        private DataGridView dgvAccepted;
        private Label label2;
        private Label label3;
        private Button btnAccept;
        private Button btnBan;
        private Button btnClose;
        private Button btnUnban;
    }
}