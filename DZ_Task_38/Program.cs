// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

using System;
using System.Globalization;
//static System.Globalization.StringInfo;


namespace DZ_Task_38
{
    class Program
    {
        static void Main()

        {
            Random rnd = new Random();
            double [] array = new double [10];

            for (int i = 0; i < array.Length; i++) // заполняем массив
            {
                array[i] = rnd.NextDouble()*100;
            }
        
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0,6:F2}",array[i]);
            }

            Console.WriteLine();

            
            void DiffMaxMin(double[] arr)
            {
                
                double max = arr[0];
                double min = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max) max = arr[i];
                    if (arr[i] < min) min = arr[i];
                    
                }
                
                Console.Write($"Разница между максимальным и минимальным элементами массива: ");
                Console.Write("{0,6:F2}",max-min);

            }

            DiffMaxMin(array);
        
        }
    }
}

