using System;
using System.Collections.Generic;

namespace ExercicioFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Crie uma classe Funcionário que contenha os atributos: 
         *  nome, idade, e-mail, departamento (TI, design, RH), salario. Mostre na classe principal uma lista com todos os trabalhadores, 
         *  quantos trabalhadores tem na empresa, e quantos trabalhadores em cada departamento;

            Você deve criar um construtor com todos os atributos;
            Para adicionar um novo funcionário na lista passe dentro do método add criando um novo funcionario 
            list.Add(new Funcionario(atributos...));
            Para fazer a conta de funcionários por departamentos utilize a expressão lambda 
            list.Exists(x => x.Departamentos == "departamento");
            Esse fica pra próxima aula:

            Crie uma classe Alunos e os atributos: nome, idade, curso. 
            Mostre os dados do aluno na classe principal, quantos alunos tem idade superior a 18 anos, 
            quantos alunos estão cadastrados em um mesmo curso;
         */
            Funcionarios funcionarios = new Funcionarios();
            Console.WriteLine("Digite o nome do funcionario: ");
            string nome = Console.ReadLine();
            //funcionarios.Nome(nome);
            Console.WriteLine("Digite a idade do funcionario:");
            int idade = int.Parse(Console.ReadLine());
            //funcionarios.Idade(idade);
            Console.WriteLine("Digite o email do funcionario: ");
            string email = Console.ReadLine();
            //funcionarios.Email(email);
            Console.WriteLine("Digite o departamento: ");
            departamento = Console.ReadLine();
            //funcionarios.Departamento(departamento);
            Console.WriteLine("Digite o salario:");
            int salario = int.Parse(Console.ReadLine());






            


            
        }
    }
}
