// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;

namespace DZ_Task_54
{
    class Program
    {
        static void Main()
        {			 	     
            int m = 3, n = 3;
            int[,] myArray = new int[m,n];

            FillArray (myArray);
            Console.WriteLine("Исходный массив");
            PrintArray (myArray);

            FindMinSumRow (myArray);

        }


        static void FillArray (int[,] arr)

        {
            Random rdm = new Random();
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rdm.Next(0,10);

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
        
        static void FindMinSumRow (int[,] arr)
        {
            int MinSumRow = int.MaxValue;
            int IndexMinSumRow = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int RowSum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    RowSum += arr[i, j];
                }

                if (RowSum < MinSumRow)
                {
                    MinSumRow = RowSum;
                    IndexMinSumRow = i;
                }
            }
            
            Console.WriteLine($"Cтрока с наименьшей суммой элементов - это строка номер {IndexMinSumRow + 1}:");
            
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[IndexMinSumRow, j] + " ");
            }

            

        }
        
    }
}
