namespace GroupStudyWinApp
{
    partial class frmMyGroup
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
            dgvGroupList = new DataGridView();
            label1 = new Label();
            btnOut = new Button();
            txtSize = new TextBox();
            txtStatus = new TextBox();
            txtSubjectId = new TextBox();
            txtGroupId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtJoined = new TextBox();
            btnGo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGroupList).BeginInit();
            SuspendLayout();
            // 
            // dgvGroupList
            // 
            dgvGroupList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGroupList.Location = new Point(29, 236);
            dgvGroupList.Name = "dgvGroupList";
            dgvGroupList.RowHeadersWidth = 51;
            dgvGroupList.RowTemplate.Height = 29;
            dgvGroupList.Size = new Size(552, 188);
            dgvGroupList.TabIndex = 0;
            dgvGroupList.CellDoubleClick += dgvGroupList_CellDoubleClick;
            dgvGroupList.CellMouseClick += dgvGroupList_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(206, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 50);
            label1.TabIndex = 1;
            label1.Text = "My Group";
            // 
            // btnOut
            // 
            btnOut.Location = new Point(487, 201);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(94, 29);
            btnOut.TabIndex = 2;
            btnOut.Text = "Out";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(108, 131);
            txtSize.Name = "txtSize";
            txtSize.ReadOnly = true;
            txtSize.Size = new Size(125, 27);
            txtSize.TabIndex = 3;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(456, 128);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(125, 27);
            txtStatus.TabIndex = 4;
            // 
            // txtSubjectId
            // 
            txtSubjectId.Location = new Point(456, 84);
            txtSubjectId.Name = "txtSubjectId";
            txtSubjectId.ReadOnly = true;
            txtSubjectId.Size = new Size(125, 27);
            txtSubjectId.TabIndex = 5;
            // 
            // txtGroupId
            // 
            txtGroupId.Location = new Point(108, 87);
            txtGroupId.Name = "txtGroupId";
            txtGroupId.ReadOnly = true;
            txtGroupId.Size = new Size(125, 27);
            txtGroupId.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 90);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 7;
            label2.Text = "GroupId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 87);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 8;
            label3.Text = "SubjectId";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 134);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 9;
            label4.Text = "Size";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(363, 131);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 10;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 178);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 12;
            label6.Text = "Joined";
            // 
            // txtJoined
            // 
            txtJoined.Location = new Point(108, 175);
            txtJoined.Name = "txtJoined";
            txtJoined.ReadOnly = true;
            txtJoined.Size = new Size(125, 27);
            txtJoined.TabIndex = 11;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(375, 201);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(94, 29);
            btnGo.TabIndex = 13;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // frmMyGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 450);
            Controls.Add(btnGo);
            Controls.Add(label6);
            Controls.Add(txtJoined);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtGroupId);
            Controls.Add(txtSubjectId);
            Controls.Add(txtStatus);
            Controls.Add(txtSize);
            Controls.Add(btnOut);
            Controls.Add(label1);
            Controls.Add(dgvGroupList);
            Name = "frmMyGroup";
            Text = "My Group";
            Load += frmYourGroup_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGroupList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGroupList;
        private Label label1;
        private Button btnOut;
        private TextBox txtSize;
        private TextBox txtStatus;
        private TextBox txtSubjectId;
        private TextBox txtGroupId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtJoined;
        private Button btnGo;
    }
}