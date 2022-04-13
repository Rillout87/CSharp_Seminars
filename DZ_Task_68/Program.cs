// Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных чмсла m и n.


using System;
//using System.Globalization;

namespace DZ_Task_64
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = 3;
            int m = 2;
            Console.WriteLine(Akkerman(n, m));
        }
        static int Akkerman(int n, int m)
        {

            if (n == 0) return m + 1;
            else if (m == 0) return Akkerman(n - 1, 1);
            else return Akkerman(n - 1, Akkerman(n, m - 1));

        }
    }



}






