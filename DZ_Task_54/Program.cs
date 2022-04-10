// Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

using System;

namespace DZ_Task_54
{
    class Program
    {
        static void Main()
        {			 	     
            int m = 3, n = 5;
            int[,] myArray = new int[m,n];

            FillArray (myArray);
            Console.WriteLine("Исходный массив");
            PrintArray (myArray);

            SortRows (myArray);
            Console.WriteLine("Отсортированный массив");
            PrintArray (myArray);

        }


        static void FillArray (int[,] arr)

        {
            Random rdm = new Random();
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rdm.Next(0,100);

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
        
        static void SortRows (int[,] arr)
        {
            int[] RowArr = new int[arr.GetLength(1)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    RowArr[j] = arr[i, j];
                }

                RowArr = QuickSort(RowArr, 0, RowArr.Length - 1);

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = RowArr[j];
                }

            }

        }
        
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            QuickSort(array, minIndex, pivotIndex - 1);

            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex-1;

            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    pivot++;
                    if (pivot != i) Swap(ref array[pivot], ref array[i]);
                    
                }
            }

            pivot++;
            if (pivot != maxIndex) Swap(ref array[pivot], ref array[maxIndex]);

            return pivot;
        }

        static void Swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;

            leftItem = rightItem;

            rightItem = temp;
        }
    }
}
