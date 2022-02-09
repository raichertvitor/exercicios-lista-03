using System;

namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        Exercício 4:
            //• Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e
            //calcule a tabuada de N.
            //• Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N =
            //10N.

            Console.Write("Digite um número de 1 a 10: ");
            double n = Convert.ToDouble(Console.ReadLine());

            if (n > 0 && n <= 10)
            {
                for (double multi = 0; multi <= 10; multi++)
                {
                    Console.WriteLine($"{n} * {multi} = {multi * n}");
                }
            }
        }
    }
}
