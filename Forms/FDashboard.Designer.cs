namespace Project.Forms
{
    partial class FDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PnlReturned = new System.Windows.Forms.Panel();
            this.LblReturned = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PnlOverdueRent = new System.Windows.Forms.Panel();
            this.lblOverdueRent = new System.Windows.Forms.Label();
            this.LblTitleDue = new System.Windows.Forms.Label();
            this.PnlTotalVideo = new System.Windows.Forms.Panel();
            this.LblTotalVideo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PnlRented = new System.Windows.Forms.Panel();
            this.lblRented = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlAvailableVideo = new System.Windows.Forms.Panel();
            this.lblAvailableVideo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PnlBackEarnings = new System.Windows.Forms.Panel();
            this.lblEarnings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.PctrDue = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PnlReturned.SuspendLayout();
            this.PnlOverdueRent.SuspendLayout();
            this.PnlTotalVideo.SuspendLayout();
            this.PnlRented.SuspendLayout();
            this.PnlAvailableVideo.SuspendLayout();
            this.PnlBackEarnings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrDue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1135, 568);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.PnlReturned, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.PnlOverdueRent, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PnlTotalVideo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PnlRented, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PnlAvailableVideo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PnlBackEarnings, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1115, 258);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PnlReturned
            // 
            this.PnlReturned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.PnlReturned.Controls.Add(this.pictureBox6);
            this.PnlReturned.Controls.Add(this.LblReturned);
            this.PnlReturned.Controls.Add(this.label12);
            this.PnlReturned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlReturned.Location = new System.Drawing.Point(742, 129);
            this.PnlReturned.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.PnlReturned.Name = "PnlReturned";
            this.PnlReturned.Size = new System.Drawing.Size(373, 119);
            this.PnlReturned.TabIndex = 5;
            this.PnlReturned.Click += new System.EventHandler(this.PnlReturned_Click);
            // 
            // LblReturned
            // 
            this.LblReturned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblReturned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.LblReturned.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReturned.ForeColor = System.Drawing.Color.White;
            this.LblReturned.Location = new System.Drawing.Point(99, 81);
            this.LblReturned.Name = "LblReturned";
            this.LblReturned.Size = new System.Drawing.Size(274, 35);
            this.LblReturned.TabIndex = 11;
            this.LblReturned.Text = "0";
            this.LblReturned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(95, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 25);
            this.label12.TabIndex = 10;
            this.label12.Text = "Returned";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlOverdueRent
            // 
            this.PnlOverdueRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PnlOverdueRent.Controls.Add(this.PctrDue);
            this.PnlOverdueRent.Controls.Add(this.lblOverdueRent);
            this.PnlOverdueRent.Controls.Add(this.LblTitleDue);
            this.PnlOverdueRent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlOverdueRent.Location = new System.Drawing.Point(742, 0);
            this.PnlOverdueRent.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.PnlOverdueRent.Name = "PnlOverdueRent";
            this.PnlOverdueRent.Size = new System.Drawing.Size(373, 119);
            this.PnlOverdueRent.TabIndex = 4;
            this.PnlOverdueRent.Click += new System.EventHandler(this.PnlOverdueRent_Click);
            // 
            // lblOverdueRent
            // 
            this.lblOverdueRent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOverdueRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOverdueRent.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdueRent.ForeColor = System.Drawing.Color.White;
            this.lblOverdueRent.Location = new System.Drawing.Point(99, 81);
            this.lblOverdueRent.Name = "lblOverdueRent";
            this.lblOverdueRent.Size = new System.Drawing.Size(274, 35);
            this.lblOverdueRent.TabIndex = 11;
            this.lblOverdueRent.Text = "0";
            this.lblOverdueRent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTitleDue
            // 
            this.LblTitleDue.AutoSize = true;
            this.LblTitleDue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitleDue.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleDue.ForeColor = System.Drawing.Color.White;
            this.LblTitleDue.Location = new System.Drawing.Point(95, 29);
            this.LblTitleDue.Name = "LblTitleDue";
            this.LblTitleDue.Size = new System.Drawing.Size(128, 25);
            this.LblTitleDue.TabIndex = 10;
            this.LblTitleDue.Text = "Overdue Rent";
            this.LblTitleDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlTotalVideo
            // 
            this.PnlTotalVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.PnlTotalVideo.Controls.Add(this.pictureBox3);
            this.PnlTotalVideo.Controls.Add(this.LblTotalVideo);
            this.PnlTotalVideo.Controls.Add(this.label6);
            this.PnlTotalVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTotalVideo.Location = new System.Drawing.Point(371, 129);
            this.PnlTotalVideo.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.PnlTotalVideo.Name = "PnlTotalVideo";
            this.PnlTotalVideo.Size = new System.Drawing.Size(361, 119);
            this.PnlTotalVideo.TabIndex = 3;
            this.PnlTotalVideo.Click += new System.EventHandler(this.PnlTotalVideo_Click);
            // 
            // LblTotalVideo
            // 
            this.LblTotalVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotalVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.LblTotalVideo.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalVideo.ForeColor = System.Drawing.Color.White;
            this.LblTotalVideo.Location = new System.Drawing.Point(100, 77);
            this.LblTotalVideo.Name = "LblTotalVideo";
            this.LblTotalVideo.Size = new System.Drawing.Size(261, 39);
            this.LblTotalVideo.TabIndex = 11;
            this.LblTotalVideo.Text = "0";
            this.LblTotalVideo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(95, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Video";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlRented
            // 
            this.PnlRented.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.PnlRented.Controls.Add(this.pictureBox2);
            this.PnlRented.Controls.Add(this.lblRented);
            this.PnlRented.Controls.Add(this.label4);
            this.PnlRented.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlRented.Location = new System.Drawing.Point(0, 129);
            this.PnlRented.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.PnlRented.Name = "PnlRented";
            this.PnlRented.Size = new System.Drawing.Size(361, 119);
            this.PnlRented.TabIndex = 2;
            this.PnlRented.Click += new System.EventHandler(this.PnlRented_Click);
            // 
            // lblRented
            // 
            this.lblRented.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRented.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.lblRented.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRented.ForeColor = System.Drawing.Color.White;
            this.lblRented.Location = new System.Drawing.Point(99, 77);
            this.lblRented.Name = "lblRented";
            this.lblRented.Size = new System.Drawing.Size(262, 39);
            this.lblRented.TabIndex = 11;
            this.lblRented.Text = "0";
            this.lblRented.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(95, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rented";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlAvailableVideo
            // 
            this.PnlAvailableVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.PnlAvailableVideo.Controls.Add(this.pictureBox4);
            this.PnlAvailableVideo.Controls.Add(this.lblAvailableVideo);
            this.PnlAvailableVideo.Controls.Add(this.label8);
            this.PnlAvailableVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlAvailableVideo.Location = new System.Drawing.Point(371, 0);
            this.PnlAvailableVideo.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.PnlAvailableVideo.Name = "PnlAvailableVideo";
            this.PnlAvailableVideo.Size = new System.Drawing.Size(361, 119);
            this.PnlAvailableVideo.TabIndex = 1;
            this.PnlAvailableVideo.Click += new System.EventHandler(this.PnlAvailableVideo_Click);
            // 
            // lblAvailableVideo
            // 
            this.lblAvailableVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailableVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.lblAvailableVideo.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableVideo.ForeColor = System.Drawing.Color.White;
            this.lblAvailableVideo.Location = new System.Drawing.Point(98, 81);
            this.lblAvailableVideo.Name = "lblAvailableVideo";
            this.lblAvailableVideo.Size = new System.Drawing.Size(263, 35);
            this.lblAvailableVideo.TabIndex = 11;
            this.lblAvailableVideo.Text = "0";
            this.lblAvailableVideo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(95, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Available Video";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlBackEarnings
            // 
            this.PnlBackEarnings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.PnlBackEarnings.Controls.Add(this.pictureBox1);
            this.PnlBackEarnings.Controls.Add(this.lblEarnings);
            this.PnlBackEarnings.Controls.Add(this.label1);
            this.PnlBackEarnings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBackEarnings.Location = new System.Drawing.Point(0, 0);
            this.PnlBackEarnings.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.PnlBackEarnings.Name = "PnlBackEarnings";
            this.PnlBackEarnings.Size = new System.Drawing.Size(361, 119);
            this.PnlBackEarnings.TabIndex = 0;
            this.PnlBackEarnings.Click += new System.EventHandler(this.PnlBackEarnings_Click);
            this.PnlBackEarnings.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlBackEarnings_Paint);
            // 
            // lblEarnings
            // 
            this.lblEarnings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEarnings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.lblEarnings.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarnings.ForeColor = System.Drawing.Color.White;
            this.lblEarnings.Location = new System.Drawing.Point(97, 79);
            this.lblEarnings.Name = "lblEarnings";
            this.lblEarnings.Size = new System.Drawing.Size(260, 39);
            this.lblEarnings.TabIndex = 11;
            this.lblEarnings.Text = "0";
            this.lblEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Earnings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(89, 88);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // PctrDue
            // 
            this.PctrDue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PctrDue.Image = ((System.Drawing.Image)(resources.GetObject("PctrDue.Image")));
            this.PctrDue.Location = new System.Drawing.Point(0, 0);
            this.PctrDue.Name = "PctrDue";
            this.PctrDue.Size = new System.Drawing.Size(89, 88);
            this.PctrDue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrDue.TabIndex = 16;
            this.PctrDue.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(89, 88);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 88);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 568);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDashboard";
            this.Text = "FDashboard";
            this.Load += new System.EventHandler(this.FDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PnlReturned.ResumeLayout(false);
            this.PnlReturned.PerformLayout();
            this.PnlOverdueRent.ResumeLayout(false);
            this.PnlOverdueRent.PerformLayout();
            this.PnlTotalVideo.ResumeLayout(false);
            this.PnlTotalVideo.PerformLayout();
            this.PnlRented.ResumeLayout(false);
            this.PnlRented.PerformLayout();
            this.PnlAvailableVideo.ResumeLayout(false);
            this.PnlAvailableVideo.PerformLayout();
            this.PnlBackEarnings.ResumeLayout(false);
            this.PnlBackEarnings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrDue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PnlBackEarnings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEarnings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlAvailableVideo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblAvailableVideo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PnlTotalVideo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LblTotalVideo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PnlRented;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblRented;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PnlReturned;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label LblReturned;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel PnlOverdueRent;
        private System.Windows.Forms.PictureBox PctrDue;
        private System.Windows.Forms.Label lblOverdueRent;
        private System.Windows.Forms.Label LblTitleDue;
    }
}