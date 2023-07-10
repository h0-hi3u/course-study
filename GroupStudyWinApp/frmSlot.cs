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
    public partial class frmSlot : Form
    {
        public frmSlot()
        {
            InitializeComponent();
        }

        ISlotRepository repo = new SlotRepository();
        BindingSource source;

        private void frmSlot_Load(object sender, EventArgs e)
        {
            LoadSlotList();
        }
        private void LoadSlotList()
        {
            var list = repo.GetSlots();
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtSlotID.DataBindings.Clear();
                txtGroupID.DataBindings.Clear();
                txtSlotIndex.DataBindings.Clear();
                txtSlotName.DataBindings.Clear();
                ckStatus.DataBindings.Clear();

                txtSlotID.DataBindings.Add("Text", source, "SlotId");
                txtGroupID.DataBindings.Add("Text", source, "GroupId");
                txtSlotIndex.DataBindings.Add("Text", source, "SlotIndex");
                txtSlotName.DataBindings.Add("Text", source, "SlotName");
                ckStatus.DataBindings.Add("Checked", source, "Status", true, DataSourceUpdateMode.OnPropertyChanged);

                dgvSlotList.DataSource = null;
                dgvSlotList.DataSource = source;

                dgvSlotList.Columns[5].Visible = false;
                dgvSlotList.Columns[6].Visible = false;

                if (list.Count() == 0)
                {
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load list of Group");
            }
        }

        private void LoadSlotList(IEnumerable<Slot> list)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtSlotID.DataBindings.Clear();
                txtGroupID.DataBindings.Clear();
                txtSlotIndex.DataBindings.Clear();
                txtSlotName.DataBindings.Clear();
                ckStatus.DataBindings.Clear();

                txtSlotID.DataBindings.Add("Text", source, "SlotId");
                txtGroupID.DataBindings.Add("Text", source, "GroupId");
                txtSlotIndex.DataBindings.Add("Text", source, "SlotIndex");
                txtSlotName.DataBindings.Add("Text", source, "SlotName");
                ckStatus.DataBindings.Add("Checked", source, "Status", true, DataSourceUpdateMode.OnPropertyChanged);

                dgvSlotList.DataSource = null;
                dgvSlotList.DataSource = source;

                dgvSlotList.Columns[5].Visible = false;
                dgvSlotList.Columns[6].Visible = false;

                if (list.Count() != 0)
                {
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "FlowerBouquet Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                repo.Delete(int.Parse(txtSlotID.Text));
                LoadSlotList();
            }
        }
        private void btnClose_Click(object sender, EventArgs e) => Close();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSlotDetail f = new frmSlotDetail
            {
                Text = "Add group",
                slotRepository = repo,
                AddOrUpdate = true,
                SlotInfo = new Slot()
            };

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadSlotList();
                source.Position = source.Count - 1;
            }
            LoadSlotList();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Slot slot = new Slot
            {
                SlotId = int.Parse(txtSlotID.Text),
                GroupId = int.Parse(txtGroupID.Text),
                SlotIndex = txtSlotIndex.Text,
                SlotName = txtSlotName.Text,
                Status = ckStatus.Checked ? true : false
            };
            frmSlotDetail f = new frmSlotDetail
            {
                Text = "Add group",
                slotRepository = repo,
                AddOrUpdate = false,
                SlotInfo = slot
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadSlotList();
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<Slot> ListSearch;
            if (txtSearch.Text == null || txtSearch.Text == "Search Name here")
            {
                ListSearch = repo.GetSlots();
            }
            else
            {
                ListSearch = repo.GetSlots().Where(gr => gr.SlotName.ToUpper().Contains(txtSearch.Text.ToUpper())).ToList();
            }
            LoadSlotList(ListSearch);
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Name here")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search Name here";
                txtSearch.ForeColor = Color.Gray;
            }
        }
        private void ClearText()
        {
            txtSlotID.Text = string.Empty;
            txtGroupID.Text = string.Empty;
            txtSlotIndex.Text = string.Empty;
            txtSlotName.Text = string.Empty;
            ckStatus.Text = string.Empty;
        }
    }
}
