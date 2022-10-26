using System;

namespace RevisaoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Construtor obrigando a passar os parametros:
             * 
            // Primeira forma de enviar os dados:
            // Pessoa pessoa = new Pessoa("Vanderson", 44, 1.82);

            Console.WriteLine("Entre com o Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua altura:");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua idade:");
            int idade = int.Parse(Console.ReadLine());


            Pessoa pessoa = new Pessoa(nome, idade, altura);
            

            Console.WriteLine(pessoa);
            */

            // Segunda forma de se passar os dados usando o construtor padrão:

            Pessoa pessoa1 = new Pessoa();
            Console.WriteLine("Entre com o Nome: ");
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine("Digite sua altura:");
            pessoa1.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua idade:");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine(pessoa1);


        }
    }
}
