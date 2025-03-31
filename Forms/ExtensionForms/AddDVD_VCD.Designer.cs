namespace Project.Forms.ExtensionForms
{
    partial class AddDVD_VCD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEditBook = new System.Windows.Forms.Panel();
            this.G2BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.G2BtnAddSave = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ComboBoxLimitdaysRented = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ComboBoxCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TextBoxTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxTotalCopies = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelBook = new System.Windows.Forms.Label();
            this.guna2ButtonSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DocumentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEditBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G2BtnAddSave)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEditBook
            // 
            this.panelEditBook.Controls.Add(this.G2BtnSave);
            this.panelEditBook.Controls.Add(this.G2BtnAddSave);
            this.panelEditBook.Controls.Add(this.guna2ComboBoxLimitdaysRented);
            this.panelEditBook.Controls.Add(this.label3);
            this.panelEditBook.Controls.Add(this.label1);
            this.panelEditBook.Controls.Add(this.guna2ComboBoxCategory);
            this.panelEditBook.Controls.Add(this.guna2TextBoxTitle);
            this.panelEditBook.Controls.Add(this.guna2TextBoxTotalCopies);
            this.panelEditBook.Controls.Add(this.labelBook);
            this.panelEditBook.Controls.Add(this.guna2ButtonSubmit);
            this.panelEditBook.Controls.Add(this.label5);
            this.panelEditBook.Controls.Add(this.label2);
            this.panelEditBook.Location = new System.Drawing.Point(0, 0);
            this.panelEditBook.Name = "panelEditBook";
            this.panelEditBook.Size = new System.Drawing.Size(1132, 567);
            this.panelEditBook.TabIndex = 65;
            // 
            // G2BtnSave
            // 
            this.G2BtnSave.BackColor = System.Drawing.Color.Transparent;
            this.G2BtnSave.BorderRadius = 15;
            this.G2BtnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2BtnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2BtnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2BtnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2BtnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2BtnSave.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.G2BtnSave.ForeColor = System.Drawing.Color.White;
            this.G2BtnSave.Location = new System.Drawing.Point(978, 426);
            this.G2BtnSave.Name = "G2BtnSave";
            this.G2BtnSave.Size = new System.Drawing.Size(125, 36);
            this.G2BtnSave.TabIndex = 363;
            this.G2BtnSave.Text = "Save";
            this.G2BtnSave.UseTransparentBackground = true;
            this.G2BtnSave.Click += new System.EventHandler(this.G2BtnSave_Click);
            // 
            // G2BtnAddSave
            // 
            this.G2BtnAddSave.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.G2BtnAddSave.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.G2BtnAddSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G2BtnAddSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.G2BtnAddSave.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.G2BtnAddSave.ColumnHeadersHeight = 35;
            this.G2BtnAddSave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.G2BtnAddSave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocumentNo,
            this.VideoID,
            this.Title,
            this.Qty,
            this.Price,
            this.SerialNo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.G2BtnAddSave.DefaultCellStyle = dataGridViewCellStyle3;
            this.G2BtnAddSave.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.G2BtnAddSave.Location = new System.Drawing.Point(422, 31);
            this.G2BtnAddSave.Margin = new System.Windows.Forms.Padding(4);
            this.G2BtnAddSave.Name = "G2BtnAddSave";
            this.G2BtnAddSave.RowHeadersVisible = false;
            this.G2BtnAddSave.Size = new System.Drawing.Size(681, 388);
            this.G2BtnAddSave.TabIndex = 362;
            this.G2BtnAddSave.Tag = "book_id";
            this.G2BtnAddSave.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.G2BtnAddSave.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.G2BtnAddSave.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.G2BtnAddSave.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.G2BtnAddSave.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.G2BtnAddSave.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.G2BtnAddSave.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.G2BtnAddSave.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2BtnAddSave.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.G2BtnAddSave.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2BtnAddSave.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.G2BtnAddSave.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.G2BtnAddSave.ThemeStyle.HeaderStyle.Height = 35;
            this.G2BtnAddSave.ThemeStyle.ReadOnly = false;
            this.G2BtnAddSave.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.G2BtnAddSave.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.G2BtnAddSave.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2BtnAddSave.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.G2BtnAddSave.ThemeStyle.RowsStyle.Height = 22;
            this.G2BtnAddSave.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.G2BtnAddSave.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.G2BtnAddSave.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.G2DGVAdd_CellValueChanged);
            this.G2BtnAddSave.CurrentCellDirtyStateChanged += new System.EventHandler(this.G2DGVAdd_CurrentCellDirtyStateChanged);
            // 
            // guna2ComboBoxLimitdaysRented
            // 
            this.guna2ComboBoxLimitdaysRented.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxLimitdaysRented.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxLimitdaysRented.BorderThickness = 2;
            this.guna2ComboBoxLimitdaysRented.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxLimitdaysRented.DropDownHeight = 150;
            this.guna2ComboBoxLimitdaysRented.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxLimitdaysRented.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxLimitdaysRented.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxLimitdaysRented.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBoxLimitdaysRented.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBoxLimitdaysRented.IntegralHeight = false;
            this.guna2ComboBoxLimitdaysRented.ItemHeight = 30;
            this.guna2ComboBoxLimitdaysRented.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.guna2ComboBoxLimitdaysRented.Location = new System.Drawing.Point(13, 383);
            this.guna2ComboBoxLimitdaysRented.Name = "guna2ComboBoxLimitdaysRented";
            this.guna2ComboBoxLimitdaysRented.Size = new System.Drawing.Size(353, 36);
            this.guna2ComboBoxLimitdaysRented.TabIndex = 361;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 359;
            this.label3.Text = "Limit Days Rented";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 358;
            this.label1.Text = "Category";
            // 
            // guna2ComboBoxCategory
            // 
            this.guna2ComboBoxCategory.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxCategory.BorderThickness = 2;
            this.guna2ComboBoxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxCategory.DropDownHeight = 150;
            this.guna2ComboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxCategory.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBoxCategory.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBoxCategory.IntegralHeight = false;
            this.guna2ComboBoxCategory.ItemHeight = 30;
            this.guna2ComboBoxCategory.Items.AddRange(new object[] {
            "DVD",
            "VCD"});
            this.guna2ComboBoxCategory.Location = new System.Drawing.Point(13, 285);
            this.guna2ComboBoxCategory.Name = "guna2ComboBoxCategory";
            this.guna2ComboBoxCategory.Size = new System.Drawing.Size(353, 36);
            this.guna2ComboBoxCategory.TabIndex = 357;
            // 
            // guna2TextBoxTitle
            // 
            this.guna2TextBoxTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxTitle.BorderThickness = 2;
            this.guna2TextBoxTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxTitle.DefaultText = "";
            this.guna2TextBoxTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.guna2TextBoxTitle.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxTitle.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxTitle.Location = new System.Drawing.Point(13, 118);
            this.guna2TextBoxTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBoxTitle.Name = "guna2TextBoxTitle";
            this.guna2TextBoxTitle.Padding = new System.Windows.Forms.Padding(7);
            this.guna2TextBoxTitle.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxTitle.PlaceholderText = "";
            this.guna2TextBoxTitle.SelectedText = "";
            this.guna2TextBoxTitle.Size = new System.Drawing.Size(353, 36);
            this.guna2TextBoxTitle.TabIndex = 292;
            // 
            // guna2TextBoxTotalCopies
            // 
            this.guna2TextBoxTotalCopies.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxTotalCopies.BorderThickness = 2;
            this.guna2TextBoxTotalCopies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxTotalCopies.DefaultText = "";
            this.guna2TextBoxTotalCopies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxTotalCopies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxTotalCopies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxTotalCopies.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxTotalCopies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxTotalCopies.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.guna2TextBoxTotalCopies.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxTotalCopies.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxTotalCopies.Location = new System.Drawing.Point(13, 205);
            this.guna2TextBoxTotalCopies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBoxTotalCopies.Name = "guna2TextBoxTotalCopies";
            this.guna2TextBoxTotalCopies.Padding = new System.Windows.Forms.Padding(7);
            this.guna2TextBoxTotalCopies.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxTotalCopies.PlaceholderText = "";
            this.guna2TextBoxTotalCopies.SelectedText = "";
            this.guna2TextBoxTotalCopies.Size = new System.Drawing.Size(353, 36);
            this.guna2TextBoxTotalCopies.TabIndex = 290;
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.labelBook.Location = new System.Drawing.Point(12, 37);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(268, 34);
            this.labelBook.TabIndex = 206;
            this.labelBook.Text = "Add DVDs and VCDs";
            // 
            // guna2ButtonSubmit
            // 
            this.guna2ButtonSubmit.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonSubmit.BorderRadius = 15;
            this.guna2ButtonSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ButtonSubmit.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.guna2ButtonSubmit.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonSubmit.Location = new System.Drawing.Point(11, 455);
            this.guna2ButtonSubmit.Name = "guna2ButtonSubmit";
            this.guna2ButtonSubmit.Size = new System.Drawing.Size(355, 36);
            this.guna2ButtonSubmit.TabIndex = 53;
            this.guna2ButtonSubmit.Text = "Save";
            this.guna2ButtonSubmit.UseTransparentBackground = true;
            this.guna2ButtonSubmit.Click += new System.EventHandler(this.Guna2ButtonSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 21);
            this.label5.TabIndex = 50;
            this.label5.Text = "Qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Title";
            // 
            // DocumentNo
            // 
            this.DocumentNo.HeaderText = "Document No.";
            this.DocumentNo.Name = "DocumentNo";
            // 
            // VideoID
            // 
            this.VideoID.HeaderText = "Video ID";
            this.VideoID.Name = "VideoID";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // SerialNo
            // 
            this.SerialNo.HeaderText = "Serial No.";
            this.SerialNo.Name = "SerialNo";
            // 
            // AddDVD_VCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 567);
            this.Controls.Add(this.panelEditBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDVD_VCD";
            this.Text = "AddDVD_VCD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDVD_VCD_FormClosing);
            this.Load += new System.EventHandler(this.AddDVD_VCD_Load);
            this.panelEditBook.ResumeLayout(false);
            this.panelEditBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G2BtnAddSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEditBook;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxTitle;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxTotalCopies;
        private System.Windows.Forms.Label labelBook;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxCategory;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxLimitdaysRented;
        private Guna.UI2.WinForms.Guna2DataGridView G2BtnAddSave;
        private Guna.UI2.WinForms.Guna2Button G2BtnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
    }
}