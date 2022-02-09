using System;

namespace exercicio03
{
    internal class Program
    {
        //Exercício 3:
//• Desenvolver um algoritmo que efetue a soma de todos os números
//ímpares que são múltiplos de três e que se encontram no conjunto dos
//números de 1 até 500;
        static void Main(string[] args)
        {
            double soma = 0;
            for (double numeros = 1; numeros <= 500; numeros++) 
            {
                if (numeros % 3 == 0)
                {
                    soma = soma + numeros;
                }
            }
            Console.WriteLine($"A soma dos números é: {soma}");
        }
    }
}
