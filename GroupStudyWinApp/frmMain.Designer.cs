namespace GroupStudyWinApp
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            manageToolStripMenuItem = new ToolStripMenuItem();
            manageSubjectToolStripMenuItem = new ToolStripMenuItem();
            manageGroupToolStripMenuItem = new ToolStripMenuItem();
            manageUserToolStripMenuItem = new ToolStripMenuItem();
            manageSlotToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            groupToolStripMenuItem = new ToolStripMenuItem();
            joinGroupToolStripMenuItem = new ToolStripMenuItem();
            myGroupToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            manageParticipantToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { manageToolStripMenuItem, exitToolStripMenuItem, logoutToolStripMenuItem, groupToolStripMenuItem, profileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(882, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageSubjectToolStripMenuItem, manageGroupToolStripMenuItem, manageUserToolStripMenuItem, manageSlotToolStripMenuItem, manageParticipantToolStripMenuItem });
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(77, 24);
            manageToolStripMenuItem.Text = "Manage";
            // 
            // manageSubjectToolStripMenuItem
            // 
            manageSubjectToolStripMenuItem.Name = "manageSubjectToolStripMenuItem";
            manageSubjectToolStripMenuItem.Size = new Size(224, 26);
            manageSubjectToolStripMenuItem.Text = "Manage Subject";
            manageSubjectToolStripMenuItem.Click += manageSubjectToolStripMenuItem_Click;
            // 
            // manageGroupToolStripMenuItem
            // 
            manageGroupToolStripMenuItem.Name = "manageGroupToolStripMenuItem";
            manageGroupToolStripMenuItem.Size = new Size(224, 26);
            manageGroupToolStripMenuItem.Text = "Manage Group";
            manageGroupToolStripMenuItem.Click += manageGroupToolStripMenuItem_Click;
            // 
            // manageUserToolStripMenuItem
            // 
            manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            manageUserToolStripMenuItem.Size = new Size(224, 26);
            manageUserToolStripMenuItem.Text = "Manage User";
            manageUserToolStripMenuItem.Click += manageUserToolStripMenuItem_Click;
            // 
            // manageSlotToolStripMenuItem
            // 
            manageSlotToolStripMenuItem.Name = "manageSlotToolStripMenuItem";
            manageSlotToolStripMenuItem.Size = new Size(224, 26);
            manageSlotToolStripMenuItem.Text = "Manage Slot";
            manageSlotToolStripMenuItem.Click += manageSlotToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // groupToolStripMenuItem
            // 
            groupToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { joinGroupToolStripMenuItem, myGroupToolStripMenuItem });
            groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            groupToolStripMenuItem.Size = new Size(64, 24);
            groupToolStripMenuItem.Text = "Group";
            // 
            // joinGroupToolStripMenuItem
            // 
            joinGroupToolStripMenuItem.Name = "joinGroupToolStripMenuItem";
            joinGroupToolStripMenuItem.Size = new Size(163, 26);
            joinGroupToolStripMenuItem.Text = "Join Group";
            joinGroupToolStripMenuItem.Click += joinGroupToolStripMenuItem_Click;
            // 
            // myGroupToolStripMenuItem
            // 
            myGroupToolStripMenuItem.Name = "myGroupToolStripMenuItem";
            myGroupToolStripMenuItem.Size = new Size(163, 26);
            myGroupToolStripMenuItem.Text = "My Group";
            myGroupToolStripMenuItem.Click += myGroupToolStripMenuItem_Click;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(66, 24);
            profileToolStripMenuItem.Text = "Profile";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            // 
            // manageParticipantToolStripMenuItem
            // 
            manageParticipantToolStripMenuItem.Name = "manageParticipantToolStripMenuItem";
            manageParticipantToolStripMenuItem.Size = new Size(224, 26);
            manageParticipantToolStripMenuItem.Text = "Manage Participant";
            manageParticipantToolStripMenuItem.Click += manageParticipantToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 558);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Group Study";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem manageSubjectToolStripMenuItem;
        private ToolStripMenuItem manageGroupToolStripMenuItem;
        private ToolStripMenuItem manageUserToolStripMenuItem;
        private ToolStripMenuItem groupToolStripMenuItem;
        private ToolStripMenuItem joinGroupToolStripMenuItem;
        private ToolStripMenuItem myGroupToolStripMenuItem;
        private ToolStripMenuItem manageSlotToolStripMenuItem;
        private ToolStripMenuItem manageParticipantToolStripMenuItem;
    }
}