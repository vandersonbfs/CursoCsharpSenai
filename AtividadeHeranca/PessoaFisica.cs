using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeHeranca
{
    class PessoaFisica : Pessoa
    {
        public int Rg { get; set; }
        public int Cpf { get; set; }
        public string DatadeNascimento { get; set; }

        public PessoaFisica(int rg, int cpf, string datadeNascimento, string nome) : base(nome)
        {
            Rg = rg;
            Cpf = cpf;
            DatadeNascimento = datadeNascimento;
        }
        
    }
}
