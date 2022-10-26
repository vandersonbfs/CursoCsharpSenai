using System;
using System.Collections.Generic;
using System.Text;

namespace IntroducaoHeranca
{
    class PessoaJuridica : Pessoa
    {
      

        // Crie uma classe Pessoa com os atributo nome.
        // Crie as classes pessoa física com os atributos: rg , cpf, data nascimento, e
        // pessoa jurídica com os atributos:  inscrição estadual, cnpj, endereço;

        public int InscriçãoEstadual { get; set; }
        public int Cnpj { get; set; }
        public string Endereco { get; set; }
        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string nome, int inscriçãoEstadual, int cnpj, string endereco)
        {
            
            InscriçãoEstadual = inscriçãoEstadual;
            Cnpj = cnpj;
            Endereco = endereco;
        }
    }
}
