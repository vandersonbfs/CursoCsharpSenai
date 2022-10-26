using System;

namespace IntroOrientacaoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1, carro2;
            carro1 = new Carro();
            carro2 = new Carro();

            Console.WriteLine("Digite a cor do veiculo:");
            carro1.Cor = Console.ReadLine();
            Console.WriteLine("Digite o preço do veiculo:");
            carro1.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o modelo do veiculo:");
            carro1.Modelo = Console.ReadLine();
            Console.WriteLine("Digite a marca do veiculo:");
            carro1.Marca = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Digite a cor do veiculo:");
            carro2.Cor = Console.ReadLine();
            Console.WriteLine("Digite o preço do veiculo:");
            carro2.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o modelo do veiculo:");
            carro2.Modelo = Console.ReadLine();
            Console.WriteLine("Digite a marca do veiculo:");
            carro2.Marca = Console.ReadLine();

            Console.WriteLine(carro1.Marca + " " + carro1.Modelo + " " + carro1.Cor + " " + carro1.Preco);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine(carro2.Marca + " " + carro2.Modelo + " " + carro2.Cor + " " + carro2.Preco);


        }
    }
}
