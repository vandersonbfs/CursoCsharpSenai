using System;
using System.Collections.Generic;
using System.Text;
using AtividadeImovel.Entities;

namespace AtividadeImovel.Entities
{
    class ImovelNovo : Imovel
    {
        /*
           Uma classe 
           ImovelNovo que herda os atributos de Imóvel, e tem um adicional 
           de valor por ser um imóvel novo.
            */
        public double ImovelNov { get; set; }

        public ImovelNovo(double imovelNov)
        {
            ImovelNov = imovelNov;
        }

        public ImovelNovo(double valor, double preco, double metroQuadrado, double metragemdoImovel) : base(valor, preco, metroQuadrado, metragemdoImovel)
        {
        }
        public void Acrecimo(double acrecimo)
        {
            acrecimo = Valor * 0.15;
            acrecimo += Valor;
        }
    }
    
}
