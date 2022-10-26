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
using System.Data.SqlClient;




namespace AtividadeAulaAssíncrona24_06_2022
{
    public partial class Form1 : Form
    {
        SqlConnection conecta = new SqlConnection(@"Data Source=DESKTOP-BMSST8S\SQLEXPRESS; Initial Catalog=AtividadeProduto; Integrated Security = true");
        SqlCommand comando;
        SqlCommand comandoProd;
        SqlDataAdapter adaptar;
        int ID = 0;
        public Form1()
        {
            InitializeComponent();
            ExibirDados();

        }
        private void ExibirDados()
        {
            try
            {
                conecta.Open(); //Abre a conexão com o Banco de dados.
                DataTable dt = new DataTable(); // Acessar a tabela.
                adaptar = new SqlDataAdapter("SELECT * FROM CLIENTES", conecta);
                adaptar.Fill(dt);
                VisualizarCadastrados.DataSource = dt;

            }
            catch (Exception exc)
            {
                MessageBox.Show("Erro: " + exc.Message);
            }
            finally
            {
                conecta.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {


                using (var ws = new WSCorreios.AtendeClienteClient())
                    try
                    {
                        var consulta = ws.consultaCEP(txtCep.Text.Trim());
                        txtEstado.Text = consulta.uf;
                        txtCidade.Text = consulta.cidade;
                        txtRua.Text = consulta.end;
                        txtBairro.Text = consulta.bairro;

                        var buscar = new Buscar
                        {
                            Rua = consulta.end,
                            Cidade = consulta.cidade,
                            Cep = consulta.cep,
                            Estado = consulta.uf,
                            Bairro = consulta.bairro
                        };
                        string arquivo = @"C:\temp\dados.json";
                        FileStream criarArquivo = File.Create(arquivo);
                        JsonSerializer.SerializeAsync(criarArquivo, buscar);
                        criarArquivo.Dispose();

                    }
                    catch (Exception exc)
                    {

                        MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                   
            }
            else
            {
                MessageBox.Show("Informe um CEP válido!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text) &&
                !string.IsNullOrWhiteSpace(txtCep.Text))
            {
                comando = new SqlCommand("INSERT INTO CLIENTES VALUES" +
                       "(@NOME, @TELEFONE, @EMAIL, @CEP, @ESTADO, @CIDADE, @BAIRRO, @RUA, @NUMERO)", conecta);
                conecta.Open();
                comando.Parameters.AddWithValue("@NOME", txtNome.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text.Trim());
                comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("@CEP", txtCep.Text.Trim());
                comando.Parameters.AddWithValue("@ESTADO", txtEstado.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("@CIDADE", txtCidade.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("@BAIRRO", txtBairro.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("@RUA", txtRua.Text.ToUpper().Trim());
                comando.Parameters.AddWithValue("@NUMERO", txtNumero.Text.ToUpper().Trim());

                comando.ExecuteNonQuery();

                comandoProd = new SqlCommand("INSERT INTO PRODUTOS VALUES" +
                       "(@PRODUTO, @QUANTIDADE, @PRECO)", conecta);

                comandoProd.Parameters.AddWithValue("@PRODUTO", txtProduto.Text);
                comandoProd.Parameters.AddWithValue("@QUANTIDADE", txtQuantidade);
                comandoProd.Parameters.AddWithValue("@PRECO", txtPreco.Text);


                comandoProd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");


            }
            else
            {
                MessageBox.Show("Os campos nome e email são obrigatorios!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text) &&
                !string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                try
                {
                    comando = new SqlCommand("UPDATE CLIENTES SET NOME=@NOME," +
                        "(TELEFONE=@TELEFONE, EMAIL=@EMAIL, ESTADO=@ESTADO, CIDADE=@CIDADE, BAIRRO=@BAIRRO, RUA=@RUA, NUMERO=@NUMERO, WHERE ID=@ID)", conecta);

                    conecta.Open();
                    comando.Parameters.AddWithValue("@ID", ID);
                    comando.Parameters.AddWithValue("@NOME", txtNome.Text.ToUpper().Trim());
                    comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text.Trim());
                    comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text.ToUpper().Trim());
                    comando.Parameters.AddWithValue("@CEP", txtCep.Text.Trim());
                    comando.Parameters.AddWithValue("@ESTADO", txtEstado.Text.ToUpper().Trim());
                    comando.Parameters.AddWithValue("@CIDADE", txtCidade.Text.ToUpper().Trim());
                    comando.Parameters.AddWithValue("@BAIRRO", txtBairro.Text.ToUpper().Trim());
                    comando.Parameters.AddWithValue("@RUA", txtRua.Text.ToUpper().Trim());
                    comando.Parameters.AddWithValue("@NUMERO", txtNumero.Text.ToUpper().Trim());
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro atualizado com sucesso!");

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Erro: " + exc.Message);
                }
                finally
                {
                    conecta.Close();
                    ExibirDados();
                }
            }
            else
            {
                MessageBox.Show("Os campos nome e email são obrigatorios!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir este registro?", "CLIENTE",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    comando = new SqlCommand("DELETE CLIENTE WHERE ID=@ID", conecta);
                    conecta.Open();
                    comando.Parameters.AddWithValue("@ID", ID);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro deletado com sucesso!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Erro: " + exc.Message);
                }
                finally
                {
                    conecta.Close();
                    ExibirDados();

                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para ser deletado!");
            }
        }

        private void VisualizarCadastrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = int.Parse(VisualizarCadastrados.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNome.Text = VisualizarCadastrados.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTelefone.Text = VisualizarCadastrados.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = VisualizarCadastrados.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCep.Text = VisualizarCadastrados.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtEstado.Text = VisualizarCadastrados.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCidade.Text = VisualizarCadastrados.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtBairro.Text = VisualizarCadastrados.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtRua.Text = VisualizarCadastrados.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtNumero.Text = VisualizarCadastrados.Rows[e.RowIndex].Cells[9].Value.ToString();


            }
            catch (Exception exc)
            {
                MessageBox.Show("Aqui burro, dá zero pra ele..." + exc.Message);
            }
        }
    }
}
