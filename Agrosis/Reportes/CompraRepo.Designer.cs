namespace Agrosis.Reportes
{
    partial class CompraRepo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompraRepo));
            this.Rpv1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // Rpv1
            // 
            this.Rpv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rpv1.LocalReport.ReportEmbeddedResource = "Agrosis.Reportes.CompraRepo.rdlc";
            this.Rpv1.Location = new System.Drawing.Point(0, 0);
            this.Rpv1.Name = "Rpv1";
            this.Rpv1.Size = new System.Drawing.Size(996, 446);
            this.Rpv1.TabIndex = 0;
            // 
            // CompraRepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 446);
            this.Controls.Add(this.Rpv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompraRepo";
            this.Text = "Reporte de compras";
            this.Load += new System.EventHandler(this.CompraRepo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Rpv1;
    }
}