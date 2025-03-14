namespace Project.Forms
{
    partial class Payments
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
            this.DGVUnpaid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.unpaidBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSReports = new Project.DataSet.DSReports();
            this.guna2Buttonreturn = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.reportViewerPayment = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2TextBoxCustomerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxCash = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxChange = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unpaidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unpaidTableAdapter = new Project.DataSet.DSReportsTableAdapters.UnpaidTableAdapter();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.panel34 = new System.Windows.Forms.Panel();
            this.comboBoxFullname = new System.Windows.Forms.ComboBox();
            this.guna2ComboBoxVideoUnpaid = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TextBoxPenalty = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.RentalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Penalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2TextBoxRentalID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUnpaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpaidBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpaidBindingSource)).BeginInit();
            this.panel18.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel33.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVUnpaid
            // 
            this.DGVUnpaid.AllowUserToAddRows = false;
            this.DGVUnpaid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGVUnpaid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVUnpaid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVUnpaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUnpaid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVUnpaid.ColumnHeadersHeight = 35;
            this.DGVUnpaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVUnpaid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentalID,
            this.VideoID,
            this.CustomerID,
            this.Fullname,
            this.Quantity,
            this.Title,
            this.Category,
            this.Penalty});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVUnpaid.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVUnpaid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVUnpaid.Location = new System.Drawing.Point(40, 92);
            this.DGVUnpaid.Margin = new System.Windows.Forms.Padding(4);
            this.DGVUnpaid.Name = "DGVUnpaid";
            this.DGVUnpaid.ReadOnly = true;
            this.DGVUnpaid.RowHeadersVisible = false;
            this.DGVUnpaid.Size = new System.Drawing.Size(728, 365);
            this.DGVUnpaid.TabIndex = 376;
            this.DGVUnpaid.Tag = "book_id";
            this.DGVUnpaid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVUnpaid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVUnpaid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVUnpaid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVUnpaid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVUnpaid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVUnpaid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVUnpaid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.DGVUnpaid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVUnpaid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVUnpaid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVUnpaid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVUnpaid.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVUnpaid.ThemeStyle.ReadOnly = true;
            this.DGVUnpaid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.DGVUnpaid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVUnpaid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVUnpaid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVUnpaid.ThemeStyle.RowsStyle.Height = 22;
            this.DGVUnpaid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.DGVUnpaid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            // 
            // unpaidBindingSource1
            // 
            this.unpaidBindingSource1.DataMember = "Unpaid";
            this.unpaidBindingSource1.DataSource = this.dSReports;
            // 
            // dSReports
            // 
            this.dSReports.DataSetName = "DSReports";
            this.dSReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2Buttonreturn
            // 
            this.guna2Buttonreturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Buttonreturn.BorderRadius = 15;
            this.guna2Buttonreturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Buttonreturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Buttonreturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Buttonreturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Buttonreturn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2Buttonreturn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Buttonreturn.ForeColor = System.Drawing.Color.White;
            this.guna2Buttonreturn.Location = new System.Drawing.Point(955, 483);
            this.guna2Buttonreturn.Name = "guna2Buttonreturn";
            this.guna2Buttonreturn.Size = new System.Drawing.Size(152, 36);
            this.guna2Buttonreturn.TabIndex = 377;
            this.guna2Buttonreturn.Text = "Generate Receipt";
            this.guna2Buttonreturn.Click += new System.EventHandler(this.guna2ButtonGntrReceipt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 391;
            this.label4.Text = "Customer Name ";
            // 
            // reportViewerPayment
            // 
            this.reportViewerPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerPayment.Location = new System.Drawing.Point(789, 90);
            this.reportViewerPayment.Name = "reportViewerPayment";
            this.reportViewerPayment.ServerReport.BearerToken = null;
            this.reportViewerPayment.Size = new System.Drawing.Size(319, 365);
            this.reportViewerPayment.TabIndex = 392;
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
            this.guna2TextBoxCustomerID.Location = new System.Drawing.Point(150, 29);
            this.guna2TextBoxCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.guna2TextBoxCustomerID.Name = "guna2TextBoxCustomerID";
            this.guna2TextBoxCustomerID.Padding = new System.Windows.Forms.Padding(5);
            this.guna2TextBoxCustomerID.PlaceholderForeColor = System.Drawing.Color.White;
            this.guna2TextBoxCustomerID.PlaceholderText = "";
            this.guna2TextBoxCustomerID.ReadOnly = true;
            this.guna2TextBoxCustomerID.SelectedText = "";
            this.guna2TextBoxCustomerID.Size = new System.Drawing.Size(66, 15);
            this.guna2TextBoxCustomerID.TabIndex = 393;
            // 
            // guna2TextBoxCash
            // 
            this.guna2TextBoxCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.guna2TextBoxCash.Location = new System.Drawing.Point(727, 49);
            this.guna2TextBoxCash.Margin = new System.Windows.Forms.Padding(2);
            this.guna2TextBoxCash.Name = "guna2TextBoxCash";
            this.guna2TextBoxCash.Padding = new System.Windows.Forms.Padding(5);
            this.guna2TextBoxCash.PlaceholderForeColor = System.Drawing.Color.White;
            this.guna2TextBoxCash.PlaceholderText = "";
            this.guna2TextBoxCash.SelectedText = "";
            this.guna2TextBoxCash.Size = new System.Drawing.Size(179, 36);
            this.guna2TextBoxCash.TabIndex = 434;
            this.guna2TextBoxCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guna2TextBoxCash_KeyDown);
            // 
            // guna2TextBoxChange
            // 
            this.guna2TextBoxChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.guna2TextBoxChange.Location = new System.Drawing.Point(929, 49);
            this.guna2TextBoxChange.Margin = new System.Windows.Forms.Padding(2);
            this.guna2TextBoxChange.Name = "guna2TextBoxChange";
            this.guna2TextBoxChange.Padding = new System.Windows.Forms.Padding(5);
            this.guna2TextBoxChange.PlaceholderForeColor = System.Drawing.Color.White;
            this.guna2TextBoxChange.PlaceholderText = "";
            this.guna2TextBoxChange.ReadOnly = true;
            this.guna2TextBoxChange.SelectedText = "";
            this.guna2TextBoxChange.Size = new System.Drawing.Size(179, 36);
            this.guna2TextBoxChange.TabIndex = 433;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(925, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 432;
            this.label6.Text = "Change";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(723, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 431;
            this.label2.Text = "Cash";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotal.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(40, 483);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(306, 39);
            this.labelTotal.TabIndex = 436;
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTotal.Click += new System.EventHandler(this.LabelTotal_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 435;
            this.label5.Text = "Amount";
            // 
            // unpaidBindingSource
            // 
            this.unpaidBindingSource.DataMember = "Unpaid";
            this.unpaidBindingSource.DataSource = this.dSReports;
            // 
            // unpaidTableAdapter
            // 
            this.unpaidTableAdapter.ClearBeforeFill = true;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.White;
            this.panel18.Controls.Add(this.panel19);
            this.panel18.Location = new System.Drawing.Point(218, 50);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(4, 36);
            this.panel18.TabIndex = 464;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel19.Location = new System.Drawing.Point(0, -10);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(179, 2);
            this.panel19.TabIndex = 442;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.White;
            this.panel20.Controls.Add(this.panel21);
            this.panel20.Location = new System.Drawing.Point(43, 51);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(2, 32);
            this.panel20.TabIndex = 461;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel21.Location = new System.Drawing.Point(0, -10);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(179, 2);
            this.panel21.TabIndex = 442;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.White;
            this.panel22.Controls.Add(this.panel23);
            this.panel22.Location = new System.Drawing.Point(38, 85);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(181, 5);
            this.panel22.TabIndex = 465;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel23.Location = new System.Drawing.Point(0, -10);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(179, 2);
            this.panel23.TabIndex = 442;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.White;
            this.panel24.Controls.Add(this.panel25);
            this.panel24.Location = new System.Drawing.Point(40, 52);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(176, 5);
            this.panel24.TabIndex = 462;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel25.Location = new System.Drawing.Point(0, -10);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(179, 2);
            this.panel25.TabIndex = 442;
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.White;
            this.panel26.Controls.Add(this.panel27);
            this.panel26.Location = new System.Drawing.Point(40, 78);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(176, 5);
            this.panel26.TabIndex = 459;
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel27.Location = new System.Drawing.Point(0, -10);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(179, 2);
            this.panel27.TabIndex = 442;
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel28.Controls.Add(this.panel29);
            this.panel28.Location = new System.Drawing.Point(216, 49);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(2, 36);
            this.panel28.TabIndex = 463;
            // 
            // panel29
            // 
            this.panel29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel29.Location = new System.Drawing.Point(0, -10);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(179, 2);
            this.panel29.TabIndex = 442;
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel30.Controls.Add(this.panel31);
            this.panel30.Location = new System.Drawing.Point(38, 49);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(2, 36);
            this.panel30.TabIndex = 460;
            // 
            // panel31
            // 
            this.panel31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel31.Location = new System.Drawing.Point(0, -10);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(179, 2);
            this.panel31.TabIndex = 442;
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel32.Location = new System.Drawing.Point(39, 83);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(179, 2);
            this.panel32.TabIndex = 458;
            // 
            // panel33
            // 
            this.panel33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel33.Controls.Add(this.panel34);
            this.panel33.Location = new System.Drawing.Point(38, 48);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(179, 2);
            this.panel33.TabIndex = 457;
            // 
            // panel34
            // 
            this.panel34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel34.Location = new System.Drawing.Point(0, -10);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(179, 2);
            this.panel34.TabIndex = 442;
            // 
            // comboBoxFullname
            // 
            this.comboBoxFullname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFullname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFullname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxFullname.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFullname.Location = new System.Drawing.Point(43, 53);
            this.comboBoxFullname.Name = "comboBoxFullname";
            this.comboBoxFullname.Size = new System.Drawing.Size(179, 35);
            this.comboBoxFullname.TabIndex = 456;
            this.comboBoxFullname.SelectedIndexChanged += new System.EventHandler(this.comboBoxFullname_SelectedIndexChanged_1);
            // 
            // guna2ComboBoxVideoUnpaid
            // 
            this.guna2ComboBoxVideoUnpaid.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxVideoUnpaid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxVideoUnpaid.BorderThickness = 2;
            this.guna2ComboBoxVideoUnpaid.DisplayMember = "VideoID";
            this.guna2ComboBoxVideoUnpaid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxVideoUnpaid.DropDownHeight = 150;
            this.guna2ComboBoxVideoUnpaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxVideoUnpaid.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxVideoUnpaid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxVideoUnpaid.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.guna2ComboBoxVideoUnpaid.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBoxVideoUnpaid.IntegralHeight = false;
            this.guna2ComboBoxVideoUnpaid.ItemHeight = 30;
            this.guna2ComboBoxVideoUnpaid.Location = new System.Drawing.Point(231, 49);
            this.guna2ComboBoxVideoUnpaid.Name = "guna2ComboBoxVideoUnpaid";
            this.guna2ComboBoxVideoUnpaid.Size = new System.Drawing.Size(170, 36);
            this.guna2ComboBoxVideoUnpaid.TabIndex = 389;
            this.guna2ComboBoxVideoUnpaid.ValueMember = "VideoID";
            this.guna2ComboBoxVideoUnpaid.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBoxTitle_SelectedIndexChanged);
            // 
            // guna2TextBoxPenalty
            // 
            this.guna2TextBoxPenalty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBoxPenalty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxPenalty.BorderThickness = 2;
            this.guna2TextBoxPenalty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxPenalty.DefaultText = "";
            this.guna2TextBoxPenalty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxPenalty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxPenalty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPenalty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPenalty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxPenalty.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.guna2TextBoxPenalty.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxPenalty.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxPenalty.Location = new System.Drawing.Point(406, 49);
            this.guna2TextBoxPenalty.Margin = new System.Windows.Forms.Padding(2);
            this.guna2TextBoxPenalty.Name = "guna2TextBoxPenalty";
            this.guna2TextBoxPenalty.Padding = new System.Windows.Forms.Padding(5);
            this.guna2TextBoxPenalty.PlaceholderForeColor = System.Drawing.Color.White;
            this.guna2TextBoxPenalty.PlaceholderText = "";
            this.guna2TextBoxPenalty.SelectedText = "";
            this.guna2TextBoxPenalty.Size = new System.Drawing.Size(179, 36);
            this.guna2TextBoxPenalty.TabIndex = 466;
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
            this.guna2ButtonAdd.Location = new System.Drawing.Point(849, 483);
            this.guna2ButtonAdd.Name = "guna2ButtonAdd";
            this.guna2ButtonAdd.Size = new System.Drawing.Size(100, 36);
            this.guna2ButtonAdd.TabIndex = 467;
            this.guna2ButtonAdd.Text = "Add";
            this.guna2ButtonAdd.Click += new System.EventHandler(this.guna2ButtonAdd_Click);
            // 
            // RentalID
            // 
            this.RentalID.HeaderText = "RentalID";
            this.RentalID.Name = "RentalID";
            this.RentalID.ReadOnly = true;
            this.RentalID.Visible = false;
            // 
            // VideoID
            // 
            this.VideoID.HeaderText = "VideoID";
            this.VideoID.Name = "VideoID";
            this.VideoID.ReadOnly = true;
            this.VideoID.Visible = false;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // Fullname
            // 
            this.Fullname.HeaderText = "Fullname";
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            this.Fullname.Visible = false;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Penalty
            // 
            this.Penalty.HeaderText = "Penalty";
            this.Penalty.Name = "Penalty";
            this.Penalty.ReadOnly = true;
            // 
            // guna2TextBoxRentalID
            // 
            this.guna2TextBoxRentalID.BorderColor = System.Drawing.Color.White;
            this.guna2TextBoxRentalID.BorderThickness = 2;
            this.guna2TextBoxRentalID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxRentalID.DefaultText = "";
            this.guna2TextBoxRentalID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxRentalID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxRentalID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxRentalID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxRentalID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2TextBoxRentalID.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.guna2TextBoxRentalID.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxRentalID.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxRentalID.Location = new System.Drawing.Point(343, 31);
            this.guna2TextBoxRentalID.Margin = new System.Windows.Forms.Padding(2);
            this.guna2TextBoxRentalID.Name = "guna2TextBoxRentalID";
            this.guna2TextBoxRentalID.Padding = new System.Windows.Forms.Padding(5);
            this.guna2TextBoxRentalID.PlaceholderForeColor = System.Drawing.Color.White;
            this.guna2TextBoxRentalID.PlaceholderText = "";
            this.guna2TextBoxRentalID.ReadOnly = true;
            this.guna2TextBoxRentalID.SelectedText = "";
            this.guna2TextBoxRentalID.Size = new System.Drawing.Size(58, 15);
            this.guna2TextBoxRentalID.TabIndex = 468;
            this.guna2TextBoxRentalID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 469;
            this.label1.Text = "Unpaid Penalty";
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TextBoxRentalID);
            this.Controls.Add(this.guna2ButtonAdd);
            this.Controls.Add(this.guna2TextBoxPenalty);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel22);
            this.Controls.Add(this.panel24);
            this.Controls.Add(this.panel26);
            this.Controls.Add(this.panel28);
            this.Controls.Add(this.panel30);
            this.Controls.Add(this.panel32);
            this.Controls.Add(this.panel33);
            this.Controls.Add(this.comboBoxFullname);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2TextBoxCash);
            this.Controls.Add(this.guna2TextBoxChange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2TextBoxCustomerID);
            this.Controls.Add(this.reportViewerPayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2ComboBoxVideoUnpaid);
            this.Controls.Add(this.guna2Buttonreturn);
            this.Controls.Add(this.DGVUnpaid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUnpaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpaidBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpaidBindingSource)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel33.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DGVUnpaid;
        private Guna.UI2.WinForms.Guna2Button guna2Buttonreturn;
        private System.Windows.Forms.Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPayment;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxCustomerID;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxCash;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label5;
        private DataSet.DSReports dSReports;
        private System.Windows.Forms.BindingSource unpaidBindingSource;
        private DataSet.DSReportsTableAdapters.UnpaidTableAdapter unpaidTableAdapter;
        private System.Windows.Forms.BindingSource unpaidBindingSource1;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.ComboBox comboBoxFullname;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxVideoUnpaid;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxPenalty;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Penalty;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxRentalID;
        private System.Windows.Forms.Label label1;
    }
}