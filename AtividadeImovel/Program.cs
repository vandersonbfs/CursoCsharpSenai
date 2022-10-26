using System;
using AtividadeImovel.Entities;

namespace AtividadeImovel
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            por se tratar de um imóvel com mais tempo de habitação. 
            Peça na classe principal os valores e endereços, 
            e mostre o valor de venda de cada casa.
             */
            Imovel imovel = new Imovel();
            Console.WriteLine("Digite o valor do imóvel: ");
            imovel.Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do metro quadrado");
            imovel.MetroQuadrado = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a metragem do imóvel: ");
            imovel.MetragemdoImovel = double.Parse(Console.ReadLine());

            Console.WriteLine(imovel);
           
        }
    }
}
