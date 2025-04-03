namespace Project.Forms.ExtensionForms
{
    partial class PrintReceipt
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
            this.RptrViewerRent = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RptrViewerRent
            // 
            this.RptrViewerRent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RptrViewerRent.LocalReport.ReportEmbeddedResource = "Project.Forms.ReportRDLC.Receipt.rdlc";
            this.RptrViewerRent.Location = new System.Drawing.Point(0, 0);
            this.RptrViewerRent.Name = "RptrViewerRent";
            this.RptrViewerRent.ServerReport.BearerToken = null;
            this.RptrViewerRent.Size = new System.Drawing.Size(682, 450);
            this.RptrViewerRent.TabIndex = 0;
            this.RptrViewerRent.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // PrintReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.RptrViewerRent);
            this.Name = "PrintReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintReceipt";
            this.Load += new System.EventHandler(this.PrintReceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RptrViewerRent;
    }
}