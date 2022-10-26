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