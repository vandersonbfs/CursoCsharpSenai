using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimeiroCrudComSql
{
    public partial class Form1 : Form
    {
        SqlConnection conecta = new SqlConnection(@"Data source=DESKTOP-BMSST8S\SQLEXPRESS; Initial Catalog=AgendaCrud; Integrated Security = true");
        SqlCommand comando;
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
                adaptar = new SqlDataAdapter("SELECT * FROM CADASTRO", conecta);
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtTelefone.Text = string.Empty;

            txtNome.Focus();

                       
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtNome.Text) &&
                !string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                try
                {
                    comando = new SqlCommand("INSERT INTO CADASTRO VALUES" +
                        "(@NOME, @TELEFONE, @EMAIL, @ENDERECO)", conecta);
                    conecta.Open();
                    comando.Parameters.AddWithValue("@NOME", txtNome.Text.ToUpper().Trim());
                    comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text.Trim());
                    comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text.ToUpper().Trim());
                    comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text.ToUpper().Trim());
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");

                }
                catch(Exception exc)
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text) &&
                !string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                try
                {
                    comando = new SqlCommand("UPDATE CADASTRO SET NOME=@NOME," +
                        "(TELEFONE=@TELEFONE, EMAIL=@EMAIL, ENDERECO=@ENDERECO WHERE ID=@ID)", conecta);
                    conecta.Open();
                    comando.Parameters.AddWithValue("@ID", ID);
                    comando.Parameters.AddWithValue("@NOME", txtNome.Text.ToUpper().Trim());
                    comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text.Trim());
                    comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text.ToUpper().Trim());
                    comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text.ToUpper().Trim());
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
            if(MessageBox.Show("Deseja excluir este registro?", "Agenda", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    comando = new SqlCommand("DELETE CADASTRO WHERE ID=@ID", conecta);
                    conecta.Open();
                    comando.Parameters.AddWithValue("@ID", ID);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro deletado com sucesso!");
                }
                catch(Exception exc)
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
                txtEndereco.Text = VisualizarCadastrados.Rows[e.RowIndex].Cells[4].Value.ToString();


            }
            catch(Exception exc)
            {
                MessageBox.Show("Aqui burro, dá zero pra ele..." + exc.Message);
            }
        }
    }
}
