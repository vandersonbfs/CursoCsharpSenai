using System;
using System.Collections.Generic;
using System.Text;
using AtividadeImovel.Entities;

namespace AtividadeImovel.Entities
{
    class Imovel
    {
        /*
            Crie uma classe Imóvel, que possui um valor e um preço, 
            um método preço venda calculando o valor do metro quadrado e 
            recebendo como parâmetro o valor do metro quadrado, e quantos 
            metros quadrados tem, atualizando o preço de venda.
             */

        public double Valor { get; set; }
        public double Preco { get; set; }
        public double MetroQuadrado { get; set; }
        public double MetragemdoImovel { get; set; }

        public Imovel()
        {
        }
        
        public Imovel(double valor, double preco, double metroQuadrado, double metragemdoImovel)
        {
            

            Valor = valor;
            Preco = preco;
            MetroQuadrado = metroQuadrado;
            MetragemdoImovel = metragemdoImovel;
            
           
        }
        public double PrecoVenda(double metro, double metragem, double preco)
        {
            
            preco = metro * metragem;
            return preco; 
        }
        
        public override string ToString()
        {
            return "Valor do imovel.....................: " + Valor
                + "\nValor do imovel.....................: " + ImovelNovo
                + "\nValor do imovel.....................: " + ImovelVelho
                + "\n Valor do imovel.....................: ";

        }
    }
}
