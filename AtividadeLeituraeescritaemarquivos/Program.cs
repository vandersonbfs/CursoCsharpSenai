using System;
using System.IO;
using System.Collections.Generic;



namespace AtividadeLeituraeescritaemarquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            faça um programa que receba um caminho onde tem um arquivo chamado produtos, 
            contendo vários produtos. cada produto tem nome, quantidade e preço. faça a 
            transferência desses dados do arquivo para um outro arquivo em uma subpasta da pasta produtos.
             */

            string fileName = "Produtos.txt";
            string sourcePath = @"C:\temp";
            string targetPath = @"C:\temp\Comprados";
            string newfileName = "ProdutosComprados.txt";

            string teste = @"C:\Windows";

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, newfileName);

            System.IO.Directory.CreateDirectory(targetPath);

            System.IO.File.Copy(sourceFile, destFile, true);


            Console.WriteLine("Copiando {0}, do diretorio {1}, para {2} ", fileName, sourcePath, targetPath);

            
            IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories(teste);

            foreach (var dir in listOfDirectories)
            {
                Console.WriteLine(dir);
            }

            // Listar arquivos em um diretório específico
           
            IEnumerable<string> files = Directory.EnumerateFiles(teste);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            
            Console.ReadLine();



        }

    }
}
