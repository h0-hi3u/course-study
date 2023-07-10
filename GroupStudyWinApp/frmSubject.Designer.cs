namespace GroupStudyWinApp
{
    partial class frmSubject
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
            txtSubjectID = new TextBox();
            txtDescription = new TextBox();
            txtStatus = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dgvSubject = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            label5 = new Label();
            txtSubjectName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(231, 9);
            label1.Name = "label1";
            label1.Size = new Size(359, 46);
            label1.TabIndex = 0;
            label1.Text = "Management Subject";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 98);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "SubjectID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 150);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 150);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 3;
            label4.Text = "Desciption";
            // 
            // txtSubjectID
            // 
            txtSubjectID.Location = new Point(139, 91);
            txtSubjectID.Name = "txtSubjectID";
            txtSubjectID.ReadOnly = true;
            txtSubjectID.Size = new Size(246, 27);
            txtSubjectID.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.AcceptsReturn = true;
            txtDescription.Location = new Point(139, 143);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(246, 27);
            txtDescription.TabIndex = 5;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(540, 147);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(246, 27);
            txtStatus.TabIndex = 6;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dgvSubject
            // 
            dgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubject.Location = new Point(53, 198);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.RowHeadersWidth = 51;
            dgvSubject.RowTemplate.Height = 29;
            dgvSubject.Size = new Size(555, 221);
            dgvSubject.TabIndex = 7;
            dgvSubject.CellDoubleClick += dgvSubject_CellDoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(676, 198);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(676, 260);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(676, 320);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(432, 98);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 12;
            label5.Text = "Name";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(540, 91);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.ReadOnly = true;
            txtSubjectName.Size = new Size(246, 27);
            txtSubjectName.TabIndex = 13;
            // 
            // frmSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 450);
            Controls.Add(txtSubjectName);
            Controls.Add(label5);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvSubject);
            Controls.Add(txtStatus);
            Controls.Add(txtDescription);
            Controls.Add(txtSubjectID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSubject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Subject";
            Load += frmSubject_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSubjectID;
        private TextBox txtDescription;
        private TextBox txtStatus;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dgvSubject;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClose;
        private Label label5;
        private TextBox txtSubjectName;
    }
}