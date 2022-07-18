using System;

namespace CS24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 2, 13, 22, 27, 28, 29, 30 }; 
            int count = 1;
            int numberRepetitions = 0;
            int repeatNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    count++;
                }
                else if (count > numberRepetitions)
                {
                    numberRepetitions = count;
                    repeatNumber = array[i - 1];
                    count = 1;
                }
            }

            Console.WriteLine($"Число {repeatNumber} повторяется {numberRepetitions} раз подряд.");
        }
    }
}
