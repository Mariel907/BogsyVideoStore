namespace Project.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel6 = new System.Windows.Forms.Panel();
            this.PctrBxDashboard = new System.Windows.Forms.PictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Itemledger = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonReports = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonPayments = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonDVDVCD = new Guna.UI2.WinForms.Guna2Button();
            this.G2BtnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.TransTimer = new System.Windows.Forms.Timer(this.components);
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.guna2ButtonTransactions = new Guna.UI2.WinForms.Guna2Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxDashboard)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel6.Controls.Add(this.PctrBxDashboard);
            this.panel6.Controls.Add(this.LblTitle);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(215, 52);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1135, 61);
            this.panel6.TabIndex = 2;
            // 
            // PctrBxDashboard
            // 
            this.PctrBxDashboard.Image = global::Project.Properties.Resources.icons8_dashboard_96;
            this.PctrBxDashboard.Location = new System.Drawing.Point(7, 5);
            this.PctrBxDashboard.Name = "PctrBxDashboard";
            this.PctrBxDashboard.Size = new System.Drawing.Size(48, 50);
            this.PctrBxDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrBxDashboard.TabIndex = 1;
            this.PctrBxDashboard.TabStop = false;
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(1135, 61);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Dashboard";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(215, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1135, 52);
            this.panel5.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1135, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bogsy Video Store";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.panel4.Controls.Add(this.Itemledger);
            this.panel4.Controls.Add(this.guna2ButtonReports);
            this.panel4.Controls.Add(this.guna2ButtonPayments);
            this.panel4.Controls.Add(this.guna2ButtonTransactions);
            this.panel4.Controls.Add(this.guna2ButtonCustomer);
            this.panel4.Controls.Add(this.guna2ButtonDVDVCD);
            this.panel4.Controls.Add(this.G2BtnDashboard);
            this.panel4.Controls.Add(this.guna2Panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 681);
            this.panel4.TabIndex = 0;
            // 
            // Itemledger
            // 
            this.Itemledger.BorderColor = System.Drawing.Color.Transparent;
            this.Itemledger.BorderThickness = 1;
            this.Itemledger.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Itemledger.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Itemledger.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Itemledger.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Itemledger.Dock = System.Windows.Forms.DockStyle.Top;
            this.Itemledger.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.Itemledger.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.Itemledger.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F);
            this.Itemledger.ForeColor = System.Drawing.Color.White;
            this.Itemledger.Image = ((System.Drawing.Image)(resources.GetObject("Itemledger.Image")));
            this.Itemledger.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Itemledger.ImageSize = new System.Drawing.Size(30, 30);
            this.Itemledger.Location = new System.Drawing.Point(0, 347);
            this.Itemledger.Name = "Itemledger";
            this.Itemledger.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.Itemledger.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.Itemledger.Size = new System.Drawing.Size(215, 39);
            this.Itemledger.TabIndex = 5;
            this.Itemledger.Text = "Item Ledger";
            this.Itemledger.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Itemledger.Click += new System.EventHandler(this.Form_Click);
            // 
            // guna2ButtonReports
            // 
            this.guna2ButtonReports.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ButtonReports.BorderThickness = 1;
            this.guna2ButtonReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ButtonReports.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ButtonReports.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonReports.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonReports.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonReports.Image")));
            this.guna2ButtonReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonReports.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ButtonReports.Location = new System.Drawing.Point(0, 308);
            this.guna2ButtonReports.Name = "guna2ButtonReports";
            this.guna2ButtonReports.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.guna2ButtonReports.Size = new System.Drawing.Size(215, 39);
            this.guna2ButtonReports.TabIndex = 4;
            this.guna2ButtonReports.Text = "Reports";
            this.guna2ButtonReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonReports.Click += new System.EventHandler(this.Form_Click);
            // 
            // guna2ButtonPayments
            // 
            this.guna2ButtonPayments.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ButtonPayments.BorderThickness = 1;
            this.guna2ButtonPayments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonPayments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonPayments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonPayments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ButtonPayments.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ButtonPayments.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F);
            this.guna2ButtonPayments.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonPayments.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonPayments.Image")));
            this.guna2ButtonPayments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonPayments.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ButtonPayments.Location = new System.Drawing.Point(0, 269);
            this.guna2ButtonPayments.Name = "guna2ButtonPayments";
            this.guna2ButtonPayments.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.guna2ButtonPayments.Size = new System.Drawing.Size(215, 39);
            this.guna2ButtonPayments.TabIndex = 3;
            this.guna2ButtonPayments.Text = "Payments";
            this.guna2ButtonPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonPayments.Click += new System.EventHandler(this.Form_Click);
            // 
            // guna2ButtonCustomer
            // 
            this.guna2ButtonCustomer.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ButtonCustomer.BorderThickness = 1;
            this.guna2ButtonCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ButtonCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ButtonCustomer.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonCustomer.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonCustomer.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonCustomer.Image")));
            this.guna2ButtonCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonCustomer.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ButtonCustomer.Location = new System.Drawing.Point(0, 191);
            this.guna2ButtonCustomer.Name = "guna2ButtonCustomer";
            this.guna2ButtonCustomer.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.guna2ButtonCustomer.PressedColor = System.Drawing.Color.Azure;
            this.guna2ButtonCustomer.Size = new System.Drawing.Size(215, 39);
            this.guna2ButtonCustomer.TabIndex = 1;
            this.guna2ButtonCustomer.Text = "Customer";
            this.guna2ButtonCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonCustomer.Click += new System.EventHandler(this.Form_Click);
            // 
            // guna2ButtonDVDVCD
            // 
            this.guna2ButtonDVDVCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ButtonDVDVCD.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ButtonDVDVCD.BorderThickness = 1;
            this.guna2ButtonDVDVCD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDVDVCD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDVDVCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonDVDVCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonDVDVCD.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ButtonDVDVCD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ButtonDVDVCD.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.guna2ButtonDVDVCD.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonDVDVCD.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonDVDVCD.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonDVDVCD.Image")));
            this.guna2ButtonDVDVCD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonDVDVCD.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ButtonDVDVCD.Location = new System.Drawing.Point(0, 152);
            this.guna2ButtonDVDVCD.Name = "guna2ButtonDVDVCD";
            this.guna2ButtonDVDVCD.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.guna2ButtonDVDVCD.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.guna2ButtonDVDVCD.ShadowDecoration.Color = System.Drawing.Color.White;
            this.guna2ButtonDVDVCD.Size = new System.Drawing.Size(215, 39);
            this.guna2ButtonDVDVCD.TabIndex = 0;
            this.guna2ButtonDVDVCD.Text = "Video";
            this.guna2ButtonDVDVCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonDVDVCD.Click += new System.EventHandler(this.Form_Click);
            // 
            // G2BtnDashboard
            // 
            this.G2BtnDashboard.BorderColor = System.Drawing.Color.White;
            this.G2BtnDashboard.BorderThickness = 1;
            this.G2BtnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2BtnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2BtnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2BtnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.G2BtnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.G2BtnDashboard.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2BtnDashboard.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F);
            this.G2BtnDashboard.ForeColor = System.Drawing.Color.White;
            this.G2BtnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("G2BtnDashboard.Image")));
            this.G2BtnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.G2BtnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.G2BtnDashboard.Location = new System.Drawing.Point(0, 113);
            this.G2BtnDashboard.Name = "G2BtnDashboard";
            this.G2BtnDashboard.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.G2BtnDashboard.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.G2BtnDashboard.Size = new System.Drawing.Size(215, 39);
            this.G2BtnDashboard.TabIndex = 7;
            this.G2BtnDashboard.Text = "Dashboard";
            this.G2BtnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.G2BtnDashboard.Click += new System.EventHandler(this.Form_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.guna2Panel3.Controls.Add(this.rjCircularPictureBox1);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(215, 113);
            this.guna2Panel3.TabIndex = 6;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox1.Image")));
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(18, -27);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(182, 182);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 0;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // TransTimer
            // 
            // 
            // panelDashboard
            // 
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(215, 113);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1135, 568);
            this.panelDashboard.TabIndex = 0;
            // 
            // guna2ButtonTransactions
            // 
            this.guna2ButtonTransactions.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ButtonTransactions.BorderThickness = 1;
            this.guna2ButtonTransactions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonTransactions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonTransactions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonTransactions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ButtonTransactions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.guna2ButtonTransactions.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonTransactions.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonTransactions.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonTransactions.Image")));
            this.guna2ButtonTransactions.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonTransactions.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ButtonTransactions.Location = new System.Drawing.Point(0, 230);
            this.guna2ButtonTransactions.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ButtonTransactions.Name = "guna2ButtonTransactions";
            this.guna2ButtonTransactions.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.guna2ButtonTransactions.Size = new System.Drawing.Size(215, 39);
            this.guna2ButtonTransactions.TabIndex = 2;
            this.guna2ButtonTransactions.Text = "Transactions";
            this.guna2ButtonTransactions.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonTransactions.Click += new System.EventHandler(this.Form_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 681);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bogsy Video Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxDashboard)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonCustomer;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDVDVCD;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonPayments;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonReports;
        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private Guna.UI2.WinForms.Guna2Button Itemledger;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox PctrBxDashboard;
        private Guna.UI2.WinForms.Guna2Button G2BtnDashboard;
        private System.Windows.Forms.Timer TransTimer;
        private System.Windows.Forms.Panel panelDashboard;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonTransactions;
    }
}