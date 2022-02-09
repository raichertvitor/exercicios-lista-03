using System;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[15];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Digite a altura: ");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            
            double max = double.MinValue;
            double min = double.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i]) { max = array[i]; }
                if (min > array[i]) { min = array[i]; }
            }
            Console.WriteLine($"Maior altura é {max}, e a menor altura é {min}");
        }
    }
}
