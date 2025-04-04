using Guna.UI2.WinForms;
using Project.Class;
using Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class AddDVD_VCD : Form
    {
        private object[] copiedData;
        private object copiedCellValue;
        private Stack<UndoRedoAction> undoStack = new Stack<UndoRedoAction>();
        private Stack<UndoRedoAction> redoStack = new Stack<UndoRedoAction>();
        private VideoLibrary vd = new VideoLibrary();

        public AddDVD_VCD()
        {
            InitializeComponent();
        }

        private void AddDVD_VCD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddDVD_VCD_Load(object sender, EventArgs e)
        {
            AddColumnCMBX("Category", "Category", new List<string> { "DVD", "VCD" });
            DataGridViewComboBoxColumn cmbxClmn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Limit Days Rented",
                Name = "LimitDaysRented",
                DataSource = new List<int> {1, 2, 3 },
            };
            cmbxClmn.DefaultCellStyle.BackColor = Color.White;
            cmbxClmn.FlatStyle = FlatStyle.Flat;
            G2DGVAddSave.Columns.Add(cmbxClmn); 
            DisplayVideo();
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            if (LblLastVideoID == null) return;
            int count = vd.LastVideoID();
            LblLastVideoID.Text = count.ToString();
        }
        private void DisplayVideo()
        {
            var Title = VideoLibrary.ShowAllVideo();
            comboBoxVideo.DataSource = Title;
            comboBoxVideo.DisplayMember = "Title";
            comboBoxVideo.ValueMember = "VideoID";
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
            G2DGVAddSave.Columns.Add(cmbxClmn);
        }

        private void G2DGVAdd_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (G2DGVAddSave.Columns[e.ColumnIndex].Name == "Category")
                {
                    DataGridViewRow currentRow = G2DGVAddSave.Rows[e.RowIndex];
                    string selectedCategory = currentRow.Cells["Category"].Value?.ToString();

                    currentRow.Cells["Price"].Value = selectedCategory == "DVD" ? (decimal)50.00 : (decimal)25.00;
                    currentRow.Cells["Qty"].Value = 1;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G2DGVAdd_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (G2DGVAddSave.IsCurrentCellDirty && G2DGVAddSave.CurrentCell.OwningColumn.Name == "Category")
                {
                    G2DGVAddSave.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G2BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                vd.Insert(G2DGVAddSave);
                MessageBox.Show("Data save successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            G2DGVAddSave.Rows.Clear();
        }

        private void G2BtnAddSave_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.C:
                    if (e.Control)
                    {
                        if (G2DGVAddSave.CurrentRow != null && !G2DGVAddSave.CurrentRow.IsNewRow)
                            copiedData = G2DGVAddSave.CurrentRow.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray();
                        else if (G2DGVAddSave.CurrentCell != null)
                            copiedCellValue = G2DGVAddSave.CurrentCell.Value;
                    }
                    break;
                case Keys.V:
                    if (e.Control)
                    {
                        if (copiedCellValue != null && G2DGVAddSave.CurrentCell != null)
                        {
                            AddToUndoStackCell();
                            G2DGVAddSave.CurrentCell.Value = copiedCellValue;
                        }
                        else if(copiedData != null)
                        {
                            AddToUndoStack();

                            int newRowIndex = G2DGVAddSave.Rows.Add();
                            for (int i = 0; i < copiedData.Length; i++)
                                G2DGVAddSave.Rows[newRowIndex].Cells[i].Value = copiedData[i];
                        }
                    }
                    break;
                case Keys.Delete:
                    if (G2DGVAddSave.CurrentRow != null && !G2DGVAddSave.CurrentRow.IsNewRow)
                        G2DGVAddSave.Rows.Remove(G2DGVAddSave.CurrentRow);
                    else if (G2DGVAddSave.CurrentCell != null)
                        G2DGVAddSave.CurrentCell.Value = null;
                        break;
              
                default:
                    break;
            }
        }

        private void AddToUndoStack()
        {
          if(G2DGVAddSave.CurrentRow != null && !G2DGVAddSave.CurrentRow.IsNewRow)
            {
               var rowValues = G2DGVAddSave.CurrentRow.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray();

                undoStack.Push(new UndoRedoAction
                {
                    Cells = rowValues
                });
                redoStack.Clear();
            }
        }
         private void AddToUndoStackCell()
        {
            if (G2DGVAddSave.CurrentCell != null)
            {
                undoStack.Push(new UndoRedoAction
                {
                    Cell = G2DGVAddSave.CurrentCell,
                    PreviousValue = G2DGVAddSave.CurrentCell.Value 
                });

                redoStack.Clear();
            }
        }

        private void comboBoxFullname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVideo.SelectedValue != null)
            {
                VideoProp vd = comboBoxVideo.SelectedItem as VideoProp;
                guna2TextBoxVideo.Text = vd.VideoId.ToString();
            }
        }

        private void G2BtnAdd_Click(object sender, EventArgs e)
        {
            VideoProp SlctdVideo = comboBoxVideo.SelectedItem as VideoProp;
            try
            {
                int RowIndex = G2DGVAddSave.Rows.Add();
                DataGridViewRow row = G2DGVAddSave.Rows[RowIndex];
                row.Cells["VideoID"].Value = SlctdVideo.VideoId;
                row.Cells["Title"].Value = SlctdVideo.Title;
                row.Cells["LimitDaysRented"].Value = SlctdVideo.LimitDaysRented;
                row.Cells["Category"].Value = SlctdVideo.Category;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G2DGVAddSave_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void guna2TextBoxVideo_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblLastVideoID_Click(object sender, EventArgs e)
        {
        }
    }
}