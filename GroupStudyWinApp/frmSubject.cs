using BusinessObjects.EntityModels;
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

namespace GroupStudyWinApp
{
    public partial class frmSubject : Form
    {
        ISubjectRepository repoSubject = new SubjectRepository();
        BindingSource source;
        //------------------------------------------------------
        private void ClearText()
        {
            txtSubjectID.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }
        // Get subject in row user choose in dvgSubject
        private Subject GetCurrentSubject()
        {
            return new Subject
            {
                SubjectId = txtSubjectID.Text,
                SubjectName = txtSubjectName.Text,
                Description = txtDescription.Text,
                Status = Convert.ToBoolean(txtStatus.Text),
            };
        }
        // Show data to dgvSubject and fill data to DataBindings
        private void LoadListSubject()
        {
            var subjects = repoSubject.GetSubjects();
            try
            {
                source = new BindingSource();
                source.DataSource = subjects;

                txtSubjectID.DataBindings.Clear();
                txtSubjectName.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtSubjectID.DataBindings.Add("Text", source, "subjectId");
                txtSubjectName.DataBindings.Add("Text", source, "subjectName");
                txtDescription.DataBindings.Add("Text", source, "description");
                txtStatus.DataBindings.Add("Text", source, "status");

                dgvSubject.DataSource = null;
                dgvSubject.DataSource = source;

                dgvSubject.Columns[4].Visible = false;

                if (subjects.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load list subject");
            }
        }
        //------------------------------------------------------
        public frmSubject()
        {
            InitializeComponent();
        }
        // Button Close => show a message for user choose to close form
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // Button Add => show a form for fill data to add subject
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSubjectDetail f = new frmSubjectDetail
            {
                Text = "Add Subject",
                isAdd = true,
            };
            f.ShowDialog();
            LoadListSubject();
        }
        // Button Delete => delete row (subject) user choose in dgvSubject
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Subject deleteSubject = GetCurrentSubject();
            if (MessageBox.Show("Do you want to delete ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                repoSubject.DeleteSubject(deleteSubject.SubjectId);
                LoadListSubject();
            }
        }
        // Double click one in dgvSubject will show form to update data for subject
        private void dgvSubject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmSubjectDetail frmSubjectDetail = new frmSubjectDetail
            {
                isAdd = false,
                Text = "Update subject",
                currentSubject = GetCurrentSubject(),
            };
            frmSubjectDetail.ShowDialog();
            LoadListSubject();
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            LoadListSubject();
        }
    }
}
