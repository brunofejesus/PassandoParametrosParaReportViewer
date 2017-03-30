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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            TelaDePreviewDeImpressao imprimirDados = new TelaDePreviewDeImpressao(txtNome.Text, txtEmail.Text);
            imprimirDados.Show();
        }
    }
}
