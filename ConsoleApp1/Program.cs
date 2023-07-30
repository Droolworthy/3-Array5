//В массиве чисел найдите самый длинный подмассив из одинаковых чисел.
//Дано 30 чисел. Вывести в консоль сам массив, число, которое само больше раз повторяется подряд и количество повторений.
//Дополнительный массив не надо создавать.
//Пример: { 5, 5, 9, 9, 9, 5, 5}
//число 9 повторяется большее число раз подряд..
using System;

namespace CS24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[30];
            Random random = new Random();
            int resetCounter = 0;
            int count = 0;
            int numberRepetitions = 0;
            int repeatNumber = 0;

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
                }
                else
                {
                    count = resetCounter;
                }
                if (numberRepetitions < count)
                {
                    numberRepetitions = count;
                    repeatNumber = array[i];
                }
            }

            Console.WriteLine($"Первое число которое повторяется чаще всего - {repeatNumber}.");
            Console.WriteLine($"Количество повторяющихся элементов - {numberRepetitions + 1}.");
        }
    }
}
