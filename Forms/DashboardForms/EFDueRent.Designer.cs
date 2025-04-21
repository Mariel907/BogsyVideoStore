namespace Project.Forms.DashboardForms
{
    partial class EFDueRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EFDueRent));
            this.DGVDueRent = new Guna.UI2.WinForms.Guna2DataGridView();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDueRentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.G2TxbxDueDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.G2CmbxDueDate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDueRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDueRentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVDueRent
            // 
            this.DGVDueRent.AllowUserToAddRows = false;
            this.DGVDueRent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVDueRent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDueRent.AutoGenerateColumns = false;
            this.DGVDueRent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDueRent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDueRent.ColumnHeadersHeight = 35;
            this.DGVDueRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVDueRent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullnameDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn});
            this.DGVDueRent.DataSource = this.mDueRentBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDueRent.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDueRent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDueRent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVDueRent.Location = new System.Drawing.Point(10, 62);
            this.DGVDueRent.Margin = new System.Windows.Forms.Padding(4);
            this.DGVDueRent.Name = "DGVDueRent";
            this.DGVDueRent.ReadOnly = true;
            this.DGVDueRent.RowHeadersVisible = false;
            this.DGVDueRent.Size = new System.Drawing.Size(1001, 372);
            this.DGVDueRent.TabIndex = 380;
            this.DGVDueRent.Tag = "book_id";
            this.DGVDueRent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVDueRent.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVDueRent.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVDueRent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVDueRent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVDueRent.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVDueRent.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVDueRent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.DGVDueRent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVDueRent.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVDueRent.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVDueRent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVDueRent.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVDueRent.ThemeStyle.ReadOnly = true;
            this.DGVDueRent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.DGVDueRent.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDueRent.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVDueRent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVDueRent.ThemeStyle.RowsStyle.Height = 22;
            this.DGVDueRent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.DGVDueRent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
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
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mDueRentBindingSource
            // 
            this.mDueRentBindingSource.DataSource = typeof(Project.Model.MDueRent);
            // 
            // G2TxbxDueDate
            // 
            this.G2TxbxDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G2TxbxDueDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2TxbxDueDate.BorderThickness = 2;
            this.G2TxbxDueDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.G2TxbxDueDate.DefaultText = "";
            this.G2TxbxDueDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.G2TxbxDueDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.G2TxbxDueDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.G2TxbxDueDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.G2TxbxDueDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G2TxbxDueDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2TxbxDueDate.ForeColor = System.Drawing.Color.Black;
            this.G2TxbxDueDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G2TxbxDueDate.IconLeft = ((System.Drawing.Image)(resources.GetObject("G2TxbxDueDate.IconLeft")));
            this.G2TxbxDueDate.Location = new System.Drawing.Point(134, 9);
            this.G2TxbxDueDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.G2TxbxDueDate.Name = "G2TxbxDueDate";
            this.G2TxbxDueDate.PlaceholderText = "";
            this.G2TxbxDueDate.SelectedText = "";
            this.G2TxbxDueDate.Size = new System.Drawing.Size(867, 36);
            this.G2TxbxDueDate.TabIndex = 384;
            this.G2TxbxDueDate.TextChanged += new System.EventHandler(this.G2TxbxDueDate_TextChanged);
            // 
            // G2CmbxDueDate
            // 
            this.G2CmbxDueDate.BackColor = System.Drawing.Color.Transparent;
            this.G2CmbxDueDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxDueDate.BorderThickness = 2;
            this.G2CmbxDueDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.G2CmbxDueDate.DropDownHeight = 150;
            this.G2CmbxDueDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.G2CmbxDueDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxDueDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxDueDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2CmbxDueDate.ForeColor = System.Drawing.Color.Black;
            this.G2CmbxDueDate.IntegralHeight = false;
            this.G2CmbxDueDate.ItemHeight = 30;
            this.G2CmbxDueDate.Items.AddRange(new object[] {
            "DVD",
            "VCD"});
            this.G2CmbxDueDate.Location = new System.Drawing.Point(0, 9);
            this.G2CmbxDueDate.Name = "G2CmbxDueDate";
            this.G2CmbxDueDate.Size = new System.Drawing.Size(127, 36);
            this.G2CmbxDueDate.TabIndex = 385;
            this.G2CmbxDueDate.SelectedIndexChanged += new System.EventHandler(this.G2CmbxDueDate_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.G2TxbxDueDate);
            this.panel1.Controls.Add(this.G2CmbxDueDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 52);
            this.panel1.TabIndex = 387;
            // 
            // EFDueRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 444);
            this.Controls.Add(this.DGVDueRent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EFDueRent";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "EFDueRent";
            this.Load += new System.EventHandler(this.EFDueRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDueRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDueRentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DGVDueRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mDueRentBindingSource;
        private Guna.UI2.WinForms.Guna2TextBox G2TxbxDueDate;
        private Guna.UI2.WinForms.Guna2ComboBox G2CmbxDueDate;
        private System.Windows.Forms.Panel panel1;
    }
}