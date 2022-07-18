using System;

namespace CS24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[30];
            Random random = new Random();
            int maximumNumber = 1;
            int count = 1;
            int numberRepetitions = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    count++;
                    if (count > maximumNumber)
                    {
                        maximumNumber = count;
                        numberRepetitions = array[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }

            Console.WriteLine($"Число {numberRepetitions} повторяется большее число раз подряд");
        }
    }
}