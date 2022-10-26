using System;

namespace primeiroForm
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resSoma = new System.Windows.Forms.NumericUpDown();
            this.lblContTempo = new System.Windows.Forms.Label();
            this.lblSomarEsquerda = new System.Windows.Forms.Label();
            this.lblSomar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.lblMultEsq = new System.Windows.Forms.Label();
            this.lblMuilt = new System.Windows.Forms.Label();
            this.lblMultDir = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSubEsq = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblSubDir = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDivEsq = new System.Windows.Forms.Label();
            this.lblDiv = new System.Windows.Forms.Label();
            this.lblDivDir = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.resMult = new System.Windows.Forms.NumericUpDown();
            this.resSub = new System.Windows.Forms.NumericUpDown();
            this.resDiv = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.resSoma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resDiv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(99, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(163, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Tempo restante";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(242, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar teste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resSoma
            // 
            this.resSoma.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSoma.Location = new System.Drawing.Point(325, 92);
            this.resSoma.Name = "resSoma";
            this.resSoma.Size = new System.Drawing.Size(81, 29);
            this.resSoma.TabIndex = 2;
            // 
            // lblContTempo
            // 
            this.lblContTempo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblContTempo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContTempo.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContTempo.Location = new System.Drawing.Point(316, 41);
            this.lblContTempo.Name = "lblContTempo";
            this.lblContTempo.Size = new System.Drawing.Size(90, 30);
            this.lblContTempo.TabIndex = 0;
            this.lblContTempo.Text = "Tempo";
            this.lblContTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSomarEsquerda
            // 
            this.lblSomarEsquerda.AutoSize = true;
            this.lblSomarEsquerda.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomarEsquerda.Location = new System.Drawing.Point(101, 92);
            this.lblSomarEsquerda.Name = "lblSomarEsquerda";
            this.lblSomarEsquerda.Size = new System.Drawing.Size(58, 22);
            this.lblSomarEsquerda.TabIndex = 0;
            this.lblSomarEsquerda.Text = "NUM1";
            // 
            // lblSomar
            // 
            this.lblSomar.AutoSize = true;
            this.lblSomar.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomar.Location = new System.Drawing.Point(170, 92);
            this.lblSomar.Name = "lblSomar";
            this.lblSomar.Size = new System.Drawing.Size(20, 22);
            this.lblSomar.TabIndex = 0;
            this.lblSomar.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "NUM2";
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgual.Location = new System.Drawing.Point(270, 92);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(20, 22);
            this.lblIgual.TabIndex = 0;
            this.lblIgual.Text = "=";
            // 
            // lblMultEsq
            // 
            this.lblMultEsq.AutoSize = true;
            this.lblMultEsq.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultEsq.Location = new System.Drawing.Point(101, 127);
            this.lblMultEsq.Name = "lblMultEsq";
            this.lblMultEsq.Size = new System.Drawing.Size(58, 22);
            this.lblMultEsq.TabIndex = 0;
            this.lblMultEsq.Text = "NUM1";
            // 
            // lblMuilt
            // 
            this.lblMuilt.AutoSize = true;
            this.lblMuilt.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuilt.Location = new System.Drawing.Point(170, 127);
            this.lblMuilt.Name = "lblMuilt";
            this.lblMuilt.Size = new System.Drawing.Size(17, 22);
            this.lblMuilt.TabIndex = 0;
            this.lblMuilt.Text = "*";
            // 
            // lblMultDir
            // 
            this.lblMultDir.AutoSize = true;
            this.lblMultDir.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultDir.Location = new System.Drawing.Point(196, 127);
            this.lblMultDir.Name = "lblMultDir";
            this.lblMultDir.Size = new System.Drawing.Size(58, 22);
            this.lblMultDir.TabIndex = 0;
            this.lblMultDir.Text = "NUM2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "=";
            // 
            // lblSubEsq
            // 
            this.lblSubEsq.AutoSize = true;
            this.lblSubEsq.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubEsq.Location = new System.Drawing.Point(101, 162);
            this.lblSubEsq.Name = "lblSubEsq";
            this.lblSubEsq.Size = new System.Drawing.Size(58, 22);
            this.lblSubEsq.TabIndex = 0;
            this.lblSubEsq.Text = "NUM1";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.Location = new System.Drawing.Point(170, 162);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(17, 22);
            this.lblSub.TabIndex = 0;
            this.lblSub.Text = "-";
            // 
            // lblSubDir
            // 
            this.lblSubDir.AutoSize = true;
            this.lblSubDir.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubDir.Location = new System.Drawing.Point(196, 162);
            this.lblSubDir.Name = "lblSubDir";
            this.lblSubDir.Size = new System.Drawing.Size(58, 22);
            this.lblSubDir.TabIndex = 0;
            this.lblSubDir.Text = "NUM2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(270, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "=";
            // 
            // lblDivEsq
            // 
            this.lblDivEsq.AutoSize = true;
            this.lblDivEsq.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivEsq.Location = new System.Drawing.Point(101, 197);
            this.lblDivEsq.Name = "lblDivEsq";
            this.lblDivEsq.Size = new System.Drawing.Size(58, 22);
            this.lblDivEsq.TabIndex = 0;
            this.lblDivEsq.Text = "NUM1";
            // 
            // lblDiv
            // 
            this.lblDiv.AutoSize = true;
            this.lblDiv.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiv.Location = new System.Drawing.Point(170, 197);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(15, 22);
            this.lblDiv.TabIndex = 0;
            this.lblDiv.Text = "/";
            // 
            // lblDivDir
            // 
            this.lblDivDir.AutoSize = true;
            this.lblDivDir.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivDir.Location = new System.Drawing.Point(196, 197);
            this.lblDivDir.Name = "lblDivDir";
            this.lblDivDir.Size = new System.Drawing.Size(58, 22);
            this.lblDivDir.TabIndex = 0;
            this.lblDivDir.Text = "NUM2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(270, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "=";
            // 
            // resMult
            // 
            this.resMult.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resMult.Location = new System.Drawing.Point(325, 127);
            this.resMult.Name = "resMult";
            this.resMult.Size = new System.Drawing.Size(81, 29);
            this.resMult.TabIndex = 2;
            // 
            // resSub
            // 
            this.resSub.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSub.Location = new System.Drawing.Point(325, 162);
            this.resSub.Name = "resSub";
            this.resSub.Size = new System.Drawing.Size(81, 29);
            this.resSub.TabIndex = 2;
            // 
            // resDiv
            // 
            this.resDiv.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resDiv.Location = new System.Drawing.Point(325, 197);
            this.resDiv.Name = "resDiv";
            this.resDiv.Size = new System.Drawing.Size(81, 29);
            this.resDiv.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 334);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resDiv);
            this.Controls.Add(this.resSub);
            this.Controls.Add(this.resMult);
            this.Controls.Add(this.resSoma);
            this.Controls.Add(this.lblDivDir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSubDir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDiv);
            this.Controls.Add(this.lblMultDir);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.lblDivEsq);
            this.Controls.Add(this.lblMuilt);
            this.Controls.Add(this.lblSubEsq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMultEsq);
            this.Controls.Add(this.lblSomar);
            this.Controls.Add(this.lblSomarEsquerda);
            this.Controls.Add(this.lblContTempo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Meu Primeiro Formulario C#";
            ((System.ComponentModel.ISupportInitialize)(this.resSoma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resDiv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown resSoma;
        private System.Windows.Forms.Label lblContTempo;
        private System.Windows.Forms.Label lblSomarEsquerda;
        private System.Windows.Forms.Label lblSomar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Label lblMultEsq;
        private System.Windows.Forms.Label lblMuilt;
        private System.Windows.Forms.Label lblMultDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubEsq;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblSubDir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDivEsq;
        private System.Windows.Forms.Label lblDiv;
        private System.Windows.Forms.Label lblDivDir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown resMult;
        private System.Windows.Forms.NumericUpDown resSub;
        private System.Windows.Forms.NumericUpDown resDiv;

        // começando programar teste
        Random random = new Random(); //gerar numero randomico

        // Variaveis para cada label
        int somar1;
        int somar2;
        int mult1;
        int mult2;
        int div1;
        int div2;
        int sub1;
        int sub2;
        int tempoRestante;
        


        


        public void StartQ() 
        {
            somar1 = random.Next(1, 31);
            somar2 = random.Next(1, 31);

            lblSomarEsquerda.Text = somar1.ToString();
            label5.Text = somar2.ToString();
            resSoma.Value = 0;

            mult1 = random.Next(1, 31);
            mult2 = random.Next(1, 31);
            lblMultEsq.Text = mult1.ToString();
            lblMultDir.Text = mult2.ToString();
            resMult.Value = 0;

            div1 = random.Next(1, 31);
            div2 = random.Next(1, 31);
            lblDivEsq.Text = div1.ToString();
            lblDivDir.Text = div2.ToString();
            resDiv.Value = 0;

            sub1 = random.Next(1, 31);
            sub2 = random.Next(1, 31);
            lblSubEsq.Text = sub1.ToString();
            lblSubDir.Text = sub2.ToString();
            resSub.Value = 0;


            //propriedades de tempo
            tempoRestante = 30;
            lblContTempo.Text = " 30 segundos ";
            timer1.Start();
        }
        private bool ChecarResposta()
        {
            if ((somar1 + somar2 == resSoma.Value)
                && (sub1 - sub2 == resSub.Value)
                && (mult1 * mult2 == resMult.Value)
                && (div1 / div2 == resDiv.Value)
                )
                return true;
            else
                return false;                         
                               
        }
        private System.Windows.Forms.Timer timer1;
    }
}

