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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVUnpaid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Buttonreturn = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2ComboBoxCustomerName = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUnpaid)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVUnpaid
            // 
            this.DGVUnpaid.AllowUserToAddRows = false;
            this.DGVUnpaid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVUnpaid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVUnpaid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVUnpaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUnpaid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVUnpaid.ColumnHeadersHeight = 35;
            this.DGVUnpaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVUnpaid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVUnpaid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVUnpaid.Location = new System.Drawing.Point(40, 92);
            this.DGVUnpaid.Margin = new System.Windows.Forms.Padding(4);
            this.DGVUnpaid.Name = "DGVUnpaid";
            this.DGVUnpaid.ReadOnly = true;
            this.DGVUnpaid.RowHeadersVisible = false;
            this.DGVUnpaid.Size = new System.Drawing.Size(1053, 369);
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
            this.guna2Buttonreturn.Location = new System.Drawing.Point(970, 468);
            this.guna2Buttonreturn.Name = "guna2Buttonreturn";
            this.guna2Buttonreturn.Size = new System.Drawing.Size(123, 46);
            this.guna2Buttonreturn.TabIndex = 377;
            this.guna2Buttonreturn.Text = "Paid";
            this.guna2Buttonreturn.Click += new System.EventHandler(this.guna2Buttonreturn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 391;
            this.label4.Text = "Customer Name ";
            // 
            // guna2ComboBoxCustomerName
            // 
            this.guna2ComboBoxCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxCustomerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxCustomerName.BorderThickness = 2;
            this.guna2ComboBoxCustomerName.DisplayMember = "VideoID";
            this.guna2ComboBoxCustomerName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxCustomerName.DropDownHeight = 150;
            this.guna2ComboBoxCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxCustomerName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ComboBoxCustomerName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.guna2ComboBoxCustomerName.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBoxCustomerName.IntegralHeight = false;
            this.guna2ComboBoxCustomerName.ItemHeight = 30;
            this.guna2ComboBoxCustomerName.Location = new System.Drawing.Point(40, 49);
            this.guna2ComboBoxCustomerName.Name = "guna2ComboBoxCustomerName";
            this.guna2ComboBoxCustomerName.Size = new System.Drawing.Size(217, 36);
            this.guna2ComboBoxCustomerName.TabIndex = 389;
            this.guna2ComboBoxCustomerName.ValueMember = "VideoID";
            this.guna2ComboBoxCustomerName.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBoxCustomerName_SelectedIndexChanged);
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 526);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2ComboBoxCustomerName);
            this.Controls.Add(this.guna2Buttonreturn);
            this.Controls.Add(this.DGVUnpaid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUnpaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DGVUnpaid;
        private Guna.UI2.WinForms.Guna2Button guna2Buttonreturn;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxCustomerName;
    }
}