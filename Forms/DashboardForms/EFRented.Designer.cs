namespace Project.Forms.DashboardForms
{
    partial class EFRented
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EFRented));
            this.DGVRented = new Guna.UI2.WinForms.Guna2DataGridView();
            this.G2TxbxRented = new Guna.UI2.WinForms.Guna2TextBox();
            this.G2CmbxRented = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRentedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRented)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRentedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVRented
            // 
            this.DGVRented.AllowUserToAddRows = false;
            this.DGVRented.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVRented.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVRented.AutoGenerateColumns = false;
            this.DGVRented.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRented.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVRented.ColumnHeadersHeight = 35;
            this.DGVRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVRented.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullnameDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.serialNoDataGridViewTextBoxColumn,
            this.rentDateDataGridViewTextBoxColumn});
            this.DGVRented.DataSource = this.mRentedBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVRented.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVRented.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVRented.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVRented.Location = new System.Drawing.Point(10, 62);
            this.DGVRented.Margin = new System.Windows.Forms.Padding(4);
            this.DGVRented.Name = "DGVRented";
            this.DGVRented.ReadOnly = true;
            this.DGVRented.RowHeadersVisible = false;
            this.DGVRented.Size = new System.Drawing.Size(1001, 372);
            this.DGVRented.TabIndex = 380;
            this.DGVRented.Tag = "book_id";
            this.DGVRented.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVRented.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVRented.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVRented.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVRented.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVRented.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVRented.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVRented.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.DGVRented.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVRented.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVRented.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVRented.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVRented.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVRented.ThemeStyle.ReadOnly = true;
            this.DGVRented.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.DGVRented.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVRented.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVRented.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVRented.ThemeStyle.RowsStyle.Height = 22;
            this.DGVRented.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.DGVRented.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            // 
            // G2TxbxRented
            // 
            this.G2TxbxRented.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G2TxbxRented.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2TxbxRented.BorderThickness = 2;
            this.G2TxbxRented.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.G2TxbxRented.DefaultText = "";
            this.G2TxbxRented.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.G2TxbxRented.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.G2TxbxRented.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.G2TxbxRented.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.G2TxbxRented.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G2TxbxRented.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2TxbxRented.ForeColor = System.Drawing.Color.Black;
            this.G2TxbxRented.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G2TxbxRented.IconLeft = ((System.Drawing.Image)(resources.GetObject("G2TxbxRented.IconLeft")));
            this.G2TxbxRented.Location = new System.Drawing.Point(147, 19);
            this.G2TxbxRented.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.G2TxbxRented.Name = "G2TxbxRented";
            this.G2TxbxRented.PlaceholderText = "";
            this.G2TxbxRented.SelectedText = "";
            this.G2TxbxRented.Size = new System.Drawing.Size(860, 36);
            this.G2TxbxRented.TabIndex = 381;
            this.G2TxbxRented.TextChanged += new System.EventHandler(this.G2TxbxRented_TextChanged);
            // 
            // G2CmbxRented
            // 
            this.G2CmbxRented.BackColor = System.Drawing.Color.Transparent;
            this.G2CmbxRented.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxRented.BorderThickness = 2;
            this.G2CmbxRented.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.G2CmbxRented.DropDownHeight = 150;
            this.G2CmbxRented.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.G2CmbxRented.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxRented.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxRented.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2CmbxRented.ForeColor = System.Drawing.Color.Black;
            this.G2CmbxRented.IntegralHeight = false;
            this.G2CmbxRented.ItemHeight = 30;
            this.G2CmbxRented.Items.AddRange(new object[] {
            "DVD",
            "VCD"});
            this.G2CmbxRented.Location = new System.Drawing.Point(13, 19);
            this.G2CmbxRented.Name = "G2CmbxRented";
            this.G2CmbxRented.Size = new System.Drawing.Size(127, 36);
            this.G2CmbxRented.TabIndex = 382;
            this.G2CmbxRented.SelectedIndexChanged += new System.EventHandler(this.G2CmbxRented_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 52);
            this.panel1.TabIndex = 383;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // rentDateDataGridViewTextBoxColumn
            // 
            this.rentDateDataGridViewTextBoxColumn.DataPropertyName = "RentDate";
            this.rentDateDataGridViewTextBoxColumn.HeaderText = "Rent Date";
            this.rentDateDataGridViewTextBoxColumn.Name = "rentDateDataGridViewTextBoxColumn";
            this.rentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mRentedBindingSource
            // 
            this.mRentedBindingSource.DataSource = typeof(Project.Model.MRented);
            // 
            // EFRented
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 444);
            this.Controls.Add(this.G2TxbxRented);
            this.Controls.Add(this.G2CmbxRented);
            this.Controls.Add(this.DGVRented);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EFRented";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "EFRented";
            this.Load += new System.EventHandler(this.EFRented_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRented)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRentedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DGVRented;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mRentedBindingSource;
        private Guna.UI2.WinForms.Guna2TextBox G2TxbxRented;
        private Guna.UI2.WinForms.Guna2ComboBox G2CmbxRented;
        private System.Windows.Forms.Panel panel1;
    }
}