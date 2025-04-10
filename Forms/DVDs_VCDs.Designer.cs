namespace Project.Forms
{
    partial class DVDs_VCDs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DVDs_VCDs));
            this.guna2ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2ButtonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.dgvVideo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.VideoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopiesAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimitDaysRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getAllDVDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSReports = new Project.DataSet.DSReports();
            this.getAllVCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllDVDTableAdapter = new Project.DataSet.DSReportsTableAdapters.GetAllDVDTableAdapter();
            this.getAllVCDTableAdapter = new Project.DataSet.DSReportsTableAdapters.GetAllVCDTableAdapter();
            this.guna2TextBoxVideo = new Guna.UI2.WinForms.Guna2TextBox();
            this.G2CmbxVideo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dSTransaction = new Project.DataSet.DSTransaction();
            this.getAllVideoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllVideoTableAdapter = new Project.DataSet.DSTransactionTableAdapters.GetAllVideoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllDVDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllVCDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllVideoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ButtonAdd
            // 
            this.guna2ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ButtonAdd.BorderRadius = 15;
            this.guna2ButtonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ButtonAdd.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonAdd.Location = new System.Drawing.Point(725, 468);
            this.guna2ButtonAdd.Name = "guna2ButtonAdd";
            this.guna2ButtonAdd.Size = new System.Drawing.Size(123, 46);
            this.guna2ButtonAdd.TabIndex = 213;
            this.guna2ButtonAdd.Text = "Add";
            this.guna2ButtonAdd.Click += new System.EventHandler(this.Guna2ButtonAdd_Click);
            // 
            // guna2ButtonEdit
            // 
            this.guna2ButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ButtonEdit.BorderRadius = 15;
            this.guna2ButtonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ButtonEdit.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonEdit.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonEdit.Location = new System.Drawing.Point(854, 468);
            this.guna2ButtonEdit.Name = "guna2ButtonEdit";
            this.guna2ButtonEdit.Size = new System.Drawing.Size(123, 46);
            this.guna2ButtonEdit.TabIndex = 214;
            this.guna2ButtonEdit.Text = "Edit";
            this.guna2ButtonEdit.Click += new System.EventHandler(this.Guna2ButtonEdit_Click);
            // 
            // Guna2ButtonDelete
            // 
            this.Guna2ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2ButtonDelete.BorderRadius = 15;
            this.Guna2ButtonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2ButtonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2ButtonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2ButtonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2ButtonDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.Guna2ButtonDelete.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.Guna2ButtonDelete.Location = new System.Drawing.Point(983, 468);
            this.Guna2ButtonDelete.Name = "Guna2ButtonDelete";
            this.Guna2ButtonDelete.Size = new System.Drawing.Size(123, 46);
            this.Guna2ButtonDelete.TabIndex = 217;
            this.Guna2ButtonDelete.Text = "Delete";
            this.Guna2ButtonDelete.Click += new System.EventHandler(this.Guna2ButtonDelete_Click);
            // 
            // dgvVideo
            // 
            this.dgvVideo.AllowUserToAddRows = false;
            this.dgvVideo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvVideo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVideo.AutoGenerateColumns = false;
            this.dgvVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVideo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVideo.ColumnHeadersHeight = 35;
            this.dgvVideo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVideo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VideoID,
            this.Title,
            this.Category,
            this.CopiesAvailable,
            this.outDataGridViewTextBoxColumn,
            this.LimitDaysRented});
            this.dgvVideo.DataSource = this.getAllVideoBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVideo.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVideo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVideo.Location = new System.Drawing.Point(14, 56);
            this.dgvVideo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVideo.Name = "dgvVideo";
            this.dgvVideo.ReadOnly = true;
            this.dgvVideo.RowHeadersVisible = false;
            this.dgvVideo.Size = new System.Drawing.Size(1093, 405);
            this.dgvVideo.TabIndex = 232;
            this.dgvVideo.Tag = "book_id";
            this.dgvVideo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVideo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVideo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVideo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVideo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVideo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVideo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVideo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.dgvVideo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVideo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVideo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVideo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVideo.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvVideo.ThemeStyle.ReadOnly = true;
            this.dgvVideo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.dgvVideo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVideo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVideo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVideo.ThemeStyle.RowsStyle.Height = 22;
            this.dgvVideo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.dgvVideo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            // 
            // VideoID
            // 
            this.VideoID.DataPropertyName = "VideoID";
            this.VideoID.HeaderText = "VideoID";
            this.VideoID.Name = "VideoID";
            this.VideoID.ReadOnly = true;
            this.VideoID.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // CopiesAvailable
            // 
            this.CopiesAvailable.DataPropertyName = "CopiesAvailable";
            this.CopiesAvailable.HeaderText = "Copies Available";
            this.CopiesAvailable.Name = "CopiesAvailable";
            this.CopiesAvailable.ReadOnly = true;
            // 
            // outDataGridViewTextBoxColumn
            // 
            this.outDataGridViewTextBoxColumn.DataPropertyName = "Out";
            this.outDataGridViewTextBoxColumn.HeaderText = "Rented";
            this.outDataGridViewTextBoxColumn.Name = "outDataGridViewTextBoxColumn";
            this.outDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LimitDaysRented
            // 
            this.LimitDaysRented.DataPropertyName = "LimitDaysRented";
            this.LimitDaysRented.HeaderText = "Limit Days Rented";
            this.LimitDaysRented.Name = "LimitDaysRented";
            this.LimitDaysRented.ReadOnly = true;
            // 
            // getAllDVDBindingSource
            // 
            this.getAllDVDBindingSource.DataMember = "GetAllDVD";
            this.getAllDVDBindingSource.DataSource = this.dSReports;
            // 
            // dSReports
            // 
            this.dSReports.DataSetName = "DSReports";
            this.dSReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getAllVCDBindingSource
            // 
            this.getAllVCDBindingSource.DataMember = "GetAllVCD";
            this.getAllVCDBindingSource.DataSource = this.dSReports;
            // 
            // getAllDVDTableAdapter
            // 
            this.getAllDVDTableAdapter.ClearBeforeFill = true;
            // 
            // getAllVCDTableAdapter
            // 
            this.getAllVCDTableAdapter.ClearBeforeFill = true;
            // 
            // guna2TextBoxVideo
            // 
            this.guna2TextBoxVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBoxVideo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxVideo.BorderThickness = 2;
            this.guna2TextBoxVideo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxVideo.DefaultText = "";
            this.guna2TextBoxVideo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxVideo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxVideo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxVideo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxVideo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxVideo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBoxVideo.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxVideo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxVideo.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBoxVideo.IconLeft")));
            this.guna2TextBoxVideo.Location = new System.Drawing.Point(178, 13);
            this.guna2TextBoxVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBoxVideo.Name = "guna2TextBoxVideo";
            this.guna2TextBoxVideo.PlaceholderText = "";
            this.guna2TextBoxVideo.SelectedText = "";
            this.guna2TextBoxVideo.Size = new System.Drawing.Size(929, 36);
            this.guna2TextBoxVideo.TabIndex = 245;
            this.guna2TextBoxVideo.TextChanged += new System.EventHandler(this.Guna2TextBoxDVD_TextChanged);
            // 
            // G2CmbxVideo
            // 
            this.G2CmbxVideo.BackColor = System.Drawing.Color.Transparent;
            this.G2CmbxVideo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxVideo.BorderThickness = 2;
            this.G2CmbxVideo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.G2CmbxVideo.DropDownHeight = 150;
            this.G2CmbxVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.G2CmbxVideo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxVideo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxVideo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2CmbxVideo.ForeColor = System.Drawing.Color.Black;
            this.G2CmbxVideo.IntegralHeight = false;
            this.G2CmbxVideo.ItemHeight = 30;
            this.G2CmbxVideo.Items.AddRange(new object[] {
            "DVD",
            "VCD"});
            this.G2CmbxVideo.Location = new System.Drawing.Point(14, 13);
            this.G2CmbxVideo.Name = "G2CmbxVideo";
            this.G2CmbxVideo.Size = new System.Drawing.Size(156, 36);
            this.G2CmbxVideo.TabIndex = 248;
            this.G2CmbxVideo.SelectedIndexChanged += new System.EventHandler(this.G2CmbxVideo_SelectedIndexChanged);
            // 
            // dSTransaction
            // 
            this.dSTransaction.DataSetName = "DSTransaction";
            this.dSTransaction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getAllVideoBindingSource
            // 
            this.getAllVideoBindingSource.DataMember = "GetAllVideo";
            this.getAllVideoBindingSource.DataSource = this.dSTransaction;
            // 
            // getAllVideoTableAdapter
            // 
            this.getAllVideoTableAdapter.ClearBeforeFill = true;
            // 
            // DVDs_VCDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 526);
            this.Controls.Add(this.G2CmbxVideo);
            this.Controls.Add(this.guna2TextBoxVideo);
            this.Controls.Add(this.dgvVideo);
            this.Controls.Add(this.Guna2ButtonDelete);
            this.Controls.Add(this.guna2ButtonEdit);
            this.Controls.Add(this.guna2ButtonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DVDs_VCDs";
            this.Text = "DVDs_VCDs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DVDs_VCDs_FormClosing);
            this.Load += new System.EventHandler(this.DVDs_VCDs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllDVDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllVCDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllVideoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAdd;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonEdit;
        private Guna.UI2.WinForms.Guna2Button Guna2ButtonDelete;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVideo;
        private DataSet.DSReports dSReports;
        private System.Windows.Forms.BindingSource getAllDVDBindingSource;
        private DataSet.DSReportsTableAdapters.GetAllDVDTableAdapter getAllDVDTableAdapter;
        private System.Windows.Forms.BindingSource getAllVCDBindingSource;
        private DataSet.DSReportsTableAdapters.GetAllVCDTableAdapter getAllVCDTableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopiesAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimitDaysRented;
        private Guna.UI2.WinForms.Guna2ComboBox G2CmbxVideo;
        private DataSet.DSTransaction dSTransaction;
        private System.Windows.Forms.BindingSource getAllVideoBindingSource;
        private DataSet.DSTransactionTableAdapters.GetAllVideoTableAdapter getAllVideoTableAdapter;
    }
}