namespace Project.Forms.ExtensionForms
{
    partial class StepByStepRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StepByStepRent));
            this.Item = new Guna.UI2.WinForms.Guna2Button();
            this.G2BtnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.PnlStepByStep = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Item
            // 
            this.Item.BorderColor = System.Drawing.Color.Transparent;
            this.Item.BorderThickness = 1;
            this.Item.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Item.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Item.Dock = System.Windows.Forms.DockStyle.Left;
            this.Item.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.Item.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.Item.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F);
            this.Item.ForeColor = System.Drawing.Color.White;
            this.Item.Image = ((System.Drawing.Image)(resources.GetObject("Item.Image")));
            this.Item.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Item.ImageSize = new System.Drawing.Size(30, 30);
            this.Item.Location = new System.Drawing.Point(560, 0);
            this.Item.Name = "Item";
            this.Item.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.Item.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(162)))));
            this.Item.Size = new System.Drawing.Size(585, 55);
            this.Item.TabIndex = 18;
            this.Item.Text = "Item";
            this.Item.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // G2BtnCustomer
            // 
            this.G2BtnCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.G2BtnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.G2BtnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.G2BtnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.G2BtnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.G2BtnCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.G2BtnCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.G2BtnCustomer.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G2BtnCustomer.ForeColor = System.Drawing.Color.White;
            this.G2BtnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("G2BtnCustomer.Image")));
            this.G2BtnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.G2BtnCustomer.ImageSize = new System.Drawing.Size(30, 30);
            this.G2BtnCustomer.Location = new System.Drawing.Point(0, 0);
            this.G2BtnCustomer.Name = "G2BtnCustomer";
            this.G2BtnCustomer.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.G2BtnCustomer.PressedColor = System.Drawing.Color.Azure;
            this.G2BtnCustomer.Size = new System.Drawing.Size(560, 55);
            this.G2BtnCustomer.TabIndex = 12;
            this.G2BtnCustomer.Text = "Customer";
            this.G2BtnCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PnlStepByStep
            // 
            this.PnlStepByStep.Location = new System.Drawing.Point(0, 0);
            this.PnlStepByStep.Name = "PnlStepByStep";
            this.PnlStepByStep.Size = new System.Drawing.Size(1145, 510);
            this.PnlStepByStep.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Item);
            this.panel2.Controls.Add(this.G2BtnCustomer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 510);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1145, 55);
            this.panel2.TabIndex = 1;
            // 
            // StepByStepRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1145, 565);
            this.Controls.Add(this.PnlStepByStep);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StepByStepRent";
            this.Load += new System.EventHandler(this.StepByStepRent_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button G2BtnCustomer;
        private System.Windows.Forms.Panel PnlStepByStep;
        private Guna.UI2.WinForms.Guna2Button Item;
        private System.Windows.Forms.Panel panel2;
    }
}