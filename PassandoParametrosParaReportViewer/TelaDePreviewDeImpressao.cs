using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassandoParametrosParaReportViewer
{
    public partial class TelaDePreviewDeImpressao : Form
    {
        public TelaDePreviewDeImpressao(string Nome, string Email)
        {
            InitializeComponent();

            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[2];

            p[0] = new Microsoft.Reporting.WinForms.ReportParameter("Nome", Nome);
            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("Email", Email);

            containerReportViewer.LocalReport.SetParameters(p);
            containerReportViewer.LocalReport.Refresh();
            containerReportViewer.RefreshReport();
        }

        private void TelaDePreviewDeImpressao_Load(object sender, EventArgs e)
        {

            this.containerReportViewer.RefreshReport();
        }
    }
}
