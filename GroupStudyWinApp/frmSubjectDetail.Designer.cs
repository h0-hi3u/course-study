namespace GroupStudyWinApp
{
    partial class frmSubjectDetail
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
            txtSubjectID = new TextBox();
            txtDescription = new TextBox();
            radioStatusTrue = new RadioButton();
            radioStatusFalse = new RadioButton();
            btnSave = new Button();
            btnCancel = new Button();
            label4 = new Label();
            txtSubjectName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 19);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Subject ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 136);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 199);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // txtSubjectID
            // 
            txtSubjectID.Location = new Point(150, 12);
            txtSubjectID.Name = "txtSubjectID";
            txtSubjectID.Size = new Size(293, 27);
            txtSubjectID.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(150, 129);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(293, 27);
            txtDescription.TabIndex = 5;
            // 
            // radioStatusTrue
            // 
            radioStatusTrue.AutoSize = true;
            radioStatusTrue.Location = new Point(150, 199);
            radioStatusTrue.Name = "radioStatusTrue";
            radioStatusTrue.Size = new Size(58, 24);
            radioStatusTrue.TabIndex = 7;
            radioStatusTrue.TabStop = true;
            radioStatusTrue.Text = "True";
            radioStatusTrue.UseVisualStyleBackColor = true;
            // 
            // radioStatusFalse
            // 
            radioStatusFalse.AutoSize = true;
            radioStatusFalse.Location = new Point(225, 199);
            radioStatusFalse.Name = "radioStatusFalse";
            radioStatusFalse.Size = new Size(62, 24);
            radioStatusFalse.TabIndex = 8;
            radioStatusFalse.TabStop = true;
            radioStatusFalse.Text = "False";
            radioStatusFalse.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(100, 285);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(277, 285);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 75);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 11;
            label4.Text = "Subject Name";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(150, 72);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(293, 27);
            txtSubjectName.TabIndex = 12;
            // 
            // frmSubjectDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 355);
            Controls.Add(txtSubjectName);
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(radioStatusFalse);
            Controls.Add(radioStatusTrue);
            Controls.Add(txtDescription);
            Controls.Add(txtSubjectID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSubjectDetail";
            Text = "Subject Detail";
            Load += frmSubjectDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSubjectID;
        private TextBox txtDescription;
        private RadioButton radioStatusTrue;
        private RadioButton radioStatusFalse;
        private Button btnSave;
        private Button btnCancel;
        private Label label4;
        private TextBox txtSubjectName;
    }
}