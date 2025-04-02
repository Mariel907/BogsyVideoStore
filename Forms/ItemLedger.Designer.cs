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
            this.G2DGVAddSave = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dSReports = new Project.DataSet.DSReports();
            this.getAllItemLedgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllItemLedgerTableAdapter = new Project.DataSet.DSReportsTableAdapters.GetAllItemLedgerTableAdapter();
            this.entryNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.G2DGVAddSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllItemLedgerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // G2DGVAddSave
            // 
            this.G2DGVAddSave.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.G2DGVAddSave.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.G2DGVAddSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G2DGVAddSave.AutoGenerateColumns = false;
            this.G2DGVAddSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.G2DGVAddSave.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.G2DGVAddSave.ColumnHeadersHeight = 35;
            this.G2DGVAddSave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.G2DGVAddSave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entryNoDataGridViewTextBoxColumn,
            this.documentNoDataGridViewTextBoxColumn,
            this.videoIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.serialNoDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.G2DGVAddSave.DataSource = this.getAllItemLedgerBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.G2DGVAddSave.DefaultCellStyle = dataGridViewCellStyle3;
            this.G2DGVAddSave.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.G2DGVAddSave.Location = new System.Drawing.Point(12, 49);
            this.G2DGVAddSave.Margin = new System.Windows.Forms.Padding(4);
            this.G2DGVAddSave.Name = "G2DGVAddSave";
            this.G2DGVAddSave.RowHeadersVisible = false;
            this.G2DGVAddSave.Size = new System.Drawing.Size(1085, 386);
            this.G2DGVAddSave.TabIndex = 363;
            this.G2DGVAddSave.Tag = "book_id";
            this.G2DGVAddSave.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.G2DGVAddSave.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.G2DGVAddSave.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.G2DGVAddSave.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.G2DGVAddSave.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.G2DGVAddSave.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.G2DGVAddSave.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.G2DGVAddSave.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2DGVAddSave.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.G2DGVAddSave.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2DGVAddSave.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.G2DGVAddSave.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.G2DGVAddSave.ThemeStyle.HeaderStyle.Height = 35;
            this.G2DGVAddSave.ThemeStyle.ReadOnly = false;
            this.G2DGVAddSave.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.G2DGVAddSave.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.G2DGVAddSave.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2DGVAddSave.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.G2DGVAddSave.ThemeStyle.RowsStyle.Height = 22;
            this.G2DGVAddSave.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.G2DGVAddSave.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
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
            // entryNoDataGridViewTextBoxColumn
            // 
            this.entryNoDataGridViewTextBoxColumn.DataPropertyName = "EntryNo";
            this.entryNoDataGridViewTextBoxColumn.HeaderText = "EntryNo";
            this.entryNoDataGridViewTextBoxColumn.Name = "entryNoDataGridViewTextBoxColumn";
            this.entryNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.entryNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // documentNoDataGridViewTextBoxColumn
            // 
            this.documentNoDataGridViewTextBoxColumn.DataPropertyName = "DocumentNo";
            this.documentNoDataGridViewTextBoxColumn.HeaderText = "DocumentNo";
            this.documentNoDataGridViewTextBoxColumn.Name = "documentNoDataGridViewTextBoxColumn";
            // 
            // videoIDDataGridViewTextBoxColumn
            // 
            this.videoIDDataGridViewTextBoxColumn.DataPropertyName = "VideoID";
            this.videoIDDataGridViewTextBoxColumn.HeaderText = "VideoID";
            this.videoIDDataGridViewTextBoxColumn.Name = "videoIDDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // serialNoDataGridViewTextBoxColumn
            // 
            this.serialNoDataGridViewTextBoxColumn.DataPropertyName = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // ItemLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 450);
            this.Controls.Add(this.G2DGVAddSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemLedger";
            this.Text = "ItemLedger";
            this.Load += new System.EventHandler(this.ItemLedger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.G2DGVAddSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllItemLedgerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView G2DGVAddSave;
        private DataSet.DSReports dSReports;
        private System.Windows.Forms.BindingSource getAllItemLedgerBindingSource;
        private DataSet.DSReportsTableAdapters.GetAllItemLedgerTableAdapter getAllItemLedgerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    }
}