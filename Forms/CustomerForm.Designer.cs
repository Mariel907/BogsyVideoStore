namespace Project.Forms
{
    partial class CustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.guna2ButtonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridViewCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getAllCustomerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dSReports = new Project.DataSet.DSReports();
            this.guna2TextBoxCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBoxLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxFirstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ButtonCreateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.getAllCustomerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.getAllCustomerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.getAllCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllCustomerTableAdapter = new Project.DataSet.DSReportsTableAdapters.GetAllCustomerTableAdapter();
            this.guna2ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2ButtonSaveEdit = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TextBoxEditFirstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxEditLastname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2TextBoxID = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelEdit = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllCustomerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).BeginInit();
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getAllCustomerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllCustomerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllCustomerBindingSource)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ButtonEdit
            // 
            this.guna2ButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ButtonEdit.BorderRadius = 15;
            this.guna2ButtonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.guna2ButtonEdit.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonEdit.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonEdit.Location = new System.Drawing.Point(971, 430);
            this.guna2ButtonEdit.Name = "guna2ButtonEdit";
            this.guna2ButtonEdit.Size = new System.Drawing.Size(123, 46);
            this.guna2ButtonEdit.TabIndex = 234;
            this.guna2ButtonEdit.Text = "Edit";
            this.guna2ButtonEdit.Click += new System.EventHandler(this.Guna2ButtonEdit_Click);
            // 
            // guna2DataGridViewCustomer
            // 
            this.guna2DataGridViewCustomer.AllowUserToAddRows = false;
            this.guna2DataGridViewCustomer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridViewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridViewCustomer.AutoGenerateColumns = false;
            this.guna2DataGridViewCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridViewCustomer.ColumnHeadersHeight = 35;
            this.guna2DataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FirstName,
            this.LastName});
            this.guna2DataGridViewCustomer.DataSource = this.getAllCustomerBindingSource3;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewCustomer.DefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridViewCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewCustomer.Location = new System.Drawing.Point(28, 57);
            this.guna2DataGridViewCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.guna2DataGridViewCustomer.Name = "guna2DataGridViewCustomer";
            this.guna2DataGridViewCustomer.ReadOnly = true;
            this.guna2DataGridViewCustomer.RowHeadersVisible = false;
            this.guna2DataGridViewCustomer.Size = new System.Drawing.Size(456, 366);
            this.guna2DataGridViewCustomer.TabIndex = 232;
            this.guna2DataGridViewCustomer.TabStop = false;
            this.guna2DataGridViewCustomer.Tag = "book_id";
            this.guna2DataGridViewCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewCustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridViewCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewCustomer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewCustomer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewCustomer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2DataGridViewCustomer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewCustomer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewCustomer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewCustomer.ThemeStyle.HeaderStyle.Height = 35;
            this.guna2DataGridViewCustomer.ThemeStyle.ReadOnly = true;
            this.guna2DataGridViewCustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.guna2DataGridViewCustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewCustomer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewCustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewCustomer.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridViewCustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.guna2DataGridViewCustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.guna2DataGridViewCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Guna2DataGridViewCustomer_CellClick);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // getAllCustomerBindingSource3
            // 
            this.getAllCustomerBindingSource3.DataMember = "GetAllCustomer";
            this.getAllCustomerBindingSource3.DataSource = this.dSReports;
            // 
            // dSReports
            // 
            this.dSReports.DataSetName = "DSReports";
            this.dSReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2TextBoxCustomer
            // 
            this.guna2TextBoxCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBoxCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxCustomer.BorderThickness = 2;
            this.guna2TextBoxCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxCustomer.DefaultText = "";
            this.guna2TextBoxCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxCustomer.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBoxCustomer.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxCustomer.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBoxCustomer.IconLeft")));
            this.guna2TextBoxCustomer.Location = new System.Drawing.Point(28, 13);
            this.guna2TextBoxCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBoxCustomer.Name = "guna2TextBoxCustomer";
            this.guna2TextBoxCustomer.PlaceholderText = "";
            this.guna2TextBoxCustomer.SelectedText = "";
            this.guna2TextBoxCustomer.Size = new System.Drawing.Size(456, 36);
            this.guna2TextBoxCustomer.TabIndex = 242;
            this.guna2TextBoxCustomer.TextChanged += new System.EventHandler(this.Guna2TextBoxCustomer_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.label1.Location = new System.Drawing.Point(640, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 34);
            this.label1.TabIndex = 432;
            this.label1.Text = "Add Customer";
            // 
            // guna2TextBoxLastName
            // 
            this.guna2TextBoxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBoxLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxLastName.BorderThickness = 2;
            this.guna2TextBoxLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxLastName.DefaultText = "";
            this.guna2TextBoxLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxLastName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.guna2TextBoxLastName.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxLastName.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxLastName.Location = new System.Drawing.Point(646, 257);
            this.guna2TextBoxLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBoxLastName.Name = "guna2TextBoxLastName";
            this.guna2TextBoxLastName.Padding = new System.Windows.Forms.Padding(7);
            this.guna2TextBoxLastName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxLastName.PlaceholderText = "";
            this.guna2TextBoxLastName.SelectedText = "";
            this.guna2TextBoxLastName.Size = new System.Drawing.Size(333, 36);
            this.guna2TextBoxLastName.TabIndex = 431;
            // 
            // guna2TextBoxFirstname
            // 
            this.guna2TextBoxFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBoxFirstname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxFirstname.BorderThickness = 2;
            this.guna2TextBoxFirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxFirstname.DefaultText = "";
            this.guna2TextBoxFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxFirstname.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.guna2TextBoxFirstname.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxFirstname.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxFirstname.Location = new System.Drawing.Point(646, 173);
            this.guna2TextBoxFirstname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBoxFirstname.Name = "guna2TextBoxFirstname";
            this.guna2TextBoxFirstname.Padding = new System.Windows.Forms.Padding(7);
            this.guna2TextBoxFirstname.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxFirstname.PlaceholderText = "";
            this.guna2TextBoxFirstname.SelectedText = "";
            this.guna2TextBoxFirstname.Size = new System.Drawing.Size(333, 36);
            this.guna2TextBoxFirstname.TabIndex = 430;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(136, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 428;
            this.label2.Text = "Last Name";
            // 
            // guna2ButtonCreateAccount
            // 
            this.guna2ButtonCreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ButtonCreateAccount.BorderRadius = 15;
            this.guna2ButtonCreateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCreateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCreateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonCreateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonCreateAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ButtonCreateAccount.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonCreateAccount.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonCreateAccount.Location = new System.Drawing.Point(646, 339);
            this.guna2ButtonCreateAccount.Name = "guna2ButtonCreateAccount";
            this.guna2ButtonCreateAccount.Size = new System.Drawing.Size(337, 36);
            this.guna2ButtonCreateAccount.TabIndex = 429;
            this.guna2ButtonCreateAccount.Text = "Save";
            this.guna2ButtonCreateAccount.Click += new System.EventHandler(this.Guna2ButtonCreateAccount_Click);
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFirstname.Location = new System.Drawing.Point(136, 113);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(84, 21);
            this.labelFirstname.TabIndex = 427;
            this.labelFirstname.Text = "First Name";
            // 
            // panelAdd
            // 
            this.panelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAdd.Controls.Add(this.labelFirstname);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Location = new System.Drawing.Point(506, 35);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(588, 388);
            this.panelAdd.TabIndex = 433;
            // 
            // getAllCustomerBindingSource2
            // 
            this.getAllCustomerBindingSource2.DataMember = "GetAllCustomer";
            this.getAllCustomerBindingSource2.DataSource = this.dSReports;
            // 
            // getAllCustomerBindingSource1
            // 
            this.getAllCustomerBindingSource1.DataMember = "GetAllCustomer";
            this.getAllCustomerBindingSource1.DataSource = this.dSReports;
            // 
            // getAllCustomerBindingSource
            // 
            this.getAllCustomerBindingSource.DataMember = "GetAllCustomer";
            this.getAllCustomerBindingSource.DataSource = this.dSReports;
            // 
            // getAllCustomerTableAdapter
            // 
            this.getAllCustomerTableAdapter.ClearBeforeFill = true;
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
            this.guna2ButtonAdd.Location = new System.Drawing.Point(842, 430);
            this.guna2ButtonAdd.Name = "guna2ButtonAdd";
            this.guna2ButtonAdd.Size = new System.Drawing.Size(123, 46);
            this.guna2ButtonAdd.TabIndex = 435;
            this.guna2ButtonAdd.Text = "Add";
            this.guna2ButtonAdd.Click += new System.EventHandler(this.Guna2ButtonAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.label6.Location = new System.Drawing.Point(130, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 34);
            this.label6.TabIndex = 423;
            this.label6.Text = "Edit Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(134, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 424;
            this.label5.Text = "First Name";
            // 
            // guna2ButtonSaveEdit
            // 
            this.guna2ButtonSaveEdit.BorderRadius = 15;
            this.guna2ButtonSaveEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonSaveEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonSaveEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonSaveEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonSaveEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ButtonSaveEdit.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonSaveEdit.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonSaveEdit.Location = new System.Drawing.Point(134, 305);
            this.guna2ButtonSaveEdit.Name = "guna2ButtonSaveEdit";
            this.guna2ButtonSaveEdit.Size = new System.Drawing.Size(337, 36);
            this.guna2ButtonSaveEdit.TabIndex = 426;
            this.guna2ButtonSaveEdit.Text = "Save";
            this.guna2ButtonSaveEdit.Click += new System.EventHandler(this.Guna2ButtonSaveEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(134, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 425;
            this.label4.Text = "Last Name";
            // 
            // guna2TextBoxEditFirstname
            // 
            this.guna2TextBoxEditFirstname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxEditFirstname.BorderThickness = 2;
            this.guna2TextBoxEditFirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxEditFirstname.DefaultText = "";
            this.guna2TextBoxEditFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxEditFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxEditFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxEditFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxEditFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxEditFirstname.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.guna2TextBoxEditFirstname.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxEditFirstname.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxEditFirstname.Location = new System.Drawing.Point(138, 139);
            this.guna2TextBoxEditFirstname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBoxEditFirstname.Name = "guna2TextBoxEditFirstname";
            this.guna2TextBoxEditFirstname.Padding = new System.Windows.Forms.Padding(7);
            this.guna2TextBoxEditFirstname.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxEditFirstname.PlaceholderText = "";
            this.guna2TextBoxEditFirstname.SelectedText = "";
            this.guna2TextBoxEditFirstname.Size = new System.Drawing.Size(333, 36);
            this.guna2TextBoxEditFirstname.TabIndex = 427;
            // 
            // guna2TextBoxEditLastname
            // 
            this.guna2TextBoxEditLastname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxEditLastname.BorderThickness = 2;
            this.guna2TextBoxEditLastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxEditLastname.DefaultText = "";
            this.guna2TextBoxEditLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxEditLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxEditLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxEditLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxEditLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxEditLastname.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.guna2TextBoxEditLastname.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxEditLastname.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxEditLastname.Location = new System.Drawing.Point(138, 223);
            this.guna2TextBoxEditLastname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBoxEditLastname.Name = "guna2TextBoxEditLastname";
            this.guna2TextBoxEditLastname.Padding = new System.Windows.Forms.Padding(7);
            this.guna2TextBoxEditLastname.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxEditLastname.PlaceholderText = "";
            this.guna2TextBoxEditLastname.SelectedText = "";
            this.guna2TextBoxEditLastname.Size = new System.Drawing.Size(333, 36);
            this.guna2TextBoxEditLastname.TabIndex = 428;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(280, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 429;
            this.label3.Text = "Customer ID";
            // 
            // guna2TextBoxID
            // 
            this.guna2TextBoxID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxID.BorderThickness = 0;
            this.guna2TextBoxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxID.DefaultText = "";
            this.guna2TextBoxID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxID.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBoxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxID.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.guna2TextBoxID.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxID.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxID.Location = new System.Drawing.Point(368, 90);
            this.guna2TextBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBoxID.Name = "guna2TextBoxID";
            this.guna2TextBoxID.Padding = new System.Windows.Forms.Padding(7);
            this.guna2TextBoxID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxID.PlaceholderText = "";
            this.guna2TextBoxID.ReadOnly = true;
            this.guna2TextBoxID.SelectedText = "";
            this.guna2TextBoxID.Size = new System.Drawing.Size(105, 21);
            this.guna2TextBoxID.TabIndex = 430;
            this.guna2TextBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelEdit
            // 
            this.panelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEdit.Controls.Add(this.guna2TextBoxID);
            this.panelEdit.Controls.Add(this.label3);
            this.panelEdit.Controls.Add(this.guna2TextBoxEditLastname);
            this.panelEdit.Controls.Add(this.guna2TextBoxEditFirstname);
            this.panelEdit.Controls.Add(this.label4);
            this.panelEdit.Controls.Add(this.guna2ButtonSaveEdit);
            this.panelEdit.Controls.Add(this.label5);
            this.panelEdit.Controls.Add(this.label6);
            this.panelEdit.Location = new System.Drawing.Point(506, 35);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(588, 389);
            this.panelEdit.TabIndex = 434;
            this.panelEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEdit_Paint);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1117, 488);
            this.Controls.Add(this.guna2ButtonAdd);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TextBoxLastName);
            this.Controls.Add(this.guna2TextBoxFirstname);
            this.Controls.Add(this.guna2ButtonCreateAccount);
            this.Controls.Add(this.guna2TextBoxCustomer);
            this.Controls.Add(this.guna2ButtonEdit);
            this.Controls.Add(this.guna2DataGridViewCustomer);
            this.Controls.Add(this.panelAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerForm_FormClosing);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllCustomerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getAllCustomerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllCustomerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllCustomerBindingSource)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2ButtonEdit;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewCustomer;
        private DataSet.DSReports dSReports;
        private System.Windows.Forms.BindingSource getAllCustomerBindingSource;
        private DataSet.DSReportsTableAdapters.GetAllCustomerTableAdapter getAllCustomerTableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxCustomer;
        private System.Windows.Forms.BindingSource getAllCustomerBindingSource1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxLastName;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxFirstname;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonCreateAccount;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.BindingSource getAllCustomerBindingSource2;
        private System.Windows.Forms.BindingSource getAllCustomerBindingSource3;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonSaveEdit;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxEditFirstname;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxEditLastname;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxID;
        private System.Windows.Forms.Panel panelEdit;
    }
}