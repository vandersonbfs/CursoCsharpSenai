using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadedeBanco
{
    class Conta
    {
        public string Nome;
        public int Idade;
        public double Saldo;
        public int NumeroConta;

        public void Saque(double saque)
        {
            if(Saldo >= saque)
            {
                Saldo = Saldo - saque;
            }
            else
            {
                Console.WriteLine("Valor de saque não permitido, saldo insuficiente!");
            }
          
        }

        public void Deposito(double valor)
        {
            Saldo = Saldo + valor;
        }

    }
}
