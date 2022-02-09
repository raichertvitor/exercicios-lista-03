using System;

namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numeros = 0;
            double[] array = new double[200];
            for (numeros = 100; numeros < array.Length; numeros++)
            {
                if (numeros % 2 > 0)
                {
                    Console.WriteLine($"Os números ímpares são: {numeros}");
                }
            }
        }
    }
}
