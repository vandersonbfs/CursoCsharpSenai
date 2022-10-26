using System;
using System.Collections.Generic;
using System.Text;

namespace IntroducaoHeranca
{
    class Pessoa
    {
        // Crie uma classe Pessoa com os atributo nome.
        // Crie as classes pessoa física com os atributos: rg , cpf, data nascimento, e
        // pessoa jurídica com os atributos:  inscrição estadual, cnpj, endereço;
        public string Nome { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public
            // Sobre carga
            public override string ToString()
        {
            return "Nome: " + Nome;
        }

    }
}
