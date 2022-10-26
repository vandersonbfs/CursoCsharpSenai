using System;
using System.Collections.Generic;
using System.Text;
using DadosVeiculo.Entities;
using DadosVeiculo.Entities.Enums;


namespace DadosVeiculo.Entities
{
    class Carro
    {
        /*
            Faça uma classe carro que tenha os atributos: 
            cor, tipo do cambio, tipo de combustível, ano, modelo e marca; 
            Identifique o atributo que vai ser do tipo enum e insira os 
            respectivos valores desse tipo enum. 
            Mostre na classe principal os dados do veiculo.*/

        public string Cor { get; set; }
        public string Cambio { get; set; }
        public string Combustivel { get; set; }
        public string Ano { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public Carro()
        {

        }

        public Carro(string cor, string cambio, string combustivel, string ano, string modelo, string marca)
        {
            Cor = cor;
            Cambio = cambio;
            Combustivel = combustivel;
            Ano = ano;
            Modelo = modelo;
            Marca = marca;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
