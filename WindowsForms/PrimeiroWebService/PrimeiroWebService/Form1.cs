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


namespace PrimeiroWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                    try
                    {
                        var consulta = ws.consultaCEP(txtCep.Text.Trim());
                        txtEstado.Text = consulta.uf;
                        txtRua.Text = consulta.end;
                        txtCidade.Text = consulta.cidade;
                        txtBairro.Text = consulta.bairro;

                        var teste = new Teste
                        {
                            Rua = consulta.end,
                            Cidade = consulta.cidade,
                            Cep = consulta.cep,
                            Estado = consulta.uf,
                            Bairro = consulta.bairro
                        };
                        /*string arquivo = @"C:\temp\teste.json";
                        FileStream criarArquivo = File.Create(arquivo);
                        JsonSerializer.SerializeAsync(criarArquivo, teste);
                        criarArquivo.Dispose();*/


                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCep.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtRua.Text = string.Empty;
            txtNome.Text = string.Empty;
            cbbSexo.Text = string.Empty;
            dtpDataNasc.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtNumero.Text = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cad = new Cadastro
            {
                Nome = txtNome.Text,
                Sexo = cbbSexo.Text,
                DataNasc = dtpDataNasc.Text,
                Telefone = txtTelefone.Text,
                Cep = txtCep.Text,
                Estado = txtEstado.Text,
                Cidade = txtCidade.Text,
                Bairro = txtBairro.Text,
                Rua = txtRua.Text,
                Numero = txtNumero.Text
            };
            string arquivo = @"C:\temp\cadastro.json";
            FileStream criarArquivo = File.Create(arquivo);
            JsonSerializer.SerializeAsync(criarArquivo, cad);
            criarArquivo.Dispose();
        }
    }
}
