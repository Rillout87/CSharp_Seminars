// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

using System;
using System.Globalization;
//static System.Globalization.StringInfo;


namespace DZ_Task_34
{
    class Program
    {
        static void Main()

        {
            Random rnd = new Random();
            int [] array = new int [20];

            for (int i = 0; i < array.Length; i++) // заполняем массив
            {
                array[i] = rnd.Next(100,1000);
            }
        
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            
            void EvenNumbersCount(int[] arr)
            {
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0) count++;
                }
                
                Console.WriteLine($"Четных чисел в массиве: {count}");

            }

            EvenNumbersCount(array);
        
        }
    }
}