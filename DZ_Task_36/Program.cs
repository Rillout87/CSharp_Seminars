// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

using System;
using System.Globalization;
//static System.Globalization.StringInfo;


namespace DZ_Task_36
{
    class Program
    {
        static void Main()

        {
            Random rnd = new Random();
            int [] array = new int [10];

            for (int i = 0; i < array.Length; i++) // заполняем массив
            {
                array[i] = rnd.Next(-99,100);
            }
        
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            
            void OddIndexNumbersAmount(int[] arr)
            {
                int result = 0;
                for (int i = 1; i < arr.Length; i = i + 2)
                {
                    result += arr[i];
                }
                
                Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {result}");

            }

            OddIndexNumbersAmount(array);
        
        }
    }
}
