// Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

using System;
//using System.Globalization;

namespace DZ_Task_25
{
    class Program
    {
        static void Main()

        {
            Console.WriteLine("Введите А");
            int nmb = Convert.ToInt32(Console.ReadLine());

            int count = nmb;
            Console.WriteLine("Введите В");
            int degree = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < degree; i++)
            {
                
                count *= nmb;
            }
            Console.WriteLine(count);

        }


    }


}


