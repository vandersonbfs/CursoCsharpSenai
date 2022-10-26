using System;
using System.IO;

namespace TrabalharComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string arquivoOrigem = @"c:\temp\novo.txt";
            string arquivoDestino = @"c:\temp\novo1.txt";
            try
            {
                //FileInfo arquivoOrg = new FileInfo(arquivoOrigem);
                //arquivoOrg.CopyTo(arquivoDestino);
                string[] arquivoLido = File.ReadAllLines(arquivoOrigem);
                
                foreach(string leitura in arquivoLido)
                {
                    Console.WriteLine(leitura);
                }
            }catch(IOException e)
            {
                Console.WriteLine("Um erro ocorreu! " + e.Message);
            }
            
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(arquivoOrigem, FileMode.Open);
                sr = new StreamReader(fs);
                while (!sr.EndOfStream)//enquanto não chegar ao fim, ele entra no loop
                {
                    string linha = sr.ReadLine();//lê o arquivo (cada linha) e armazena na variavel
                    Console.WriteLine(linha);//imprime cada linha do stream reader
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }*/

            /*string arquivoOrigem = @"c:\temp\novo.txt";
            string arquivoDestino = @"c:\temp\novo1.txt";
            try
            {
                using (FileStream fs = new FileStream(arquivoOrigem, FileMode.Open))
                {
                    using (StreamReader rs = new StreamReader(fs))
                    {
                        while (!rs.EndOfStream)
                        {
                            string linhas = rs.ReadLine();
                            Console.WriteLine(linhas);
                        }
                    }
                }
            }catch(IOException e)
            {
           Console.WriteLine("Deu erro: "); Console.WriteLine(e.Message);
            }*/

            string arquivoOrigem = @"c:\temp\novo.txt";
            string arquivoDestino = @"c:\temp\novo1.txt";

            try
            {
                string[] linhas = File.ReadAllLines(arquivoOrigem);//lê todas as linhas
                using (StreamWriter sw = File.AppendText(arquivoDestino))
                {//^recebe o arquivo de destino onde iremos escrever
                    foreach (string linha in linhas)//pega tudo que leu nas linhas do arquivo
                    {//e imprime linha por linha contida no array
                        sw.WriteLine(linha.ToUpper());//escreve no arquivo em caixa alta
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}