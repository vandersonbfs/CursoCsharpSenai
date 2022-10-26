using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeusAjuda
{
    public partial class RelatorioWF : Form
    {
        public RelatorioWF()
        {
            InitializeComponent();
        }

        private void RelatorioWF_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_relatorioDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.banco_relatorioDataSet.Produto);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("NomeEmpresa", "Conectiva"));
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FiltrarDados", txtPesquisa.Text));
            this.reportViewer1.RefreshReport();
        }

        private void btnMostrarTudo_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FiltrarDados", (string)null));
            this.reportViewer1.RefreshReport();
        }
    }
}
