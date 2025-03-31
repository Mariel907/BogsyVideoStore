using Project.Class;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class AddDVD_VCD : Form
    {
        public AddDVD_VCD()
        {
            InitializeComponent();
        }

        private void Guna2ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                VideoProp video = new VideoProp();
                video.Title = guna2TextBoxTitle.Text;
                video.CopiesAvailable = guna2TextBoxTotalCopies.Text;
                video.Category = guna2ComboBoxCategory.Text;
                video.LimitDaysRented = Convert.ToInt16(guna2ComboBoxLimitdaysRented.Text);

              
                MessageBox.Show("Data added successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddDVD_VCD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddDVD_VCD_Load(object sender, EventArgs e)
        {
            AddColumnCMBX("Category", "Category", new List<string> { "DVD", "VCD" });
            AddColumnCMBX("Limit Days Rented", "LimitDaysRented", new List<string> { "1", "2", "3" });

        }
       
        private void AddColumnCMBX(string HdrText, string NmText, List<string> dataSource)
        {
            DataGridViewComboBoxColumn cmbxClmn = new DataGridViewComboBoxColumn
            {
                HeaderText = HdrText,
                Name = NmText,
                DataSource = dataSource,
            };
            cmbxClmn.DefaultCellStyle.BackColor = Color.White;
            cmbxClmn.FlatStyle = FlatStyle.Flat;
            G2BtnAddSave.Columns.Add(cmbxClmn);
        }

        private void G2DGVAdd_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (G2BtnAddSave.Columns[e.ColumnIndex].Name == "Category")
            {
                DataGridViewRow currentRow = G2BtnAddSave.Rows[e.RowIndex];
                string selectedCategory = currentRow.Cells["Category"].Value?.ToString();

                currentRow.Cells["Price"].Value = selectedCategory == "DVD" ? 50 : 25;
                currentRow.Cells["Qty"].Value = 1;
            }
        }

        private void G2DGVAdd_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (G2BtnAddSave.IsCurrentCellDirty && G2BtnAddSave.CurrentCell.OwningColumn.Name == "Category")
            {
                G2BtnAddSave.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void G2BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                VideoLibrary vd = new VideoLibrary();
                vd.Insert(G2BtnAddSave);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}