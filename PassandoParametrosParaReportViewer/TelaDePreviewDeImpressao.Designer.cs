namespace PassandoParametrosParaReportViewer
{
    partial class TelaDePreviewDeImpressao
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
            this.containerReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // containerReportViewer
            // 
            this.containerReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerReportViewer.LocalReport.ReportEmbeddedResource = "PassandoParametrosParaReportViewer.Impressao.rdlc";
            this.containerReportViewer.Location = new System.Drawing.Point(0, 0);
            this.containerReportViewer.Name = "containerReportViewer";
            this.containerReportViewer.Size = new System.Drawing.Size(614, 463);
            this.containerReportViewer.TabIndex = 0;
            // 
            // TelaDePreviewDeImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 463);
            this.Controls.Add(this.containerReportViewer);
            this.Name = "TelaDePreviewDeImpressao";
            this.Text = "Tela De Preview De Impressao";
            this.Load += new System.EventHandler(this.TelaDePreviewDeImpressao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer containerReportViewer;
    }
}