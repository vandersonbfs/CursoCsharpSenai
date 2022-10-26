using System;

namespace AtividadedeBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            Console.WriteLine("Digite seu nome: ");
            conta.Nome = Console.ReadLine();
            Console.WriteLine("digite o numero da conta");
            conta.NumeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua idade: ");
            conta.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}, seu saldo atual é de {1:c}",conta.Nome, conta.Saldo);
            
            Console.WriteLine("Qual o valor que deseja depositar: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);

            Console.WriteLine("{0}, seu saldo atual é de {1:c}", conta.Nome, conta.Saldo);

            Console.WriteLine("Qual o valor que deseja sacar: ");
            double valor = double.Parse(Console.ReadLine());
            conta.Saque(valor);
            Console.WriteLine("{0}, seu saldo atual é de {1:c}", conta.Nome, conta.Saldo);
            Console.WriteLine(" ");
            Console.WriteLine("Conta.................................................{0} ",conta.NumeroConta);
            Console.WriteLine("Nome..................................................{0} ", conta.Nome);
            Console.WriteLine("Idade.................................................{0} ", conta.Idade);
            Console.WriteLine("Saldo.................................................{0:c} ", conta.Saldo);
           

        }
    }
}
