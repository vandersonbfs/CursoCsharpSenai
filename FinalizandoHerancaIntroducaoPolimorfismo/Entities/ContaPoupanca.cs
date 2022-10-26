using System;
using System.Collections.Generic;
using System.Text;

namespace FinalizandoHerancaIntroducaoPolimorfismo.Entities
{
    class ContaPoupanca : Conta
    {
        public double Rendimento { get; set; }
        public ContaPoupanca()
        {
        }

        public ContaPoupanca(int numeroConta, string nome, double saldo, double rendimento) : base(numeroConta, nome, saldo)
        {
            Rendimento = rendimento;
        }

        public void AtualizarSaldo()
        {
            Saldo = Saldo * Rendimento;
        }

        public override void Sacar(double valor)
        {
            Saldo -= valor;
        }
    }
}
