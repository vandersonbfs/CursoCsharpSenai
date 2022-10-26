using System;
using AtividadeEnums.Entities;
using AtividadeEnums.Entities.Enums;

namespace AtividadeEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crie um programa para coletar os dados do pedido de uma pessoa e mostrar na tela os estados desse pedido
            // (pedidoRealizado, pedidoAceito, pedidoEmProducao, SaiuParaEntrega, Entregue) onde o usuário insere os estados desse pedido
            // e depois mostre na tela o pedido realizado e seu estado.
            // No programa principal deve ser solicitado apenas os dados:

            // produto, quantidade, valor, valorTotal.

            // mostrando ao final so o objeto. Implemente o enums na classe de produtos.
            // Crie os métodos que achar necessário, e os construtores que achar necessário.

            Pedido pedido = new Pedido(DateTime.Now);

            pedido.NumeroPedido = 3248;
            pedido.PedidoStatus = 0;

            Console.WriteLine("Digite o produto: ");
            pedido.Produto = Console.ReadLine();
            Console.WriteLine("Digite a quantidade: ");
            pedido.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto: ");
            pedido.Valor = double.Parse(Console.ReadLine());

            pedido.ValorTotal = pedido.Quantidade * pedido.Valor;
            Console.WriteLine(pedido);
        }
    }
}
