// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using System;
//using System.Globalization;

namespace DZ_Task_52
{
    class Program
    {
        static void Main(string[] args)

        {   
            int m = 2, n = 3;

            int[,] array = new int[m,n];
            int[] meanArray = new int[n]; // массив, в который запишем среднее по каждому столбцу

            FillArray (array);
            PrintArray (array);           
            FindMeanInColumns(array,meanArray);
            PrintMeanArray (meanArray);

        }

        static void FillArray (int[,] arr)

        {
            Random rdm = new Random();
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rdm.Next(-99,100);

                }


            } 

        }

        static void PrintArray (int[,] arr)

        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");

                }

            Console.WriteLine();
            } 

        }

        static void FindMeanInColumns (int[,] arr, int[] meanArr)

        {
            
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                int sum = 0; // сумма в текущем столбце

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    sum += arr[i, j];
                }
                meanArr[j] = sum / arr.GetLength(0);
            }
        }

        static void PrintMeanArray (int[] arr)

        {
            Console.WriteLine("Cреднее арифметическое элементов в каждом столбце:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i] + " ");
            } 

        }
    }


}

