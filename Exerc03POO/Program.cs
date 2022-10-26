using System;

namespace Exerc03POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar uma classe animal, que tem os atributos
            // nome, quantidade de patas, espécie (cachorro, gato...) e mostrar os atributos na classe principal;

            Animal bicho;
            bicho = new Animal();


            Console.WriteLine("Digite o nome do animal");
            bicho.Nome = Console.ReadLine();
            Console.WriteLine("Digite a espécie:");
            bicho.Especie = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de patas:");
            bicho.QuantPatas = double.Parse(Console.ReadLine());

            Console.WriteLine("Casdastro de Animais:");
            Console.WriteLine("Nome do animal....................:{0,15} ",bicho.Nome);
            Console.WriteLine("Quantidade de patas...............:{0,15} ",bicho.QuantPatas);
            Console.WriteLine("Espécie...........................:{0,15} ",bicho.Especie);




        }
    }
}
