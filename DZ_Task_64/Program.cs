// Задача 64. Задайте значения M и N. Наишите программу, которая выведет все натуральные числа кратные 3-ем в промежутке от M до N.

using System;
//using System.Globalization;

namespace DZ_Task_64
{
    class Program
    {
        static void Main(string[] args)

        {
            int M = 3;
            int N = 22;
            PrintNumbers(M, N);
        }

        static void PrintNumbers(int m, int n)
        {
            if (m % 3 == 0) Console.WriteLine(m);

            if (m <= n) PrintNumbers(++m, n);
        }
    }



}





