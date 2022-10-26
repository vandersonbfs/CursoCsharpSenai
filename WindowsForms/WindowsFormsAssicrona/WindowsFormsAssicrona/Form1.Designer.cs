using System;

namespace WindowsFormsAssicrona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.resposta = new System.Windows.Forms.NumericUpDown();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resposta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Nunito", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(41, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(695, 134);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = resources.GetString("lblTitulo.Text");
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(197, 231);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(61, 24);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "Num1";
            this.lblNum1.Click += new System.EventHandler(this.lblNum1_Click);
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.Location = new System.Drawing.Point(301, 233);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(17, 24);
            this.lblOperador.TabIndex = 2;
            this.lblOperador.Text = "*";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(364, 231);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(61, 24);
            this.lblNum2.TabIndex = 3;
            this.lblNum2.Text = "Num2";
            // 
            // resposta
            // 
            this.resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resposta.Location = new System.Drawing.Point(511, 231);
            this.resposta.Name = "resposta";
            this.resposta.Size = new System.Drawing.Size(120, 29);
            this.resposta.TabIndex = 5;
            // 
            // lbldisplay
            // 
            this.lbldisplay.AutoSize = true;
            this.lbldisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplay.Location = new System.Drawing.Point(179, 302);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(70, 24);
            this.lbldisplay.TabIndex = 1;
            this.lbldisplay.Text = "Display";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(610, 373);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(126, 45);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.resposta);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Atividade Aula Assicrona 10/06/2022";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resposta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.NumericUpDown resposta;

        Random random = new Random();
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Button btnVerificar;

        public int mult1;
        public int mult2;
        

        public void inicio()
        {
            mult1 = random.Next(1, 10);
            mult2 = random.Next(1, 10);

            lblNum1.Text = mult1.ToString();
            lblNum2.Text = mult2.ToString();
            
        }
        


    }
}

