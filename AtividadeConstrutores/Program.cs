using System;

namespace AtividadeConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crie um programa que pode receber no mínimo dois números (parâmetros)
            // para efetuar uma soma e no máximo 4 números, utilize os construtores para fazer esse exercício;

            Somar soma = new Somar();


            Console.WriteLine("Digite um numero: ");
            soma.Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero: ");
            soma.Num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Deseja adicionar mais numeros? S/N ");
            soma.Resp = char.Parse(Console.ReadLine());
            
            if(soma.Resp == 'S' || soma.Resp == 's')
            {
                Console.WriteLine("Digite outro numero: ");
                soma.Num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o ultimo numero: ");
                soma.Num4 = int.Parse(Console.ReadLine());
            }

            if(soma.Resp == 'S' || soma.Resp == 's')
            {
                Console.WriteLine("O total da soma de {0},{1},{2},{3}", soma.Num1, soma.Num2, soma.Num3,soma.Num4,soma.Total);
            }
            else
            {
                Console.WriteLine("O total da soma de {0} e {1} é igual a {2}", soma.Num1, soma.Num2,soma.Total);
            }
                

        }
    }
}
