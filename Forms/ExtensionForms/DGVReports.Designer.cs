namespace Project.Forms.ExtensionForms
{
    partial class DGVReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DGVReports));
            this.guna2DataGridViewReports = new Guna.UI2.WinForms.Guna2DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copiesAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSReports = new Project.DataSet.DSReports();
            this.reportsTableAdapter = new Project.DataSet.DSReportsTableAdapters.ReportsTableAdapter();
            this.guna2ComboBoxReports = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TextBoxReports = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DataGridViewReports
            // 
            this.guna2DataGridViewReports.AllowUserToAddRows = false;
            this.guna2DataGridViewReports.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridViewReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridViewReports.AutoGenerateColumns = false;
            this.guna2DataGridViewReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridViewReports.ColumnHeadersHeight = 35;
            this.guna2DataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.copiesAvailableDataGridViewTextBoxColumn,
            this.rentedDataGridViewTextBoxColumn});
            this.guna2DataGridViewReports.DataSource = this.reportsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewReports.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridViewReports.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewReports.Location = new System.Drawing.Point(13, 69);
            this.guna2DataGridViewReports.Margin = new System.Windows.Forms.Padding(4);
            this.guna2DataGridViewReports.Name = "guna2DataGridViewReports";
            this.guna2DataGridViewReports.ReadOnly = true;
            this.guna2DataGridViewReports.RowHeadersVisible = false;
            this.guna2DataGridViewReports.Size = new System.Drawing.Size(1090, 406);
            this.guna2DataGridViewReports.TabIndex = 226;
            this.guna2DataGridViewReports.Tag = "book_id";
            this.guna2DataGridViewReports.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewReports.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridViewReports.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewReports.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewReports.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewReports.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewReports.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewReports.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2DataGridViewReports.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewReports.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewReports.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewReports.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewReports.ThemeStyle.HeaderStyle.Height = 35;
            this.guna2DataGridViewReports.ThemeStyle.ReadOnly = true;
            this.guna2DataGridViewReports.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.guna2DataGridViewReports.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewReports.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewReports.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewReports.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridViewReports.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.guna2DataGridViewReports.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
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
            // copiesAvailableDataGridViewTextBoxColumn
            // 
            this.copiesAvailableDataGridViewTextBoxColumn.DataPropertyName = "CopiesAvailable";
            this.copiesAvailableDataGridViewTextBoxColumn.HeaderText = "Copies Available";
            this.copiesAvailableDataGridViewTextBoxColumn.Name = "copiesAvailableDataGridViewTextBoxColumn";
            this.copiesAvailableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentedDataGridViewTextBoxColumn
            // 
            this.rentedDataGridViewTextBoxColumn.DataPropertyName = "Rented";
            this.rentedDataGridViewTextBoxColumn.HeaderText = "Rented";
            this.rentedDataGridViewTextBoxColumn.Name = "rentedDataGridViewTextBoxColumn";
            this.rentedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportsBindingSource
            // 
            this.reportsBindingSource.DataMember = "Reports";
            this.reportsBindingSource.DataSource = this.dSReportsBindingSource;
            // 
            // dSReportsBindingSource
            // 
            this.dSReportsBindingSource.DataSource = this.dSReports;
            this.dSReportsBindingSource.Position = 0;
            // 
            // dSReports
            // 
            this.dSReports.DataSetName = "DSReports";
            this.dSReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportsTableAdapter
            // 
            this.reportsTableAdapter.ClearBeforeFill = true;
            // 
            // guna2ComboBoxReports
            // 
            this.guna2ComboBoxReports.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxReports.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxReports.BorderThickness = 2;
            this.guna2ComboBoxReports.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxReports.DropDownHeight = 150;
            this.guna2ComboBoxReports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxReports.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxReports.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxReports.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBoxReports.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBoxReports.IntegralHeight = false;
            this.guna2ComboBoxReports.ItemHeight = 30;
            this.guna2ComboBoxReports.Items.AddRange(new object[] {
            "DVD",
            "VCD"});
            this.guna2ComboBoxReports.Location = new System.Drawing.Point(13, 25);
            this.guna2ComboBoxReports.Name = "guna2ComboBoxReports";
            this.guna2ComboBoxReports.Size = new System.Drawing.Size(177, 36);
            this.guna2ComboBoxReports.TabIndex = 244;
            this.guna2ComboBoxReports.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBoxReports_SelectedIndexChanged);
            // 
            // guna2TextBoxReports
            // 
            this.guna2TextBoxReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBoxReports.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxReports.BorderThickness = 2;
            this.guna2TextBoxReports.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxReports.DefaultText = "";
            this.guna2TextBoxReports.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxReports.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxReports.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxReports.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBoxReports.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxReports.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxReports.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBoxReports.IconLeft")));
            this.guna2TextBoxReports.Location = new System.Drawing.Point(197, 25);
            this.guna2TextBoxReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBoxReports.Name = "guna2TextBoxReports";
            this.guna2TextBoxReports.PlaceholderText = "";
            this.guna2TextBoxReports.SelectedText = "";
            this.guna2TextBoxReports.Size = new System.Drawing.Size(906, 36);
            this.guna2TextBoxReports.TabIndex = 243;
            this.guna2TextBoxReports.TextChanged += new System.EventHandler(this.guna2TextBoxReports_TextChanged);
            // 
            // DGVReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 488);
            this.Controls.Add(this.guna2ComboBoxReports);
            this.Controls.Add(this.guna2TextBoxReports);
            this.Controls.Add(this.guna2DataGridViewReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DGVReports";
            this.Text = "DGVReports";
            this.Load += new System.EventHandler(this.DGVReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewReports;
        private System.Windows.Forms.BindingSource dSReportsBindingSource;
        private DataSet.DSReports dSReports;
        private System.Windows.Forms.BindingSource reportsBindingSource;
        private DataSet.DSReportsTableAdapters.ReportsTableAdapter reportsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn copiesAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentedDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxReports;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxReports;
    }
}