using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartQ();
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ChecarResposta())
            {
                timer1.Stop();
                MessageBox.Show("Você conseguiu, esta tudo certo!," + "Parabens!");
                button1.Enabled = true;
            }else if(tempoRestante > 0)
            {
                tempoRestante = tempoRestante - 1;
                lblContTempo.Text = tempoRestante + "segundois";

            }
            else
            {
                timer1.Stop();
                lblContTempo.Text = "Seu tempo acabou!";
                MessageBox.Show("Você não conseguiu a tempo!", " Desculpre");
                resSoma.Value = somar1 + somar2;
                resSub.Value = sub1 - sub2;
                resMult.Value = mult1 * mult2;

                resDiv.Value = div1 / div2;
                button1.Enabled = true;

            }
        }
    }
}
