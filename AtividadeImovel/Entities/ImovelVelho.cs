using System;
using System.Collections.Generic;
using System.Text;
using AtividadeImovel.Entities;

namespace AtividadeImovel.Entities
{

    class ImovelVelho : Imovel
    {
        /*
        uma classe ImovelVelho, 
        que herda os membros de Imóvel e possui a opção de desconto, 
        por se tratar de um imóvel com mais tempo de habitação. 
        Peça na classe principal os valores e endereços, 
        e mostre o valor de venda de cada casa.
         */
        public ImovelVelho()
        {
        }

        public ImovelVelho(double valor, double preco, double metroQuadrado, double metragemdoImovel, double imovelvelho) : base(valor, preco, metroQuadrado, metragemdoImovel)
        {
            ImovelVelho = imovelvelho;
        }
        public void Desconto(double desc)
        {
            desc = Valor * 0.15;
            desc -= Valor;
        }
    }
    
}
