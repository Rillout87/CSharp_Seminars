// Задача 2. Двумерный массив заполнен случайными натуральными числами от 1 до 10.
// Найдите количество элементов, значение которых больше 5, и их сумму.



using System;


namespace DZ_Task_11_2
{
    class Program
    {
        static void Main(string[] args)

        {
            int[,] array = new int[3, 3];
            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = rand.Next(1, 11);
            }
            }

            int count = 0;
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                    if (array[i,j] > 5)
                    {
                        count++;
                        sum += array[i,j];
                    }
                }
                Console.WriteLine();
            }
        Console.WriteLine($"Rоличество элементов, значение которых больше 5, равно {count} и их сумма {sum}.");
        }
    }
}





