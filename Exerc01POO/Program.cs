using System;

namespace Exerc01POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar uma classe Pessoa, que tem os atributos
            //nome, peso, altura e idade. Falar qual das pessoas é o mais velho, e qual é o mais pesado!

            Pessoa pessoa, pessoa2;
            pessoa = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Digite seu nome:");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu peso:");
            pessoa.Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu altura:");
            pessoa.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu idade:");
            pessoa.Idade = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu nome:");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu peso:");
            pessoa2.Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu altura:");
            pessoa2.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu idade:");
            pessoa2.Idade = double.Parse(Console.ReadLine());

            // Falar qual das pessoas é o mais velho, e qual é o mais pesado!

            if (pessoa.Idade > pessoa2.Idade)
            {
                Console.WriteLine("A pessoa que é mais velha é {0} ",pessoa.Nome);
            }else
            {
                Console.WriteLine("A pessoa que é mais velha é {0} ", pessoa2.Nome);
            }
            if (pessoa.Peso > pessoa2.Peso)
            {
                Console.WriteLine("A pessoa que é mais pesada é {0} ", pessoa.Nome);
            }
            else
            {
                Console.WriteLine("A pessoa que é mais pesada é {0} ", pessoa2.Nome);
            }



        }
    }
}
