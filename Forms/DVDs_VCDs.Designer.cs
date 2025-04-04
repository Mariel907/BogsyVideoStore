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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DVDs_VCDs));
            this.guna2ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2ButtonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.dgvDVD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.VideoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopiesAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountToRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitDaysRentedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getAllDVDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSReports = new Project.DataSet.DSReports();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ButtonVCD = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonDVD = new Guna.UI2.WinForms.Guna2Button();
            this.dgvVCD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.VCDVideoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VCDTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VCDCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VCDCopiesAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getAllVCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllDVDTableAdapter = new Project.DataSet.DSReportsTableAdapters.GetAllDVDTableAdapter();
            this.getAllVCDTableAdapter = new Project.DataSet.DSReportsTableAdapters.GetAllVCDTableAdapter();
            this.guna2TextBoxDVD = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxVCD = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllDVDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllVCDBindingSource)).BeginInit();
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
            // dgvDVD
            // 
            this.dgvDVD.AllowUserToAddRows = false;
            this.dgvDVD.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDVD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDVD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDVD.AutoGenerateColumns = false;
            this.dgvDVD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDVD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDVD.ColumnHeadersHeight = 35;
            this.dgvDVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDVD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VideoID,
            this.Title,
            this.Category,
            this.CopiesAvailable,
            this.outDataGridViewTextBoxColumn,
            this.amountToRentDataGridViewTextBoxColumn,
            this.limitDaysRentedDataGridViewTextBoxColumn});
            this.dgvDVD.DataSource = this.getAllDVDBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDVD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDVD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDVD.Location = new System.Drawing.Point(13, 57);
            this.dgvDVD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDVD.Name = "dgvDVD";
            this.dgvDVD.ReadOnly = true;
            this.dgvDVD.RowHeadersVisible = false;
            this.dgvDVD.Size = new System.Drawing.Size(1093, 377);
            this.dgvDVD.TabIndex = 232;
            this.dgvDVD.Tag = "book_id";
            this.dgvDVD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDVD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDVD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDVD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDVD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDVD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDVD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDVD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.dgvDVD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDVD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDVD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDVD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDVD.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvDVD.ThemeStyle.ReadOnly = true;
            this.dgvDVD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.dgvDVD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDVD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDVD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDVD.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDVD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.dgvDVD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
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
            // amountToRentDataGridViewTextBoxColumn
            // 
            this.amountToRentDataGridViewTextBoxColumn.DataPropertyName = "AmountToRent";
            this.amountToRentDataGridViewTextBoxColumn.HeaderText = "Price";
            this.amountToRentDataGridViewTextBoxColumn.Name = "amountToRentDataGridViewTextBoxColumn";
            this.amountToRentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // limitDaysRentedDataGridViewTextBoxColumn
            // 
            this.limitDaysRentedDataGridViewTextBoxColumn.DataPropertyName = "LimitDaysRented";
            this.limitDaysRentedDataGridViewTextBoxColumn.HeaderText = "Limit Days Rented";
            this.limitDaysRentedDataGridViewTextBoxColumn.Name = "limitDaysRentedDataGridViewTextBoxColumn";
            this.limitDaysRentedDataGridViewTextBoxColumn.ReadOnly = true;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 243;
            this.label1.Text = "Table";
            // 
            // guna2ButtonVCD
            // 
            this.guna2ButtonVCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2ButtonVCD.BorderRadius = 15;
            this.guna2ButtonVCD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonVCD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonVCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonVCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonVCD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ButtonVCD.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonVCD.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonVCD.Location = new System.Drawing.Point(142, 468);
            this.guna2ButtonVCD.Name = "guna2ButtonVCD";
            this.guna2ButtonVCD.Size = new System.Drawing.Size(123, 46);
            this.guna2ButtonVCD.TabIndex = 242;
            this.guna2ButtonVCD.Text = "VCD";
            this.guna2ButtonVCD.Click += new System.EventHandler(this.Guna2ButtonVCD_Click);
            // 
            // guna2ButtonDVD
            // 
            this.guna2ButtonDVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2ButtonDVD.BorderRadius = 15;
            this.guna2ButtonDVD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDVD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDVD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonDVD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonDVD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.guna2ButtonDVD.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonDVD.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonDVD.Location = new System.Drawing.Point(13, 468);
            this.guna2ButtonDVD.Name = "guna2ButtonDVD";
            this.guna2ButtonDVD.Size = new System.Drawing.Size(123, 46);
            this.guna2ButtonDVD.TabIndex = 241;
            this.guna2ButtonDVD.Text = "DVD";
            this.guna2ButtonDVD.Click += new System.EventHandler(this.Guna2ButtonDVD_Click);
            // 
            // dgvVCD
            // 
            this.dgvVCD.AllowUserToAddRows = false;
            this.dgvVCD.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvVCD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVCD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVCD.AutoGenerateColumns = false;
            this.dgvVCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVCD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVCD.ColumnHeadersHeight = 35;
            this.dgvVCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVCD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VCDVideoID,
            this.VCDTitle,
            this.VCDCategory,
            this.VCDCopiesAvailable,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvVCD.DataSource = this.getAllVCDBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVCD.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVCD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVCD.Location = new System.Drawing.Point(27, 57);
            this.dgvVCD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVCD.Name = "dgvVCD";
            this.dgvVCD.ReadOnly = true;
            this.dgvVCD.RowHeadersVisible = false;
            this.dgvVCD.Size = new System.Drawing.Size(1046, 377);
            this.dgvVCD.TabIndex = 244;
            this.dgvVCD.Tag = "book_id";
            this.dgvVCD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVCD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVCD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVCD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVCD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVCD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVCD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVCD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.dgvVCD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVCD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVCD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVCD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVCD.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvVCD.ThemeStyle.ReadOnly = true;
            this.dgvVCD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.dgvVCD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVCD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVCD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVCD.ThemeStyle.RowsStyle.Height = 22;
            this.dgvVCD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.dgvVCD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            // 
            // VCDVideoID
            // 
            this.VCDVideoID.DataPropertyName = "VideoID";
            this.VCDVideoID.HeaderText = "VideoID";
            this.VCDVideoID.Name = "VCDVideoID";
            this.VCDVideoID.ReadOnly = true;
            this.VCDVideoID.Visible = false;
            // 
            // VCDTitle
            // 
            this.VCDTitle.DataPropertyName = "Title";
            this.VCDTitle.HeaderText = "Title";
            this.VCDTitle.Name = "VCDTitle";
            this.VCDTitle.ReadOnly = true;
            // 
            // VCDCategory
            // 
            this.VCDCategory.DataPropertyName = "Category";
            this.VCDCategory.HeaderText = "Category";
            this.VCDCategory.Name = "VCDCategory";
            this.VCDCategory.ReadOnly = true;
            // 
            // VCDCopiesAvailable
            // 
            this.VCDCopiesAvailable.DataPropertyName = "CopiesAvailable";
            this.VCDCopiesAvailable.HeaderText = "Copies Available";
            this.VCDCopiesAvailable.Name = "VCDCopiesAvailable";
            this.VCDCopiesAvailable.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Out";
            this.dataGridViewTextBoxColumn5.HeaderText = "Rented";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AmountToRent";
            this.dataGridViewTextBoxColumn6.HeaderText = "Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LimitDaysRented";
            this.dataGridViewTextBoxColumn7.HeaderText = "Limit Days Rented";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
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
            // guna2TextBoxDVD
            // 
            this.guna2TextBoxDVD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBoxDVD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxDVD.BorderThickness = 2;
            this.guna2TextBoxDVD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxDVD.DefaultText = "";
            this.guna2TextBoxDVD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxDVD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxDVD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxDVD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxDVD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxDVD.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBoxDVD.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxDVD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxDVD.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBoxDVD.IconLeft")));
            this.guna2TextBoxDVD.Location = new System.Drawing.Point(13, 13);
            this.guna2TextBoxDVD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBoxDVD.Name = "guna2TextBoxDVD";
            this.guna2TextBoxDVD.PlaceholderText = "";
            this.guna2TextBoxDVD.SelectedText = "";
            this.guna2TextBoxDVD.Size = new System.Drawing.Size(1093, 36);
            this.guna2TextBoxDVD.TabIndex = 245;
            this.guna2TextBoxDVD.TextChanged += new System.EventHandler(this.Guna2TextBoxDVD_TextChanged);
            // 
            // guna2TextBoxVCD
            // 
            this.guna2TextBoxVCD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBoxVCD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxVCD.BorderThickness = 2;
            this.guna2TextBoxVCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxVCD.DefaultText = "";
            this.guna2TextBoxVCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxVCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxVCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxVCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxVCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxVCD.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBoxVCD.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxVCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxVCD.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBoxVCD.IconLeft")));
            this.guna2TextBoxVCD.Location = new System.Drawing.Point(13, 13);
            this.guna2TextBoxVCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBoxVCD.Name = "guna2TextBoxVCD";
            this.guna2TextBoxVCD.PlaceholderText = "";
            this.guna2TextBoxVCD.SelectedText = "";
            this.guna2TextBoxVCD.Size = new System.Drawing.Size(1093, 36);
            this.guna2TextBoxVCD.TabIndex = 246;
            this.guna2TextBoxVCD.TextChanged += new System.EventHandler(this.Guna2TextBoxVCD_TextChanged);
            // 
            // DVDs_VCDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 526);
            this.Controls.Add(this.guna2TextBoxVCD);
            this.Controls.Add(this.guna2TextBoxDVD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ButtonVCD);
            this.Controls.Add(this.guna2ButtonDVD);
            this.Controls.Add(this.dgvDVD);
            this.Controls.Add(this.Guna2ButtonDelete);
            this.Controls.Add(this.guna2ButtonEdit);
            this.Controls.Add(this.guna2ButtonAdd);
            this.Controls.Add(this.dgvVCD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DVDs_VCDs";
            this.Text = "DVDs_VCDs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DVDs_VCDs_FormClosing);
            this.Load += new System.EventHandler(this.DVDs_VCDs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllDVDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllVCDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAdd;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonEdit;
        private Guna.UI2.WinForms.Guna2Button Guna2ButtonDelete;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDVD;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonVCD;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDVD;
        private DataSet.DSReports dSReports;
        private System.Windows.Forms.BindingSource getAllDVDBindingSource;
        private DataSet.DSReportsTableAdapters.GetAllDVDTableAdapter getAllDVDTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVCD;
        private System.Windows.Forms.BindingSource getAllVCDBindingSource;
        private DataSet.DSReportsTableAdapters.GetAllVCDTableAdapter getAllVCDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn VCDVideoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VCDTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn VCDCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn VCDCopiesAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopiesAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountToRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitDaysRentedDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxDVD;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxVCD;
    }
}