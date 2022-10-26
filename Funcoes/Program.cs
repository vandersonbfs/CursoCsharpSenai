using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça um programa, com uma função que necessite de um argumento. A função
            retorna o valor de caractere ‘P’, se seu argumento for positivo, e ‘N’, se seu
            argumento for zero ou negativo.
             */

            double z;
            Console.WriteLine("Entre com o valor de compra:");
            z = double.Parse(Console.ReadLine());

            metodo(z);
        }
       static void metodo(double z)
        {

           
            double tributo = 0.60;
            double icms = 0.17;
            double despacho = 15.00;
            double total = 0.00;
            double dolar = 4.94;
            double imposto = 0.2818181818181818;



            double produto = z;
            tributo = (produto * tributo);
            icms = (produto * icms);
            total = tributo + icms + despacho;
            double convercao = produto / dolar;
            imposto = (imposto * produto);




            Console.WriteLine("Valor do produto: " + "R$" + produto);
            Console.WriteLine("Valor do produto em Dolar: " + "$" + convercao);
            Console.WriteLine(" ");
            Console.WriteLine("Valor do imposto: " + "R$" + imposto);
            Console.WriteLine(" ");
            Console.WriteLine("Valor com o tributo de 60%: " + "R$" + tributo);
            Console.WriteLine("Valor com o ICMS: " + "R$" + icms);
            Console.WriteLine(" ");
            Console.WriteLine("Valor com o total de impostos: " + "R$" + total);
           

        }
        
    }
}
