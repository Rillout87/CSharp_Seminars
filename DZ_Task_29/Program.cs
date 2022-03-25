// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

using System;
//using System.Globalization;

namespace DZ_Task_27
{
    class Program
    {
        static void Main()

        {
            Random rnd = new Random();
            int[] arr = new int[8];
            int[] newArray = new int[8];
            int indexMin = 0;
            int temp = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-99, 100);
                Console.Write(arr[i] + " ");
            }

            for (int i = 0; i < arr.Length-1; i++)
            {
                int min = Math.Abs(arr[i]);
                indexMin = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    
                    if (Math.Abs(arr[j]) < min)
                    {
                        min = Math.Abs(arr[j]);
                        indexMin = j;
                    }
                }
                if (indexMin != i)
                {
                    temp = arr[i];
                    arr[i] = arr[indexMin];
                    arr[indexMin] = temp;
                }

            }

            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }


    }


}



