namespace GroupStudyWinApp
{
    partial class frmGroupStudy
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
            dgvSlot = new DataGridView();
            lbxComment = new ListBox();
            txtComment = new TextBox();
            btnComment = new Button();
            btnClose = new Button();
            rtxtContent = new RichTextBox();
            btnSubmit = new Button();
            cbFinish = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvSlot).BeginInit();
            SuspendLayout();
            // 
            // dgvSlot
            // 
            dgvSlot.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSlot.Location = new Point(12, 12);
            dgvSlot.Name = "dgvSlot";
            dgvSlot.RowHeadersWidth = 51;
            dgvSlot.RowTemplate.Height = 29;
            dgvSlot.Size = new Size(380, 213);
            dgvSlot.TabIndex = 0;
            dgvSlot.CellDoubleClick += dgvSlot_CellDoubleClick;
            // 
            // lbxComment
            // 
            lbxComment.BorderStyle = BorderStyle.None;
            lbxComment.FormattingEnabled = true;
            lbxComment.ItemHeight = 20;
            lbxComment.Location = new Point(12, 255);
            lbxComment.Name = "lbxComment";
            lbxComment.RightToLeft = RightToLeft.No;
            lbxComment.Size = new Size(380, 200);
            lbxComment.TabIndex = 1;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(12, 474);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(270, 27);
            txtComment.TabIndex = 2;
            // 
            // btnComment
            // 
            btnComment.Location = new Point(298, 474);
            btnComment.Name = "btnComment";
            btnComment.Size = new Size(94, 29);
            btnComment.TabIndex = 3;
            btnComment.Text = "Comment";
            btnComment.UseVisualStyleBackColor = true;
            btnComment.Click += btnComment_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1038, 525);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // rtxtContent
            // 
            rtxtContent.Location = new Point(435, 12);
            rtxtContent.Name = "rtxtContent";
            rtxtContent.Size = new Size(697, 491);
            rtxtContent.TabIndex = 6;
            rtxtContent.Text = "";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(572, 525);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // cbFinish
            // 
            cbFinish.AutoSize = true;
            cbFinish.Location = new Point(435, 528);
            cbFinish.Name = "cbFinish";
            cbFinish.Size = new Size(117, 24);
            cbFinish.TabIndex = 9;
            cbFinish.Text = "Finish lession";
            cbFinish.UseVisualStyleBackColor = true;
            // 
            // frmGroupStudy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 566);
            Controls.Add(cbFinish);
            Controls.Add(btnSubmit);
            Controls.Add(rtxtContent);
            Controls.Add(btnClose);
            Controls.Add(btnComment);
            Controls.Add(txtComment);
            Controls.Add(lbxComment);
            Controls.Add(dgvSlot);
            Name = "frmGroupStudy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Group Study";
            Load += frmGroupStudy_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSlot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSlot;
        private ListBox lbxComment;
        private TextBox txtComment;
        private Button btnComment;
        private Button btnClose;
        private RichTextBox rtxtContent;
        private Button btnSubmit;
        private CheckBox cbFinish;
    }
}