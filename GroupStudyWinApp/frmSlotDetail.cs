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
    public partial class frmSlotDetail : Form
    {
        public frmSlotDetail()
        {
            InitializeComponent();
        }

        public ISlotRepository slotRepository { get; set; }
        public bool AddOrUpdate { get; set; }
        public Slot SlotInfo { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                Slot slot = new Slot
                {
                    SlotId = SlotInfo.SlotId,
                    GroupId = int.Parse(txtGroupId.Text),
                    SlotIndex = txtSlotIndex.Text,
                    SlotName = txtSlotName.Text,
                    Status = ckStatus.Checked ? true : false
                };
                if (string.IsNullOrEmpty(txtSlotIndex.Text) || string.IsNullOrEmpty(txtSlotIndex.Text) || string.IsNullOrEmpty(txtSlotName.Text))
                {
                    MessageBox.Show("All field are required");
                }
                else
                {
                    if (AddOrUpdate)
                    {
                        slotRepository.Add(slot);
                        MessageBox.Show("Add successfully!", "Notification");
                    }
                    else
                    {
                        slotRepository.Update(slot);
                        if (MessageBox.Show("Update successfully!", "Notification", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AddOrUpdate ? "Add Fail" : "Update Fail");
            }
        }

        private void frmSlotDetail_Load(object sender, EventArgs e)
        {
            txtGroupId.Text = SlotInfo.GroupId.ToString();
            txtSlotIndex.Text = SlotInfo.SlotIndex;
            txtSlotName.Text = SlotInfo.SlotName;
            ckStatus.Checked = SlotInfo.Status == true ? true : false;
        }
    }
}
