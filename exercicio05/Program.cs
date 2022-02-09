using System;

namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Exercício 5:
            //• Escreva um algoritmo que leia um valor inicial A e imprima a sequência de
            //valores do cálculo de A! e o seu resultado. 
            //Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120

            Console.Write("Digite um valor: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            double resultado = valor;

            for (double multi = valor - 1; multi > 0; multi--)
            {
                Console.WriteLine($"{resultado} * {multi} = {resultado = resultado * multi}");
            }
            Console.WriteLine($"{valor}! = {resultado}");
        }
    }
}
