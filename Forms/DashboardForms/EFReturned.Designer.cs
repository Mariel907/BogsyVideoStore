namespace Project.Forms.DashboardForms
{
    partial class EFReturned
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EFReturned));
            this.DGVReturned = new Guna.UI2.WinForms.Guna2DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mReturnedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.G2TxbxReturned = new Guna.UI2.WinForms.Guna2TextBox();
            this.G2CmbxReturned = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReturned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mReturnedBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVReturned
            // 
            this.DGVReturned.AllowUserToAddRows = false;
            this.DGVReturned.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGVReturned.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVReturned.AutoGenerateColumns = false;
            this.DGVReturned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVReturned.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVReturned.ColumnHeadersHeight = 35;
            this.DGVReturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVReturned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.serialNoDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn});
            this.DGVReturned.DataSource = this.mReturnedBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVReturned.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVReturned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVReturned.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVReturned.Location = new System.Drawing.Point(10, 62);
            this.DGVReturned.Margin = new System.Windows.Forms.Padding(4);
            this.DGVReturned.Name = "DGVReturned";
            this.DGVReturned.ReadOnly = true;
            this.DGVReturned.RowHeadersVisible = false;
            this.DGVReturned.Size = new System.Drawing.Size(1001, 372);
            this.DGVReturned.TabIndex = 381;
            this.DGVReturned.Tag = "book_id";
            this.DGVReturned.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVReturned.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVReturned.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVReturned.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVReturned.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVReturned.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVReturned.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVReturned.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.DGVReturned.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVReturned.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVReturned.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVReturned.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVReturned.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVReturned.ThemeStyle.ReadOnly = true;
            this.DGVReturned.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.DGVReturned.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVReturned.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVReturned.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVReturned.ThemeStyle.RowsStyle.Height = 22;
            this.DGVReturned.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.DGVReturned.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serialNoDataGridViewTextBoxColumn
            // 
            this.serialNoDataGridViewTextBoxColumn.DataPropertyName = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "Serial No.";
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            this.serialNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "Return Date";
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            this.returnDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mReturnedBindingSource
            // 
            this.mReturnedBindingSource.DataSource = typeof(Project.Model.MReturned);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.G2TxbxReturned);
            this.panel1.Controls.Add(this.G2CmbxReturned);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 52);
            this.panel1.TabIndex = 384;
            // 
            // G2TxbxReturned
            // 
            this.G2TxbxReturned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G2TxbxReturned.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2TxbxReturned.BorderThickness = 2;
            this.G2TxbxReturned.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.G2TxbxReturned.DefaultText = "";
            this.G2TxbxReturned.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.G2TxbxReturned.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.G2TxbxReturned.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.G2TxbxReturned.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.G2TxbxReturned.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G2TxbxReturned.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2TxbxReturned.ForeColor = System.Drawing.Color.Black;
            this.G2TxbxReturned.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G2TxbxReturned.IconLeft = ((System.Drawing.Image)(resources.GetObject("G2TxbxReturned.IconLeft")));
            this.G2TxbxReturned.Location = new System.Drawing.Point(137, 8);
            this.G2TxbxReturned.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.G2TxbxReturned.Name = "G2TxbxReturned";
            this.G2TxbxReturned.PlaceholderText = "";
            this.G2TxbxReturned.SelectedText = "";
            this.G2TxbxReturned.Size = new System.Drawing.Size(860, 36);
            this.G2TxbxReturned.TabIndex = 383;
            this.G2TxbxReturned.TextChanged += new System.EventHandler(this.G2TxbxReturned_TextChanged);
            // 
            // G2CmbxReturned
            // 
            this.G2CmbxReturned.BackColor = System.Drawing.Color.Transparent;
            this.G2CmbxReturned.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxReturned.BorderThickness = 2;
            this.G2CmbxReturned.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.G2CmbxReturned.DropDownHeight = 150;
            this.G2CmbxReturned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.G2CmbxReturned.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxReturned.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxReturned.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2CmbxReturned.ForeColor = System.Drawing.Color.Black;
            this.G2CmbxReturned.IntegralHeight = false;
            this.G2CmbxReturned.ItemHeight = 30;
            this.G2CmbxReturned.Items.AddRange(new object[] {
            "DVD",
            "VCD"});
            this.G2CmbxReturned.Location = new System.Drawing.Point(3, 8);
            this.G2CmbxReturned.Name = "G2CmbxReturned";
            this.G2CmbxReturned.Size = new System.Drawing.Size(127, 36);
            this.G2CmbxReturned.TabIndex = 384;
            this.G2CmbxReturned.SelectedIndexChanged += new System.EventHandler(this.G2CmbxReturned_SelectedIndexChanged);
            // 
            // EFReturned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 444);
            this.Controls.Add(this.DGVReturned);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EFReturned";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "EFReturned";
            this.Load += new System.EventHandler(this.EFReturned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVReturned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mReturnedBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DGVReturned;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mReturnedBindingSource;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox G2TxbxReturned;
        private Guna.UI2.WinForms.Guna2ComboBox G2CmbxReturned;
    }
}