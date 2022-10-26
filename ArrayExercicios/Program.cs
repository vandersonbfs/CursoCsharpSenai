using System;

namespace ArrayExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * 1) Crie um array com 10 posições e imprima os valores em ordem decrescente até o numero 0;
              2)Crie um array que receba numeros inteiros e mostre na tela quantos  numeros positivos e numeros negativos o array possui;
            

            int[] n = new int[10];
           
            for (int i = 9; i >= 0; i--)
            {
                n[i] = i;
                Console.WriteLine("numero: "+ n[i]);
                

            }
            */
            
            /*
            * 2)Crie um array que receba numeros inteiros e mostre na tela quantos  numeros positivos e numeros negativos o array possui;
            */

            int[] n = new int[10];
            int positivo = 0;
            int negativo = 0;


            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                n[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Você digitou o indice " + i + " de " + n.Length + " posições.");
                if (n[i] > 0)
                {
                    Console.WriteLine("Numero positivo");
                    positivo = positivo + 1;

                }
                else
                {
                    Console.WriteLine("é negativo");
                    negativo = negativo + 1;
                }

            }

            Console.WriteLine("Numeros positivo: " + positivo);
            Console.WriteLine("Numeros negativo: " + negativo);
            Console.WriteLine(" ");
            Console.WriteLine("Numero digitado: " + n[0]);
            Console.WriteLine("Numero digitado: " + n[1]);
            Console.WriteLine("Numero digitado: " + n[2]);
            Console.WriteLine("Numero digitado: " + n[3]);
            Console.WriteLine("Numero digitado: " + n[4]);
            Console.WriteLine("Numero digitado: " + n[5]);
            Console.WriteLine("Numero digitado: " + n[6]);
            Console.WriteLine("Numero digitado: " + n[7]);
            Console.WriteLine("Numero digitado: " + n[8]);
            Console.WriteLine("Numero digitado: " + n[9]);
        }
    }
}
