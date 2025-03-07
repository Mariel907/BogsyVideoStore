namespace Project.Forms.ExtensionForms
{
    partial class RentCustomer
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
            this.guna2ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.DGVRent = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ComboBoxCustomer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBoxVideo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.guna2TextBoxCustomerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2TextBoxChange = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxCash = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ButtonVoid = new Guna.UI2.WinForms.Guna2Button();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllVideoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullnameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllVideoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullnameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ButtonSave
            // 
            this.guna2ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ButtonSave.BorderRadius = 15;
            this.guna2ButtonSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ButtonSave.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonSave.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonSave.Location = new System.Drawing.Point(786, 475);
            this.guna2ButtonSave.Name = "guna2ButtonSave";
            this.guna2ButtonSave.Size = new System.Drawing.Size(150, 39);
            this.guna2ButtonSave.TabIndex = 323;
            this.guna2ButtonSave.Text = "Rent";
            this.guna2ButtonSave.Click += new System.EventHandler(this.guna2ButtonRent_Click);
            // 
            // DGVRent
            // 
            this.DGVRent.AllowUserToAddRows = false;
            this.DGVRent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVRent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVRent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVRent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVRent.ColumnHeadersHeight = 35;
            this.DGVRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVRent.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVRent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVRent.Location = new System.Drawing.Point(39, 97);
            this.DGVRent.Margin = new System.Windows.Forms.Padding(4);
            this.DGVRent.Name = "DGVRent";
            this.DGVRent.ReadOnly = true;
            this.DGVRent.RowHeadersVisible = false;
            this.DGVRent.Size = new System.Drawing.Size(1053, 350);
            this.DGVRent.TabIndex = 375;
            this.DGVRent.Tag = "book_id";
            this.DGVRent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVRent.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVRent.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVRent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVRent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVRent.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVRent.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVRent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.DGVRent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVRent.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVRent.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVRent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVRent.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVRent.ThemeStyle.ReadOnly = true;
            this.DGVRent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.DGVRent.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVRent.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVRent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVRent.ThemeStyle.RowsStyle.Height = 22;
            this.DGVRent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.DGVRent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            // 
            // guna2ComboBoxCustomer
            // 
            this.guna2ComboBoxCustomer.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxCustomer.BorderThickness = 2;
            this.guna2ComboBoxCustomer.DisplayMember = "CustomerID";
            this.guna2ComboBoxCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxCustomer.DropDownHeight = 150;
            this.guna2ComboBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxCustomer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxCustomer.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBoxCustomer.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBoxCustomer.IntegralHeight = false;
            this.guna2ComboBoxCustomer.ItemHeight = 30;
            this.guna2ComboBoxCustomer.Location = new System.Drawing.Point(39, 33);
            this.guna2ComboBoxCustomer.Name = "guna2ComboBoxCustomer";
            this.guna2ComboBoxCustomer.Size = new System.Drawing.Size(217, 36);
            this.guna2ComboBoxCustomer.TabIndex = 383;
            this.guna2ComboBoxCustomer.ValueMember = "CustomerID";
            this.guna2ComboBoxCustomer.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBoxCustomer_SelectedIndexChanged_1);
            // 
            // guna2ComboBoxVideo
            // 
            this.guna2ComboBoxVideo.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxVideo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxVideo.BorderThickness = 2;
            this.guna2ComboBoxVideo.DisplayMember = "VideoID";
            this.guna2ComboBoxVideo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxVideo.DropDownHeight = 150;
            this.guna2ComboBoxVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxVideo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxVideo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxVideo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.guna2ComboBoxVideo.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBoxVideo.IntegralHeight = false;
            this.guna2ComboBoxVideo.ItemHeight = 30;
            this.guna2ComboBoxVideo.Location = new System.Drawing.Point(285, 33);
            this.guna2ComboBoxVideo.Name = "guna2ComboBoxVideo";
            this.guna2ComboBoxVideo.Size = new System.Drawing.Size(217, 36);
            this.guna2ComboBoxVideo.TabIndex = 384;
            this.guna2ComboBoxVideo.ValueMember = "VideoID";
            this.guna2ComboBoxVideo.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBoxVideo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 369;
            this.label3.Text = "Fullname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 21);
            this.label4.TabIndex = 385;
            this.label4.Text = "Title";
            // 
            // guna2ButtonAdd
            // 
            this.guna2ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ButtonAdd.BorderRadius = 15;
            this.guna2ButtonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.guna2ButtonAdd.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonAdd.Location = new System.Drawing.Point(942, 475);
            this.guna2ButtonAdd.Name = "guna2ButtonAdd";
            this.guna2ButtonAdd.Size = new System.Drawing.Size(150, 39);
            this.guna2ButtonAdd.TabIndex = 387;
            this.guna2ButtonAdd.Text = "Add";
            this.guna2ButtonAdd.Click += new System.EventHandler(this.guna2ButtonAdd_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 388;
            this.label5.Text = "Amount";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotal.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(39, 475);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(306, 39);
            this.labelTotal.TabIndex = 389;
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2TextBoxCustomerID
            // 
            this.guna2TextBoxCustomerID.BorderColor = System.Drawing.Color.White;
            this.guna2TextBoxCustomerID.BorderThickness = 2;
            this.guna2TextBoxCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxCustomerID.DefaultText = "";
            this.guna2TextBoxCustomerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxCustomerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxCustomerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxCustomerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxCustomerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxCustomerID.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.guna2TextBoxCustomerID.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxCustomerID.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxCustomerID.Location = new System.Drawing.Point(115, 14);
            this.guna2TextBoxCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.guna2TextBoxCustomerID.Name = "guna2TextBoxCustomerID";
            this.guna2TextBoxCustomerID.Padding = new System.Windows.Forms.Padding(5);
            this.guna2TextBoxCustomerID.PlaceholderForeColor = System.Drawing.Color.White;
            this.guna2TextBoxCustomerID.PlaceholderText = "";
            this.guna2TextBoxCustomerID.ReadOnly = true;
            this.guna2TextBoxCustomerID.SelectedText = "";
            this.guna2TextBoxCustomerID.Size = new System.Drawing.Size(72, 15);
            this.guna2TextBoxCustomerID.TabIndex = 377;
            this.guna2TextBoxCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(707, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 426;
            this.label2.Text = "Cash";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(909, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 428;
            this.label6.Text = "Change";
            // 
            // guna2TextBoxChange
            // 
            this.guna2TextBoxChange.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxChange.BorderThickness = 2;
            this.guna2TextBoxChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxChange.DefaultText = "";
            this.guna2TextBoxChange.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxChange.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxChange.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBoxChange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxChange.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.guna2TextBoxChange.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxChange.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxChange.Location = new System.Drawing.Point(913, 33);
            this.guna2TextBoxChange.Margin = new System.Windows.Forms.Padding(2);
            this.guna2TextBoxChange.Name = "guna2TextBoxChange";
            this.guna2TextBoxChange.Padding = new System.Windows.Forms.Padding(5);
            this.guna2TextBoxChange.PlaceholderForeColor = System.Drawing.Color.White;
            this.guna2TextBoxChange.PlaceholderText = "";
            this.guna2TextBoxChange.ReadOnly = true;
            this.guna2TextBoxChange.SelectedText = "";
            this.guna2TextBoxChange.Size = new System.Drawing.Size(179, 36);
            this.guna2TextBoxChange.TabIndex = 429;
            // 
            // guna2TextBoxCash
            // 
            this.guna2TextBoxCash.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxCash.BorderThickness = 2;
            this.guna2TextBoxCash.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxCash.DefaultText = "";
            this.guna2TextBoxCash.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxCash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxCash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxCash.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxCash.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxCash.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.guna2TextBoxCash.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxCash.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxCash.Location = new System.Drawing.Point(711, 33);
            this.guna2TextBoxCash.Margin = new System.Windows.Forms.Padding(2);
            this.guna2TextBoxCash.Name = "guna2TextBoxCash";
            this.guna2TextBoxCash.Padding = new System.Windows.Forms.Padding(5);
            this.guna2TextBoxCash.PlaceholderForeColor = System.Drawing.Color.White;
            this.guna2TextBoxCash.PlaceholderText = "";
            this.guna2TextBoxCash.SelectedText = "";
            this.guna2TextBoxCash.Size = new System.Drawing.Size(179, 36);
            this.guna2TextBoxCash.TabIndex = 430;
            this.guna2TextBoxCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtbxCash_KeyDown);
            // 
            // guna2ButtonVoid
            // 
            this.guna2ButtonVoid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ButtonVoid.BorderRadius = 15;
            this.guna2ButtonVoid.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonVoid.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonVoid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonVoid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonVoid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ButtonVoid.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonVoid.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonVoid.Location = new System.Drawing.Point(630, 475);
            this.guna2ButtonVoid.Name = "guna2ButtonVoid";
            this.guna2ButtonVoid.Size = new System.Drawing.Size(150, 39);
            this.guna2ButtonVoid.TabIndex = 431;
            this.guna2ButtonVoid.Text = "Void";
            this.guna2ButtonVoid.Click += new System.EventHandler(this.guna2ButtonVoid_Click);
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "Receipt";
            // 
            // getAllVideoBindingSource
            // 
            this.getAllVideoBindingSource.DataMember = "GetAllVideo";
            // 
            // fullnameBindingSource
            // 
            this.fullnameBindingSource.DataMember = "Fullname";
            // 
            // videoBindingSource
            // 
            this.videoBindingSource.DataMember = "Video";
            // 
            // RentCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 526);
            this.Controls.Add(this.guna2ButtonVoid);
            this.Controls.Add(this.guna2TextBoxCash);
            this.Controls.Add(this.guna2TextBoxChange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2ButtonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2ComboBoxVideo);
            this.Controls.Add(this.guna2ComboBoxCustomer);
            this.Controls.Add(this.guna2TextBoxCustomerID);
            this.Controls.Add(this.DGVRent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2ButtonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentCustomer";
            this.Text = "RentCustomer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RentCustomer_FormClosing);
            this.Load += new System.EventHandler(this.RentCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllVideoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullnameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2ButtonSave;
        private Guna.UI2.WinForms.Guna2DataGridView DGVRent;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxCustomer;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxVideo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.BindingSource getAllVideoBindingSource;
        private System.Windows.Forms.BindingSource videoBindingSource;
        private System.Windows.Forms.BindingSource fullnameBindingSource;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxCustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxChange;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxCash;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonVoid;
    }
}