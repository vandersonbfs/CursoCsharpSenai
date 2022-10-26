using System;
using System.Collections.Generic;
using System.Text;

namespace IntroducaoHeranca
{
    class PessoaFisica :Pessoa
    {
      

        // Crie uma classe Pessoa com os atributo nome.
        // Crie as classes pessoa física com os atributos: rg , cpf, data nascimento, e
        // pessoa jurídica com os atributos:  inscrição estadual, cnpj, endereço;
        public int Rg { get; set; }
        public int Cpf { get; set; }
        public int DatadeNascimento { get; set; }

        public PessoaFisica()
        {
        }

        public PessoaFisica(string nome, int rg, int cpf, int datadeNascimento)
        {

            
            Rg = rg;
            Cpf = cpf;
            DatadeNascimento = datadeNascimento;
        }
    }
}
