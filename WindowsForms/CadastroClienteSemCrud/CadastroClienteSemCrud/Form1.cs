using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClienteSemCrud
{
    public partial class Form1 : Form
    {
        //Cliente cliente = new Cliente();
        List<Cliente> clientes;
        
        public Form1()
        {
            InitializeComponent();

            clientes = new List<Cliente>();

            estadoCivil.Items.Add("Casado");
            estadoCivil.Items.Add("Solterio");
            estadoCivil.Items.Add("Viuvo");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioM.Checked = true;

        }
        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (Cliente cliente in clientes)
            {
                if(Cliente.Nome == txtNome.text)
                {
                    index = clientes.IndexOf(cliente);       
                }           
            }
            if(txtNome.text == "")
            {
                MessageBox.Show("O campo Nome precisa ser preenchido!")
            }
            if(txtEndereco.Text == "")
            {
                MessageBox.Show("O campo Endereço precisa ser preenchido!")
            }
        }   if(txtTelefone.Text == "")
            {
                MessageBox.Show("O campo Telefone precisa ser preenchido!")
            }

            char sexo;

            if(radioM.Cheked)
            {
                sexo = 'M';
            }else if (radioF.Cheked)
            {
                sexo = 'F';       
            }
            else
            {
                sexo = 'O';
            }
            Cliente cl = new Cliente();
            cl.Nome = txtNome.Text;
            cl.DataNascimento = dateTimePicker1.Value;
            cl.txtTelefone.Text;
            radioM.Checked = true;
            radioF.Checked = false;
            radioO.Checked = false;
            txtNome.focus();
            


    }
}
