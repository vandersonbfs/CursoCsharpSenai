using System;

namespace AtividadecomDatas
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Pegue a hora atual, converta para string (como se fosse salvar no banco de dados)
            e depois mostre novamente com o parse; 
            Faça um programa que receba um valor de um produto, pergunte em quantas 
            vezes a pessoa quer pagar e divida esse valor pelas parcelas a serem pagas, 
            entre com a data de inicio e informe quando será a ultima parcela */

            Console.WriteLine("Digite o produto: ");
            string produto = Console.ReadLine();
            Console.WriteLine("Digite o valor do {0}",produto);
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de parcelas qua vai dividir o valor {0}: ",valor);
            int quantidadedeParcelas = int.Parse(Console.ReadLine());

            DateTime dataCompra = new DateTime(2022, 05, 18);
            double mult = quantidadedeParcelas * 30;

            DateTime prazo = dataCompra.AddDays(mult);

            double valorParcela = valor / quantidadedeParcelas;

            Console.WriteLine("Produto................................: {0} ",produto);
            Console.WriteLine("Valor..................................: {0:c} ",valor);
            Console.WriteLine("Quantidade de parcela(s)...............: {0} ", quantidadedeParcelas);
            Console.WriteLine("Valor das parcela(s)...................: {0:c} ", valorParcela);
            Console.WriteLine("Data da compra.........................: {0} ", dataCompra);
            Console.WriteLine("Data da ultima parcela.................: {0} ", prazo);





        }
    }
}
