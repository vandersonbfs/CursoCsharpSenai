using System;

namespace Exerc02POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar uma classe produto, que tem os atributos
            // nome, preço de custo e preço de venda, mostrar na classe principal os produtos e seus atributos;

            Produto produto;
            produto = new Produto();

            Console.WriteLine("Digite o nome do produto:");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preço de compra:");
            produto.PreçodeCusto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço para venda:");
            produto.PreçodeVenda = double.Parse(Console.ReadLine());

            Console.WriteLine("Produto cadastrado:");
            Console.WriteLine("Produto...........................{0,15} "+ produto.Nome);
            Console.WriteLine("Preço de compra...................{0,15} R$" + produto.PreçodeCusto);
            Console.WriteLine("Preço de venda....................{0,15} R$" + produto.PreçodeVenda);
            Console.ReadLine();


        }
    }
}
