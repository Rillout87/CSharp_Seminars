// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using System;
//using System.Globalization;

namespace DZ_Task_47
{
    class Program
    {
        static void Main(string[] args)

        {
           
            int m = 5, n = 4;
            double[,] array = new double[m,n];
            FillArray (array);
            PrintArray (array);

        }

        static void FillArray (double[,] arr)

        {
            Random rdm = new Random();
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rdm.NextDouble()*100;

                }


            } 

        }

        static void PrintArray (double[,] arr)

        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,6:F2}",arr[i,j]);

                }

            Console.WriteLine();
            } 

        }



    }


}









