using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFuncionarios
{
    class Funcionarios
    {
        //publico inteiro Objeto {obter; atribuir; }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Email { get; set; }
        public string Departamento { get; set; }
        public int Salario { get; set; }
        // Construtor padrão
        public Funcionarios()
        {
        }
        // Construtor
        public Funcionarios(string nome, string idade, string email, string departamento, int salario)
        {
            Nome = nome;
            Idade = idade;
            Email = email;
            Departamento = departamento;
            Salario = salario;
        }
        public override string ToString()
        {
            return base.ToString("Nome"  + Nome; "Idade" + Idade; "Email" + Email; "Departamento" + Departamento; "Salario"+ Salario);
        }

    }

}
