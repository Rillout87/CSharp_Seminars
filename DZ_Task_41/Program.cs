// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

using System;
using System.Collections.Generic;
//using System.Globalization;

namespace DZ_Task_41
{
    class Program
    {
        static void Main(string[] args)

        {

            List<int> userArray = new List<int>();

            fillArray(userArray);
            PositiveNumbersCount(userArray);
            //PrintResult (PositiveNumbersCount);

        }
        static void fillArray(List<int> arr)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Введите число либо Enter, если завершили ввод");
                    arr.Add(Convert.ToInt32(Console.ReadLine()));
                }
            }
            catch { }

        }

        static void PositiveNumbersCount (List<int> ar, int j = 0, int quantity = 0)
        {

            if (j == ar.Count) PrintResult (quantity);
            
            if (j < ar.Count)
            {
                if (ar[j] > 0) quantity++;
                PositiveNumbersCount (ar, ++j, quantity);
            }

        }

        static void PrintResult (int cnt)
        {

            Console.WriteLine($"Количество чисел, введенных пользователем, больших 0 равно {cnt}");
        }


    }


}







