using System;

namespace ExercicioDataeHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Exiba a hora e data atual do sistema;
            Faça um programa que peça a data de nascimento e faça o calculo da idade no ano atual;
            faça um programa que simule a entrada e a saída de um veiculo e gere um valor total a 
            ser pago pela permanência (valor cobrado por minuto: R$0,10);
             */
            
            DateTime agora = DateTime.Now;
            Console.WriteLine("Em brazlândia... {0}", agora);

            
          
            Console.WriteLine("Digite a sua data de nascimento:");
            DateTime nasc = DateTime.Parse(Console.ReadLine());

            int anos = ((agora - nasc).Days / 365 );
            Console.WriteLine("A sua idade atual é {0} anos.", anos);
           
            Console.WriteLine("Digite a hora de entrada");
            DateTime entrada = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite a hora de Saida");
            DateTime saida = DateTime.Parse(Console.ReadLine());

            double tempo = ((saida - entrada).Hours);

            double valorMinuto = 0.10;
            double valoraPagar = ((tempo * 60) * valorMinuto);


            Console.WriteLine("tempo total: {0}",tempo);
            Console.WriteLine("Valor a ser pago: {0}", valoraPagar);

        }
    }
}
