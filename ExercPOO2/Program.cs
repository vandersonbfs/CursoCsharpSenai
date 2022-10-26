using System;

namespace ExercPOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crie um programa bancário que receba o
            // nome, idade, numero da conta, saldo; Implemente os
            // métodos de saque e deposito e mostre os dados atualizados na tela;

            Banco conta;
            conta = new Banco();

            Console.WriteLine("Digite seu nome:");
            conta.Nome = Console.ReadLine();

            Console.WriteLine("Digite sua Idade:");
            conta.Idade = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero da conta:");
            conta.NumConta = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu Saldo:");
            conta.Saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor para Saque:");
            conta.Saque = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor para Deposito:");
            conta.Deposito = double.Parse(Console.ReadLine());

            double saldoant = conta.Saldo;

            if (conta.Saque > 0)
            {
                conta.Saldo = conta.Saldo - conta.Saque;
            }

            if (conta.Deposito > 0)
            {
                conta.Saldo = conta.Saldo + conta.Deposito;
            }


            if (conta.Saque > 0 & conta.Deposito > 0)
            {
                Console.WriteLine("------------- BANCO DE PEDROK -------------");
                Console.WriteLine("Operação Multiplas:                         ");
                Console.WriteLine("Cliente.....................................{0,15} ", conta.Nome);
                Console.WriteLine("Numero da Conta.............................{0,15}", conta.NumConta);
                Console.WriteLine("Saldo anterior..............................{0,15:c}", saldoant);
                Console.WriteLine("Valor Depositado............................{0,15:c}", conta.Deposito);
                Console.WriteLine("Valor Sacado................................{0,15:c}", conta.Saque);
                Console.WriteLine(" ");
                Console.WriteLine("Saldo atual.................................{0,15:c}", conta.Saldo);
                Console.WriteLine("A idade do cliente..........................{0,15}", conta.Idade);
                Console.ReadLine();
            }else if(conta.Saque > 0 & conta.Deposito <= 0)
            {
                Console.WriteLine("------------- BANCO DE PEDROK -------------");
                Console.WriteLine("Operação Saque:                            ");
                Console.WriteLine("Cliente.....................................{0,15} ", conta.Nome);
                Console.WriteLine("Numero da Conta.............................{0,15}", conta.NumConta);
                Console.WriteLine("Saldo anterior..............................{0,15:c}", saldoant);
                Console.WriteLine("Valor Sacado................................{0,15:c}", conta.Saque);
                Console.WriteLine(" ");
                Console.WriteLine("Saldo atual.................................{0,15:c}", conta.Saldo);
                Console.WriteLine("A idade do cliente..........................{0,15}", conta.Idade);
                Console.ReadLine();
            }else if (conta.Saque <= 0 & conta.Deposito > 0)
            {
                Console.WriteLine("------------- BANCO DE PEDROK -------------");
                Console.WriteLine("Operação Deposito:                         ");
                Console.WriteLine("Cliente.....................................{0,15} ", conta.Nome);
                Console.WriteLine("Numero da Conta.............................{0,15}", conta.NumConta);
                Console.WriteLine("Saldo anterior..............................{0,15:c}", saldoant);
                Console.WriteLine("Valor Depositado............................{0,15:c}", conta.Deposito);
                Console.WriteLine(" ");
                Console.WriteLine("Saldo atual.................................{0,15:c}", conta.Saldo);
                Console.WriteLine("A idade do cliente..........................{0,15}", conta.Idade);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("------------- BANCO DE PEDROK -------------");
                Console.WriteLine("Operação Saldo:                            ");
                Console.WriteLine("Cliente.....................................{0,15} ", conta.Nome);
                Console.WriteLine("Numero da Conta.............................{0,15}", conta.NumConta);
                Console.WriteLine("Saldo atual.................................{0,15:c}", conta.Saldo);
                Console.WriteLine("A idade do cliente..........................{0,15}", conta.Idade);
                Console.ReadLine();
            }

        }
    }
}
