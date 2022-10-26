using System;
using Enums_12_05_2022.Entities; // Importou a Biblioteca Entities
using Enums_12_05_2022.Entities.Enums; // Importou a Biblioteca Enums

namespace Enums_12_05_2022
{
    class Program
    {
        static void Main(string[] args)
        {

            Pedido pedido = new Pedido(DateTime.Now);

            Console.WriteLine("entre com numero do pedido: ");
            pedido.NumeroPedido = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o item: ");
            pedido.Item = Console.ReadLine();

            pedido.Data = DateTime.Now;

            Console.WriteLine("Entre com o estado do pedido: ");
            int opt = int.Parse(Console.ReadLine());
            pedido.PedidoStatus = (EstadoPedido)opt;

            Console.WriteLine(pedido);

        }
    }
}
