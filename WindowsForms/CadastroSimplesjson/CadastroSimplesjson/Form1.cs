using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;


namespace CadastroSimplesjson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())

                try
                {
                        var consultar = ws.consultaCEP(txtCep.Text.Trim());
                        txtBairro.Text = consultar.bairro;
                        txtCidade.Text = consultar.cidade;
                        txtEndereco.Text = consultar.end;
                        txtUf.Text = consultar.uf;

                }
                catch (Exception ex)
                {
                        MessageBox.Show(ex.Message)
                }
            }
            else
            {
                MessageBox.Show("Digite um CEP válido!");
            }
        }
    }
}
