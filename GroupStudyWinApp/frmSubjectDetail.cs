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
    public partial class frmSubjectDetail : Form
    {
        ISubjectRepository repoSubject = new SubjectRepository();
        //----------------------------------------------------
        public bool isAdd { get; set; }
        public Subject currentSubject { get; set; }
        //----------------------------------------------------
        public frmSubjectDetail()
        {
            InitializeComponent();
        }
        //Button Close => Show a message for user choose comfirm close form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want close ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // Button Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check status is checked if user do not check. User can not save.
            bool status;
            if (!radioStatusFalse.Checked && !radioStatusTrue.Checked)
            {
                MessageBox.Show("Please check status");
                return;
            }
            else if (radioStatusTrue.Checked)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            // Check ID, name, Description not blank. If blank show the note to user and do not save.
            bool emptyID = txtSubjectID.Text.Length == 0 ? true : false;
            bool emptyName = txtSubjectName.Text.Length == 0 ? true : false;
            bool emptyDescription = txtDescription.Text.Length == 0 ? true : false;
            if (!emptyID && !emptyDescription && !emptyName)
            {
                Subject subject = new Subject
                {
                    SubjectId = txtSubjectID.Text,
                    SubjectName = txtSubjectName.Text,
                    Description = txtDescription.Text,
                    Status = status,
                };

                if (isAdd) // if isAdd == true will show a message to user add successfully
                {
                    repoSubject.AddSubject(subject);
                    MessageBox.Show("Add subject successfully");
                    this.Close();
                }
                else  // isAdd == false will show a message to user update successfully
                {
                    repoSubject.UpdateSubject(subject);
                    MessageBox.Show("Update subject successfully");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the blank", "Warning");
            }

        }
        // Load form
        private void frmSubjectDetail_Load(object sender, EventArgs e)
        {
            // if is update will fill data from currentSubject to txtSubjectID, txtDescription
            if (!isAdd)
            {
                txtSubjectID.Text = currentSubject.SubjectId;
                txtDescription.Text = currentSubject.Description;
                txtSubjectName.Text = currentSubject.SubjectName;
                txtSubjectID.Enabled = isAdd;
                // status can be null in sql so that check solution is null
                if (currentSubject.Status != null)
                {
                    // if status true radioStatusTrue will check, otherwise radioStatusFalse
                    if (currentSubject.Status == true)
                    {
                        radioStatusTrue.Checked = true;
                    }
                    else
                    {
                        radioStatusFalse.Checked = true;
                    }
                }

            }
        }
    }
}
