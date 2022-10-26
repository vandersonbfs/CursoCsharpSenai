using System;

namespace FuncoesEcex
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um programa que:
            - Leia o valor de um produto 
            - Uma função Aplique uma margem de lucro de 40% , e depois aplique mais 5 % de imposto e mostre para o usuário 
            o produto com preço final e o preço sem o imposto;
             */
            double z;
            Console.WriteLine("Entre com o valor de compra:");
            z = double.Parse(Console.ReadLine());

            metodo(z);
        }
        static void metodo(double z)
        {
            double lucro = 0.40;
            double produto = z;
            double imposto = 0.05;
            double tributo = 0.00;
            double total = 0.00;




            tributo = (produto * imposto);
            lucro = (produto * lucro);

            total = (tributo + produto + lucro);

            Console.WriteLine("Valor do produto: R$ " + produto);
            Console.WriteLine(" ");
            Console.WriteLine("Valor do imposto: R$ " + tributo);
            Console.WriteLine(" ");
            Console.WriteLine("Valor do lucro: R$ " + lucro);
            Console.WriteLine(" ");
            Console.WriteLine("Valor total: R$ " + total);
        }
    }
}
/*---------------------------------------------------------------------------------------------------------------------------------------*/
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
/*---------------------------------------------------------------------------------------------------------------------------------------*/
using System;

namespace ConverterTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Esse exercício nos já fizemos, mas agora vamos faze-lo com funções:
             - Faça uma função para receber uma temperatura em célsius e transformar em fahrenheit  e o contrario também (fahrenheit para célsius)
             */
            Console.WriteLine("Digite um temperatura: ");
            int a = int.Parse(Console.ReadLine());

            temp(a);
        }
        static void temp(double a)
        {
            Console.WriteLine("Temperatura digitada é: " + a);
            Console.WriteLine("Digite C para célsius ou F para fahrenheit: ");
            string b = Console.ReadLine();

            if (b == "c" || b == "C")
            {
                
                double f = ((a * 1.8) + 32);
                Console.WriteLine("A temperatura em Celsius " + a + " convertida em Fahrenheit é " + f);
            }
            else
            {
                
                double c = 5 * ((a - 32) / 9);
                Console.WriteLine("A temperatura em Fahrenheit " + a + " convertida para Celsius é " + c);
            }

        }
    }
}
