using System;
using System.Collections.Generic;
using System.Text;

namespace FinalizandoHerancaIntroducaoPolimorfismo.Entities
{
    class Conta
    {
        public int NumeroConta { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {

        }
        public Conta(int numeroConta, string nome, double saldo)
        {
            NumeroConta = numeroConta;
            Nome = nome;
            Saldo = saldo;
        }
        public virtual void Sacar(double valor)
        {
            Saldo -= valor + 2.00;
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public override string ToString()
        {
            return "Nome: " + Nome
                + "Numero conta: " + NumeroConta
                + "Saldo: " + Saldo;
        }
    }
}
