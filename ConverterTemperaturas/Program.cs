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
