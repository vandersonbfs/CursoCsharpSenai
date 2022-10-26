using System;
using System.Collections.Generic;
using System.Text;
using Enums_12_05_2022.Entities.Enums;

namespace Enums_12_05_2022.Entities
{
    class Pedido
    {
        // Definiu as propriedades NumeroPedido, Item, Data, PedidoStatus.
        public int NumeroPedido { get; set; }
        public string Item { get; set; }
        public DateTime Data { get; set; }
        public EstadoPedido PedidoStatus { get; set; }
        // Construtor padrão
        public Pedido()
        {
        }
        // Construtor definindo obrigatorio data.
        public Pedido(DateTime data)
        {
            Data = data; // A propriedade Data, recebe a variavel data.
        }

        public Pedido(DateTime data, string item, int numeroPedido) : this(data) // Importando a variavel data do metodo anterior. (Herança)
        {
            Item = item;
            NumeroPedido = numeroPedido;
        }
        /*
        public int Calcular(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Calcular(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
        */

        public override string ToString()
        {
            return "Numero do pedido: " + NumeroPedido
                + " Item: " + Item
                + " Data: " + Data
                + " Estado pedido: " + PedidoStatus;
        }
    }
}