// Задача 3. Напишите рекурсивный метод, который принимает номер года и определяет,
// является ли он високосным или нет.



using System;


namespace DZ_Task_11_3
{
    class Program
    {
        static void Main(string[] args)

        {
            int year = 2000;

            if ((year % 4 == 0 && year % 100 != 0)) Console.WriteLine("Год високосный");
            else if (year % 400 == 0) Console.WriteLine("Год високосный");
            else Console.WriteLine("Год невисокосный");
        }
    }
}





