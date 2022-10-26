using System;
using FinalizandoHerancaIntroducaoPolimorfismo.Entities;

namespace FinalizandoHerancaIntroducaoPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(1245, "Luan", 200.56);
            ContaPlatinum platinum1 = new ContaPlatinum(12456, "Jose", 1000.00, 500.00);
            ContaPoupanca cp = new ContaPoupanca(5412, "Rodrigo", 25000.00, 0.05);

            conta.Sacar(100.00);
            Console.WriteLine(conta.Saldo);

            cp.Sacar(24900.00);
            Console.WriteLine(cp.Saldo);

            platinum1.Sacar(100.00);
            Console.WriteLine(platinum1.Saldo);

            /*Conta cc1 = platinum1;
            Conta cc2 = new ContaPlatinum(6987, "Marcia", 15000.00, 2000.00);
            Conta cc3 = new ContaPoupanca(87452, "João", 100.00, 0.01);
            ContaPlatinum cc4 = (ContaPlatinum) cc2;
            cc4.LimiteEmprestimo(200.00);
            //ContaPlatinum cc5 = (ContaPlatinum) cc3;
            if(cc3 is ContaPlatinum)
            {
                ContaPlatinum cc5 = (ContaPlatinum)cc3;
                Console.WriteLine("Entrou no bloco da conta platinum");
            }
            if(cc3 is ContaPoupanca)
            {
                ContaPoupanca cc5 = (ContaPoupanca)cc3;
                Console.WriteLine("Entrou no bloco da conta poupança");
            }*/
        }
    }
}
