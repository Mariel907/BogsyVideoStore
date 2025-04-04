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
            this.G2DGVItemLedger = new Guna.UI2.WinForms.Guna2DataGridView();
            this.getAllItemLedgerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSReports = new Project.DataSet.DSReports();
            this.getAllItemLedgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllItemLedgerTableAdapter = new Project.DataSet.DSReportsTableAdapters.GetAllItemLedgerTableAdapter();
            this.dSReports1 = new Project.DataSet.DSReports();
            this.getAllItemLedgerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.documentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.G2DGVItemLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllItemLedgerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllItemLedgerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllItemLedgerBindingSource2)).BeginInit();
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
            this.G2DGVItemLedger.Location = new System.Drawing.Point(12, 13);
            this.G2DGVItemLedger.Margin = new System.Windows.Forms.Padding(4);
            this.G2DGVItemLedger.Name = "G2DGVItemLedger";
            this.G2DGVItemLedger.ReadOnly = true;
            this.G2DGVItemLedger.RowHeadersVisible = false;
            this.G2DGVItemLedger.Size = new System.Drawing.Size(1111, 539);
            this.G2DGVItemLedger.TabIndex = 363;
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
            // dSReports1
            // 
            this.dSReports1.DataSetName = "DSReports";
            this.dSReports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getAllItemLedgerBindingSource2
            // 
            this.getAllItemLedgerBindingSource2.DataMember = "GetAllItemLedger";
            this.getAllItemLedgerBindingSource2.DataSource = this.dSReports1;
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
            // ItemLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 565);
            this.Controls.Add(this.G2DGVItemLedger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemLedger";
            this.Text = "ItemLedger";
            this.Load += new System.EventHandler(this.ItemLedger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.G2DGVItemLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllItemLedgerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllItemLedgerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllItemLedgerBindingSource2)).EndInit();
            this.ResumeLayout(false);

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
    }
}