using BusinessObjects.EntityModels;
using DataAccessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace GroupStudyWinApp
{
    public partial class frmGroupStudy : Form
    {
        ICommentRepository commentRepo = new CommentRepository();
        ISlotRepository slotRepo = new SlotRepository();
        IStudyMaterialRepository studyMRepo = new StudyMaterialRepository();
        IProgressRepository progressRepo = new ProgressRepository();
        int index = 0;
        BindingSource source = new BindingSource();
        //-----------------------------------------
        public frmGroupStudy()
        {
            InitializeComponent();
        }
        public Group CurrentGroup { get; set; }
        public User CurrentUser { get; set; }
        public Slot CurrentSlot { get; set; }
        //-----------------------------------------
        private void frmGroupStudy_Load(object sender, EventArgs e)
        {
            LoadCommentList();
            LoadSlotList();
            lbxComment.HorizontalScrollbar = true;
        }

        //-----------------------------------------
        public void LoadStudyMaterialList(int slotId)
        {
            var list = studyMRepo.GetStudyMaterialsByID(slotId);
            int i = 1;

            var progress = progressRepo.GetProgress(CurrentUser.UserId, slotId);
            // Check if user passed progress
            if (progress.Status == true)
            {
                // Print study materials in slot
                foreach (var item in list)
                {
                    rtxtContent.AppendText($"{i++}. " + item.Title + "\n", Color.Black);
                    rtxtContent.AppendText(item.Content + "\n\n");
                }
            }
            else
            {
                MessageBox.Show("you must finish the previous lession", "Notification");
            }
        }

        private void LoadCommentList()
        {
            var list = CommentDAO.Instance.GetCommentsByGroupId(CurrentGroup.GroupId);
            foreach (var item in list)
            {
                if (item.UserId == CurrentUser.UserId)
                {

                    lbxComment.Items.Add("You: " + item.Comment1);
                }
                else
                {
                    lbxComment.Items.Add(item.User.Username + ": " + item.Comment1);
                }

            }
        }

        private void LoadSlotList()
        {
            var list = slotRepo.GetSlotsByGroupId(CurrentGroup.GroupId);
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                dgvSlot.DataSource = null;
                dgvSlot.DataSource = list;

                dgvSlot.Columns[1].Visible = false;
                dgvSlot.Columns[4].Visible = false;
                dgvSlot.Columns[5].Visible = false;
                dgvSlot.Columns[6].Visible = false;

                dgvSlot.Columns[2].Width = 50;
                dgvSlot.Columns[2].HeaderText = "Index";
                dgvSlot.Columns[3].Width = 300;
                dgvSlot.Columns[3].HeaderText = "Name";

                DataGridViewColumn column = dgvSlot.Columns[0];
                column.DisplayIndex = 3;
                dgvSlot.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load list");
            }
        }
        //-----------------------------------------
        private void btnComment_Click(object sender, EventArgs e)
        {
            if (txtComment.Text.Trim().Length == 0) MessageBox.Show("Please enter something", "Warning");
            else
            {
                lbxComment.Items.Clear();
                var comment = new Comment
                {
                    UserId = CurrentUser.UserId,
                    Comment1 = txtComment.Text,
                    GroupId = CurrentGroup.GroupId,
                };

                commentRepo.AddNew(comment);
                LoadCommentList();
                txtComment.Text = string.Empty;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to close.", "Notification"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        private void dgvSlot_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSlot.Rows.Count)
            {
                DataGridViewRow row = dgvSlot.Rows[e.RowIndex];
                rtxtContent.Clear();
                LoadStudyMaterialList(Convert.ToInt32(row.Cells[0].Value.ToString()));
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbFinish.Checked)
            {
                var slots = slotRepo.GetSlotsByGroupId(CurrentGroup.GroupId).ToList();

                try
                {
                    Progress progress = new Progress
                    {
                        UserId = CurrentUser.UserId,
                        SlotId = slots[++index].SlotId,
                        Status = true,
                    };
                    progressRepo.Update(progress);
                    MessageBox.Show("Submit successfully", "Notification");
                    cbFinish.Checked = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }
    }
}
