namespace Project.Forms.ExtensionForms
{
    partial class TransSelectCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransSelectCustomer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2TextBoxCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.G2DGVCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getAllCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSReports = new Project.DataSet.DSReports();
            this.getAllCustomerTableAdapter = new Project.DataSet.DSReportsTableAdapters.GetAllCustomerTableAdapter();
            this.GBtnAdd = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.G2DGVCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).BeginInit();
            this.SuspendLayout();
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
            this.guna2TextBoxCustomer.Location = new System.Drawing.Point(13, 13);
            this.guna2TextBoxCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBoxCustomer.Name = "guna2TextBoxCustomer";
            this.guna2TextBoxCustomer.PlaceholderText = "";
            this.guna2TextBoxCustomer.SelectedText = "";
            this.guna2TextBoxCustomer.Size = new System.Drawing.Size(1093, 36);
            this.guna2TextBoxCustomer.TabIndex = 244;
            this.guna2TextBoxCustomer.TextChanged += new System.EventHandler(this.guna2TextBoxCustomer_TextChanged);
            // 
            // G2DGVCustomer
            // 
            this.G2DGVCustomer.AllowUserToAddRows = false;
            this.G2DGVCustomer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.G2DGVCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.G2DGVCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G2DGVCustomer.AutoGenerateColumns = false;
            this.G2DGVCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.G2DGVCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.G2DGVCustomer.ColumnHeadersHeight = 35;
            this.G2DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.G2DGVCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FirstName,
            this.LastName});
            this.G2DGVCustomer.DataSource = this.getAllCustomerBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.G2DGVCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.G2DGVCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.G2DGVCustomer.Location = new System.Drawing.Point(13, 57);
            this.G2DGVCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.G2DGVCustomer.Name = "G2DGVCustomer";
            this.G2DGVCustomer.ReadOnly = true;
            this.G2DGVCustomer.RowHeadersVisible = false;
            this.G2DGVCustomer.Size = new System.Drawing.Size(1093, 357);
            this.G2DGVCustomer.TabIndex = 243;
            this.G2DGVCustomer.Tag = "book_id";
            this.G2DGVCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.G2DGVCustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.G2DGVCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.G2DGVCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.G2DGVCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.G2DGVCustomer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.G2DGVCustomer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.G2DGVCustomer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2DGVCustomer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.G2DGVCustomer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2DGVCustomer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.G2DGVCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.G2DGVCustomer.ThemeStyle.HeaderStyle.Height = 35;
            this.G2DGVCustomer.ThemeStyle.ReadOnly = true;
            this.G2DGVCustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.G2DGVCustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.G2DGVCustomer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2DGVCustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.G2DGVCustomer.ThemeStyle.RowsStyle.Height = 22;
            this.G2DGVCustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.G2DGVCustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
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
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // getAllCustomerBindingSource
            // 
            this.getAllCustomerBindingSource.DataMember = "GetAllCustomer";
            this.getAllCustomerBindingSource.DataSource = this.dSReports;
            // 
            // dSReports
            // 
            this.dSReports.DataSetName = "DSReports";
            this.dSReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getAllCustomerTableAdapter
            // 
            this.getAllCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // GBtnAdd
            // 
            this.GBtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GBtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.GBtnAdd.BorderRadius = 15;
            this.GBtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.GBtnAdd.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.GBtnAdd.ForeColor = System.Drawing.Color.White;
            this.GBtnAdd.Location = new System.Drawing.Point(957, 421);
            this.GBtnAdd.Name = "GBtnAdd";
            this.GBtnAdd.Size = new System.Drawing.Size(149, 42);
            this.GBtnAdd.TabIndex = 382;
            this.GBtnAdd.Text = "Next";
            this.GBtnAdd.UseTransparentBackground = true;
            this.GBtnAdd.Click += new System.EventHandler(this.GBtnNext_Click);
            // 
            // TransSelectCustomer
            // 
            this.AcceptButton = this.GBtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 471);
            this.Controls.Add(this.GBtnAdd);
            this.Controls.Add(this.guna2TextBoxCustomer);
            this.Controls.Add(this.G2DGVCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransSelectCustomer";
            this.Load += new System.EventHandler(this.TransSelectCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.G2DGVCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxCustomer;
        private Guna.UI2.WinForms.Guna2DataGridView G2DGVCustomer;
        private DataSet.DSReports dSReports;
        private System.Windows.Forms.BindingSource getAllCustomerBindingSource;
        private DataSet.DSReportsTableAdapters.GetAllCustomerTableAdapter getAllCustomerTableAdapter;
        private Guna.UI2.WinForms.Guna2Button GBtnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
    }
}