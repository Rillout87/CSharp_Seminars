// Задача 62: Заполните спирально массив 4 на 4 числами от 1 до 16.

using System;
//using System.Globalization;

namespace DZ_Task_62
{
    class Program
    {
        static void Main(string[] args)

        {   
            int n = 4, m =4;
            int[,] array = new int[n,m];


            FillInSpiral (array);
            PrintArray (array);           
        }


        static void PrintArray (int[,] arr)

        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + "\t");

                }

            Console.WriteLine();
            } 

        }

          
        static void FillInSpiral (int[,] arr, int number = 1, int i = 0, int j = -1)
        {
            while (number <= arr.GetLength(0)*arr.GetLength(1))
            {
                while (j < arr.GetLength(1) - 1 && arr[i, j+1] == 0)
                {
                    
                    arr[i, j+1] = number;
                    j++;
                    number++;
                }
                
                while (i < arr.GetLength(0) - 1 && arr[i + 1, j] == 0)
                {
                    arr[i + 1, j] = number;
                    i++;
                    number++;
                }

                while (j > 0 && arr[i, j - 1] == 0)
                {
                    arr[i, j-1] = number;
                    j--;
                    number++;
                }

                while (arr[i - 1, j] == 0)
                {
                    arr[i - 1, j] = number;
                    i--;
                    number++;
                }


            }
        }
    
    }


}

