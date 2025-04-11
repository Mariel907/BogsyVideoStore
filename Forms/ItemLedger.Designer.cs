namespace Project.Forms
{
    partial class ItemLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemLedger));
            this.G2DGVItemLedger = new Guna.UI2.WinForms.Guna2DataGridView();
            this.documentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getAllItemLedgerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dSReports1 = new Project.DataSet.DSReports();
            this.getAllItemLedgerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSReports = new Project.DataSet.DSReports();
            this.getAllItemLedgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllItemLedgerTableAdapter = new Project.DataSet.DSReportsTableAdapters.GetAllItemLedgerTableAdapter();
            this.G2CmbxLedger = new Guna.UI2.WinForms.Guna2ComboBox();
            this.G2TxbxLedger = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.G2CmbxType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.DTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DTPEndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.G2DGVItemLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllItemLedgerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllItemLedgerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllItemLedgerBindingSource)).BeginInit();
            this.panel21.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // G2DGVItemLedger
            // 
            this.G2DGVItemLedger.AllowUserToAddRows = false;
            this.G2DGVItemLedger.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.G2DGVItemLedger.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.G2DGVItemLedger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G2DGVItemLedger.AutoGenerateColumns = false;
            this.G2DGVItemLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.G2DGVItemLedger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.G2DGVItemLedger.ColumnHeadersHeight = 35;
            this.G2DGVItemLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.G2DGVItemLedger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentNoDataGridViewTextBoxColumn,
            this.videoIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.serialNoDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.G2DGVItemLedger.DataSource = this.getAllItemLedgerBindingSource2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.G2DGVItemLedger.DefaultCellStyle = dataGridViewCellStyle3;
            this.G2DGVItemLedger.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.G2DGVItemLedger.Location = new System.Drawing.Point(11, 104);
            this.G2DGVItemLedger.Margin = new System.Windows.Forms.Padding(4);
            this.G2DGVItemLedger.Name = "G2DGVItemLedger";
            this.G2DGVItemLedger.ReadOnly = true;
            this.G2DGVItemLedger.RowHeadersVisible = false;
            this.G2DGVItemLedger.Size = new System.Drawing.Size(1111, 448);
            this.G2DGVItemLedger.TabIndex = 363;
            this.G2DGVItemLedger.TabStop = false;
            this.G2DGVItemLedger.Tag = "book_id";
            this.G2DGVItemLedger.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.G2DGVItemLedger.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.G2DGVItemLedger.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.G2DGVItemLedger.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.G2DGVItemLedger.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.G2DGVItemLedger.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.G2DGVItemLedger.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.G2DGVItemLedger.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2DGVItemLedger.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.G2DGVItemLedger.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2DGVItemLedger.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.G2DGVItemLedger.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.G2DGVItemLedger.ThemeStyle.HeaderStyle.Height = 35;
            this.G2DGVItemLedger.ThemeStyle.ReadOnly = true;
            this.G2DGVItemLedger.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.G2DGVItemLedger.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.G2DGVItemLedger.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2DGVItemLedger.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.G2DGVItemLedger.ThemeStyle.RowsStyle.Height = 22;
            this.G2DGVItemLedger.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.G2DGVItemLedger.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            // 
            // documentNoDataGridViewTextBoxColumn
            // 
            this.documentNoDataGridViewTextBoxColumn.DataPropertyName = "DocumentNo";
            this.documentNoDataGridViewTextBoxColumn.HeaderText = "Document No.";
            this.documentNoDataGridViewTextBoxColumn.Name = "documentNoDataGridViewTextBoxColumn";
            this.documentNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // videoIDDataGridViewTextBoxColumn
            // 
            this.videoIDDataGridViewTextBoxColumn.DataPropertyName = "VideoID";
            this.videoIDDataGridViewTextBoxColumn.HeaderText = "VideoID";
            this.videoIDDataGridViewTextBoxColumn.Name = "videoIDDataGridViewTextBoxColumn";
            this.videoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.videoIDDataGridViewTextBoxColumn.Visible = false;
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
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serialNoDataGridViewTextBoxColumn
            // 
            this.serialNoDataGridViewTextBoxColumn.DataPropertyName = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "Serial No.";
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            this.serialNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getAllItemLedgerBindingSource2
            // 
            this.getAllItemLedgerBindingSource2.DataMember = "GetAllItemLedger";
            this.getAllItemLedgerBindingSource2.DataSource = this.dSReports1;
            // 
            // dSReports1
            // 
            this.dSReports1.DataSetName = "DSReports";
            this.dSReports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getAllItemLedgerBindingSource1
            // 
            this.getAllItemLedgerBindingSource1.DataMember = "GetAllItemLedger";
            this.getAllItemLedgerBindingSource1.DataSource = this.dSReports;
            // 
            // dSReports
            // 
            this.dSReports.DataSetName = "DSReports";
            this.dSReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getAllItemLedgerBindingSource
            // 
            this.getAllItemLedgerBindingSource.DataMember = "GetAllItemLedger";
            this.getAllItemLedgerBindingSource.DataSource = this.dSReports;
            // 
            // getAllItemLedgerTableAdapter
            // 
            this.getAllItemLedgerTableAdapter.ClearBeforeFill = true;
            // 
            // G2CmbxLedger
            // 
            this.G2CmbxLedger.BackColor = System.Drawing.Color.Transparent;
            this.G2CmbxLedger.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxLedger.BorderThickness = 2;
            this.G2CmbxLedger.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.G2CmbxLedger.DropDownHeight = 150;
            this.G2CmbxLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.G2CmbxLedger.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxLedger.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxLedger.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2CmbxLedger.ForeColor = System.Drawing.Color.Black;
            this.G2CmbxLedger.IntegralHeight = false;
            this.G2CmbxLedger.ItemHeight = 30;
            this.G2CmbxLedger.Items.AddRange(new object[] {
            "DVD",
            "VCD"});
            this.G2CmbxLedger.Location = new System.Drawing.Point(90, 16);
            this.G2CmbxLedger.Name = "G2CmbxLedger";
            this.G2CmbxLedger.Size = new System.Drawing.Size(127, 36);
            this.G2CmbxLedger.TabIndex = 365;
            this.G2CmbxLedger.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBoxReturned_SelectedIndexChanged);
            // 
            // G2TxbxLedger
            // 
            this.G2TxbxLedger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G2TxbxLedger.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2TxbxLedger.BorderThickness = 2;
            this.G2TxbxLedger.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.G2TxbxLedger.DefaultText = "";
            this.G2TxbxLedger.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.G2TxbxLedger.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.G2TxbxLedger.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.G2TxbxLedger.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.G2TxbxLedger.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G2TxbxLedger.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2TxbxLedger.ForeColor = System.Drawing.Color.Black;
            this.G2TxbxLedger.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G2TxbxLedger.IconLeft = ((System.Drawing.Image)(resources.GetObject("G2TxbxLedger.IconLeft")));
            this.G2TxbxLedger.Location = new System.Drawing.Point(13, 60);
            this.G2TxbxLedger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.G2TxbxLedger.Name = "G2TxbxLedger";
            this.G2TxbxLedger.PlaceholderText = "";
            this.G2TxbxLedger.SelectedText = "";
            this.G2TxbxLedger.Size = new System.Drawing.Size(1109, 36);
            this.G2TxbxLedger.TabIndex = 364;
            this.G2TxbxLedger.TextChanged += new System.EventHandler(this.G2TxbxLedger_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 467;
            this.label4.Text = "Type:";
            // 
            // G2CmbxType
            // 
            this.G2CmbxType.BackColor = System.Drawing.Color.Transparent;
            this.G2CmbxType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxType.BorderThickness = 2;
            this.G2CmbxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.G2CmbxType.DropDownHeight = 150;
            this.G2CmbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.G2CmbxType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxType.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2CmbxType.ForeColor = System.Drawing.Color.Black;
            this.G2CmbxType.IntegralHeight = false;
            this.G2CmbxType.ItemHeight = 30;
            this.G2CmbxType.Items.AddRange(new object[] {
            "Return",
            "Purchase ",
            "Sales"});
            this.G2CmbxType.Location = new System.Drawing.Point(273, 17);
            this.G2CmbxType.Name = "G2CmbxType";
            this.G2CmbxType.Size = new System.Drawing.Size(127, 36);
            this.G2CmbxType.TabIndex = 468;
            this.G2CmbxType.SelectedIndexChanged += new System.EventHandler(this.G2CmbxType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 469;
            this.label1.Text = "Category:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(961, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 21);
            this.label3.TabIndex = 494;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(773, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 490;
            this.label2.Text = "From";
            // 
            // panel21
            // 
            this.panel21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel21.Controls.Add(this.panel22);
            this.panel21.Location = new System.Drawing.Point(824, 51);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(127, 2);
            this.panel21.TabIndex = 474;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel22.Location = new System.Drawing.Point(0, -10);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(179, 2);
            this.panel22.TabIndex = 442;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Location = new System.Drawing.Point(826, 47);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(124, 2);
            this.panel11.TabIndex = 485;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel12.Location = new System.Drawing.Point(0, -10);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(179, 2);
            this.panel12.TabIndex = 442;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(995, 47);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(124, 2);
            this.panel9.TabIndex = 475;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel10.Location = new System.Drawing.Point(0, -10);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(179, 2);
            this.panel10.TabIndex = 442;
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Location = new System.Drawing.Point(826, 21);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(124, 2);
            this.panel13.TabIndex = 482;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel14.Location = new System.Drawing.Point(0, -10);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(179, 2);
            this.panel14.TabIndex = 442;
            // 
            // panel15
            // 
            this.panel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Location = new System.Drawing.Point(950, 17);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(2, 36);
            this.panel15.TabIndex = 488;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel16.Location = new System.Drawing.Point(0, -10);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(179, 2);
            this.panel16.TabIndex = 442;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(995, 21);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(124, 2);
            this.panel7.TabIndex = 473;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel8.Location = new System.Drawing.Point(0, -10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(179, 2);
            this.panel8.TabIndex = 442;
            // 
            // panel17
            // 
            this.panel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel17.Controls.Add(this.panel18);
            this.panel17.Location = new System.Drawing.Point(824, 17);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(2, 36);
            this.panel17.TabIndex = 486;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel18.Location = new System.Drawing.Point(0, -10);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(179, 2);
            this.panel18.TabIndex = 442;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(1119, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 36);
            this.panel5.TabIndex = 477;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel6.Location = new System.Drawing.Point(0, -10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(179, 2);
            this.panel6.TabIndex = 442;
            // 
            // panel19
            // 
            this.panel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel19.Controls.Add(this.panel20);
            this.panel19.Location = new System.Drawing.Point(824, 17);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(127, 2);
            this.panel19.TabIndex = 481;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel20.Location = new System.Drawing.Point(0, -10);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(179, 2);
            this.panel20.TabIndex = 442;
            // 
            // panel30
            // 
            this.panel30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel30.Controls.Add(this.panel31);
            this.panel30.Location = new System.Drawing.Point(993, 17);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(2, 36);
            this.panel30.TabIndex = 476;
            // 
            // panel31
            // 
            this.panel31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel31.Location = new System.Drawing.Point(0, -10);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(179, 2);
            this.panel31.TabIndex = 442;
            // 
            // DTPStartDate
            // 
            this.DTPStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DTPStartDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPStartDate.Location = new System.Drawing.Point(824, 22);
            this.DTPStartDate.Name = "DTPStartDate";
            this.DTPStartDate.Size = new System.Drawing.Size(127, 26);
            this.DTPStartDate.TabIndex = 479;
            this.DTPStartDate.Value = new System.DateTime(2025, 3, 25, 14, 14, 8, 0);
            this.DTPStartDate.ValueChanged += new System.EventHandler(this.DTPStartDate_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(994, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 2);
            this.panel2.TabIndex = 472;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel4.Location = new System.Drawing.Point(0, -10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 2);
            this.panel4.TabIndex = 442;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(993, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 2);
            this.panel1.TabIndex = 471;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel3.Location = new System.Drawing.Point(0, -10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 2);
            this.panel3.TabIndex = 442;
            // 
            // DTPEndDate
            // 
            this.DTPEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DTPEndDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPEndDate.Location = new System.Drawing.Point(993, 22);
            this.DTPEndDate.Name = "DTPEndDate";
            this.DTPEndDate.Size = new System.Drawing.Size(127, 26);
            this.DTPEndDate.TabIndex = 470;
            this.DTPEndDate.Value = new System.DateTime(2025, 3, 25, 14, 14, 8, 0);
            this.DTPEndDate.ValueChanged += new System.EventHandler(this.DTPEndDate_ValueChanged);
            // 
            // ItemLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 565);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel30);
            this.Controls.Add(this.DTPStartDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DTPEndDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.G2CmbxType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.G2CmbxLedger);
            this.Controls.Add(this.G2TxbxLedger);
            this.Controls.Add(this.G2DGVItemLedger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemLedger";
            this.Text = "ItemLedger";
            this.Load += new System.EventHandler(this.ItemLedger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.G2DGVItemLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllItemLedgerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllItemLedgerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllItemLedgerBindingSource)).EndInit();
            this.panel21.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView G2DGVItemLedger;
        private DataSet.DSReports dSReports;
        private System.Windows.Forms.BindingSource getAllItemLedgerBindingSource;
        private DataSet.DSReportsTableAdapters.GetAllItemLedgerTableAdapter getAllItemLedgerTableAdapter;
        private System.Windows.Forms.BindingSource getAllItemLedgerBindingSource1;
        private DataSet.DSReports dSReports1;
        private System.Windows.Forms.BindingSource getAllItemLedgerBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2ComboBox G2CmbxLedger;
        private Guna.UI2.WinForms.Guna2TextBox G2TxbxLedger;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox G2CmbxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.DateTimePicker DTPStartDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker DTPEndDate;
    }
}