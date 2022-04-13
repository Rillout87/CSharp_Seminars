// Задача 66. Задайте значения M и N. Наишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.

using System;
//using System.Globalization;

namespace DZ_Task_64
{
    class Program
    {
        static void Main(string[] args)

        {
            int M = 3;
            int N = 7;
            Console.WriteLine(NaturalNumbersSum(M, N));
        }
        static int NaturalNumbersSum(int m, int n)
        {
            if (m > n) return 0;
            else return m += NaturalNumbersSum(++m, n);
            
        }




    }

}




