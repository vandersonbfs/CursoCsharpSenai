using System;

namespace CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que:
            - Leia a cotação do dólar
            - Leia um valor em dólares
            - Função que Converta esse valor para Real
            - Mostre o resultado
            */

            Console.WriteLine("Entre com a cotação do Dolar: ");
            double a = double.Parse(Console.ReadLine());
            

            funcao(a);

        }
        static void funcao(double a)
        {
            Console.WriteLine("Cotação do Dolar: $ " + a);
            Console.WriteLine("Entre com o valor em Dolares: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor em Dolares: $ " + b);
            double convercao = (a * b);
            Console.WriteLine("Valor convertido em Reais: R$ " + convercao);

        }
    }
}
