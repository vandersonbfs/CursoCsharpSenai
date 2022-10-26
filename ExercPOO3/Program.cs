using System;

namespace ExercPOO3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crie um programa para fazer o calculo entre 2 números e receber o tipo de operação
            // (soma, divisão...), Crie uma classe Calcular e os atributos numero1, numero2 e operador.
            // Crie os métodos que achar necessário. Lembre-se que nossa logica estará apenas na classe Calcular, ok!?

            Calcular calcular;
            calcular = new Calcular();
            double res = 0;


            Console.WriteLine("Digite primeiro numero:");
            calcular.n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            calcular.n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite:................................A, para SOMAR");
            Console.WriteLine("Digite:................................S, para SUBTRAIR");
            Console.WriteLine("Digite:................................M, para MULTIPLICAR");
            Console.WriteLine("Digite:................................D, para DIVIDIR");
            calcular.op = char.Parse(Console.ReadLine());

            if (calcular.op == 'A' || calcular.op == 'a')
            {
                res = calcular.n1 + calcular.n2;
                Console.WriteLine("A soma de {0} e {1} é igual a {2}", calcular.n1, calcular.n2, res);

            }
            else if (calcular.op == 'S' || calcular.op == 's')
            {
                res = calcular.n1 - calcular.n2;
                Console.WriteLine("A Subtração de {0} e {1} é igual a {2}", calcular.n1, calcular.n2, res);
            }
            else if (calcular.op == 'M' || calcular.op == 'm')
            {
                res = calcular.n1 * calcular.n2;
                Console.WriteLine("A Multiplicação de {0} e {1} é igual a {2}", calcular.n1, calcular.n2, res);
            }
            else
            {
                res = calcular.n1 / calcular.n2;
                Console.WriteLine("A Divisão entre {0} e {1} é igual a {2}", calcular.n1, calcular.n2, res);
            }

        }
    }
}