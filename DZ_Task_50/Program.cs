// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;
//using System.Globalization;

namespace DZ_Task_47
{
    class Program
    {
        static void Main(string[] args)

        {
            double[,] array = new double[5,4];
            FillArray (array);
            PrintArray (array);
            
            Console.WriteLine("Введите номер строки");
            int findingRow = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("Введите номер столбца");
            int findingColumn = Convert.ToInt32(Console.ReadLine()) - 1;
            
            FindElement(array, findingRow, findingColumn);

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

        static void FindElement (double[,] arr, int x, int y)

        {
            try

            {
                Console.Write($"Искомый элемент: "); Console.Write("{0,6:F2}", arr[x, y]);

            }
            catch
            {
                Console.WriteLine("Такого эдемента нет");

            }

        }


    }


}










