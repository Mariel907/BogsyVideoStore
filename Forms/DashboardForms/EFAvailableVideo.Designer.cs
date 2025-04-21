namespace Project.Forms.DashboardForms
{
    partial class EFAvailableVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EFAvailableVideo));
            this.DGVAvailableVideo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copiesAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAvailableVideoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.G2TxbxAvailableVideo = new Guna.UI2.WinForms.Guna2TextBox();
            this.G2CmbxAvailableVideo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAvailableVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAvailableVideoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVAvailableVideo
            // 
            this.DGVAvailableVideo.AllowUserToAddRows = false;
            this.DGVAvailableVideo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGVAvailableVideo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVAvailableVideo.AutoGenerateColumns = false;
            this.DGVAvailableVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVAvailableVideo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVAvailableVideo.ColumnHeadersHeight = 35;
            this.DGVAvailableVideo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVAvailableVideo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.copiesAvailableDataGridViewTextBoxColumn});
            this.DGVAvailableVideo.DataSource = this.mAvailableVideoBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVAvailableVideo.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVAvailableVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVAvailableVideo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVAvailableVideo.Location = new System.Drawing.Point(10, 62);
            this.DGVAvailableVideo.Margin = new System.Windows.Forms.Padding(4);
            this.DGVAvailableVideo.Name = "DGVAvailableVideo";
            this.DGVAvailableVideo.ReadOnly = true;
            this.DGVAvailableVideo.RowHeadersVisible = false;
            this.DGVAvailableVideo.Size = new System.Drawing.Size(1001, 372);
            this.DGVAvailableVideo.TabIndex = 379;
            this.DGVAvailableVideo.Tag = "book_id";
            this.DGVAvailableVideo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVAvailableVideo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVAvailableVideo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVAvailableVideo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVAvailableVideo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVAvailableVideo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVAvailableVideo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVAvailableVideo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.DGVAvailableVideo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVAvailableVideo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVAvailableVideo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVAvailableVideo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVAvailableVideo.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVAvailableVideo.ThemeStyle.ReadOnly = true;
            this.DGVAvailableVideo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.DGVAvailableVideo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVAvailableVideo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVAvailableVideo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVAvailableVideo.ThemeStyle.RowsStyle.Height = 22;
            this.DGVAvailableVideo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.DGVAvailableVideo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
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
            // copiesAvailableDataGridViewTextBoxColumn
            // 
            this.copiesAvailableDataGridViewTextBoxColumn.DataPropertyName = "CopiesAvailable";
            this.copiesAvailableDataGridViewTextBoxColumn.HeaderText = "CopiesAvailable";
            this.copiesAvailableDataGridViewTextBoxColumn.Name = "copiesAvailableDataGridViewTextBoxColumn";
            this.copiesAvailableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mAvailableVideoBindingSource
            // 
            this.mAvailableVideoBindingSource.DataSource = typeof(Project.Model.MAvailableVideo);
            // 
            // G2TxbxAvailableVideo
            // 
            this.G2TxbxAvailableVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G2TxbxAvailableVideo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2TxbxAvailableVideo.BorderThickness = 2;
            this.G2TxbxAvailableVideo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.G2TxbxAvailableVideo.DefaultText = "";
            this.G2TxbxAvailableVideo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.G2TxbxAvailableVideo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.G2TxbxAvailableVideo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.G2TxbxAvailableVideo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.G2TxbxAvailableVideo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G2TxbxAvailableVideo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2TxbxAvailableVideo.ForeColor = System.Drawing.Color.Black;
            this.G2TxbxAvailableVideo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.G2TxbxAvailableVideo.IconLeft = ((System.Drawing.Image)(resources.GetObject("G2TxbxAvailableVideo.IconLeft")));
            this.G2TxbxAvailableVideo.Location = new System.Drawing.Point(134, 9);
            this.G2TxbxAvailableVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.G2TxbxAvailableVideo.Name = "G2TxbxAvailableVideo";
            this.G2TxbxAvailableVideo.PlaceholderText = "";
            this.G2TxbxAvailableVideo.SelectedText = "";
            this.G2TxbxAvailableVideo.Size = new System.Drawing.Size(867, 36);
            this.G2TxbxAvailableVideo.TabIndex = 384;
            this.G2TxbxAvailableVideo.TextChanged += new System.EventHandler(this.G2TxbxAvailableVideo_TextChanged);
            // 
            // G2CmbxAvailableVideo
            // 
            this.G2CmbxAvailableVideo.BackColor = System.Drawing.Color.Transparent;
            this.G2CmbxAvailableVideo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxAvailableVideo.BorderThickness = 2;
            this.G2CmbxAvailableVideo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.G2CmbxAvailableVideo.DropDownHeight = 150;
            this.G2CmbxAvailableVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.G2CmbxAvailableVideo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxAvailableVideo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2CmbxAvailableVideo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2CmbxAvailableVideo.ForeColor = System.Drawing.Color.Black;
            this.G2CmbxAvailableVideo.IntegralHeight = false;
            this.G2CmbxAvailableVideo.ItemHeight = 30;
            this.G2CmbxAvailableVideo.Items.AddRange(new object[] {
            "DVD",
            "VCD"});
            this.G2CmbxAvailableVideo.Location = new System.Drawing.Point(0, 9);
            this.G2CmbxAvailableVideo.Name = "G2CmbxAvailableVideo";
            this.G2CmbxAvailableVideo.Size = new System.Drawing.Size(127, 36);
            this.G2CmbxAvailableVideo.TabIndex = 385;
            this.G2CmbxAvailableVideo.SelectedIndexChanged += new System.EventHandler(this.G2CmbxAvailableVideo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.G2TxbxAvailableVideo);
            this.panel1.Controls.Add(this.G2CmbxAvailableVideo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 52);
            this.panel1.TabIndex = 386;
            // 
            // EFAvailableVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 444);
            this.Controls.Add(this.DGVAvailableVideo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EFAvailableVideo";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "EFAvailableVideo";
            this.Load += new System.EventHandler(this.EFAvailableVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAvailableVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAvailableVideoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DGVAvailableVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn copiesAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mAvailableVideoBindingSource;
        private Guna.UI2.WinForms.Guna2TextBox G2TxbxAvailableVideo;
        private Guna.UI2.WinForms.Guna2ComboBox G2CmbxAvailableVideo;
        private System.Windows.Forms.Panel panel1;
    }
}