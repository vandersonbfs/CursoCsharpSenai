using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeHeranca
{
    class PessoaJuridica : PessoaFisica
    {
        public int InscriçãoEstadual { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }

        public PessoaJuridica(int inscriçãoEstadual, string cnpj, string endereco, string nome,int rg, int cpf,string datadenascimento) : 
            base(nome, rg, cpf, datadenascimento)
        {
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
            DatadeNascimento = datadenascimento;
            InscriçãoEstadual = inscriçãoEstadual;
            Cnpj = cnpj;
            Endereco = endereco;
        }
    }
}
