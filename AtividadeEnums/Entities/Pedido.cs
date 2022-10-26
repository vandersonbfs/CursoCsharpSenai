using System;
using System.Collections.Generic;
using System.Text;
using AtividadeEnums.Entities.Enums;

namespace AtividadeEnums.Entities
{
    class Pedido
    {
        public int NumeroPedido { get; set; }
        public DateTime Data { get; set; }
        public EstadodoPedido PedidoStatus { get; set; }
        // produto, quantidade, valor, valorTotal.
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public double ValorTotal { get; set; }
       

        public Pedido()
        {
        }
        public Pedido(DateTime data)
        {
            Data = data; // A propriedade Data, recebe a variavel data.
        }

        public Pedido(int numeroPedido, string item, DateTime data, EstadodoPedido pedidoStatus, string produto, int quantidade, double valor, double valorTotal)
        {
            NumeroPedido = numeroPedido;
            Data = data;
            PedidoStatus = pedidoStatus;
            Produto = produto;
            Quantidade = quantidade;
            Valor = valor;
            ValorTotal = valorTotal;
        }

        public override string ToString()
        {
            return "\nNumero do pedido.......................: " + NumeroPedido
                + " \nData...................................: " + Data
                + " \nEstado do pedido.......................: " + PedidoStatus
                + " \nProduto................................: " + Produto
                + " \nQuantidade.............................: " + Quantidade
                + " \nValor unitario.........................: " + Valor
                + " \nTotal..................................: " + ValorTotal;
        }
    }
}
