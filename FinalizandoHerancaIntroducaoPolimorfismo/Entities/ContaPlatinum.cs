using System;
using System.Collections.Generic;
using System.Text;

namespace FinalizandoHerancaIntroducaoPolimorfismo.Entities
{
    class ContaPlatinum : Conta
    {
        public double EmprestimoLimite { get; set; }
        public ContaPlatinum()
        {
        }

        public ContaPlatinum(int numeroConta, string nome, double saldo, double emprestimoLimite) : base(numeroConta, nome, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }

        public void LimiteEmprestimo(double valor)
        {
            Saldo += EmprestimoLimite;
        }

        public override void Sacar(double valor)
        {
            base.Sacar(valor);
            Saldo -= 3.00;
        }
    }
}
