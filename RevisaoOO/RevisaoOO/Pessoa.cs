using System;
using System.Collections.Generic;
using System.Text;

namespace RevisaoOO
{
    class Pessoa
    {
        // Propriedade, o diferencia são os metodos GET e SET.
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }

        // Construtor que possibilita passar os dados posteriormente. pessoa1
        public Pessoa()
        {

        }


        // Construtor obrigando a passar os parametros: 
        public Pessoa(string nome, int idade, double altura) // Parametros que vao receber dados de entrada são com letra minuscula.
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }
        // O (this(nome, idade, altura)) indica que é para pegar os parametros do outro construtor.
        public Pessoa(string nome, int idade, double altura, string telefone) : this(nome, idade, altura)
        {
            telefone = telefone;
        }

        // Para uso com o construtor obrigando a passar os dados.
        public override string ToString()
        {
            return "Nome: " + Nome
                + "\nIdade: " + Idade
                + "\nAltura: " + Altura;
        }

    }

}
