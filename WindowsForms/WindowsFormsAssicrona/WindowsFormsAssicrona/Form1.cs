using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAssicrona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inicio();
            lbldisplay.Text = "Vamos ver se você é bom em multiplicação.";
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            


            if (mult1 * mult2 == resposta.Value)
            {
                
                lbldisplay.ForeColor = Color.Green;
                lbldisplay.Text = "Acertou miseravi!";
                
                inicio();
                resposta.Value = 0;

            }
            else
            {
               
                lbldisplay.ForeColor = Color.Red;
                lbldisplay.Text = "Ai que burro dá zero pra ele! Hahahahahaha...";
                inicio();
                resposta.Value = 0;
                
            }
        }

        private void lblNum1_Click(object sender, EventArgs e)
        {

        }
    }
}
