// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
using System;
//using System.Globalization;

namespace Sem5_Task_Star_1
{
    class Program
    {
        static void Main(string[] args)

        {


            Console.WriteLine("Введите k1");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите k2");
            double k2 = Convert.ToDouble(Console.ReadLine());;
            Console.WriteLine("Введите b1");
            double b1 = Convert.ToDouble(Console.ReadLine());;
            Console.WriteLine("Введите b2");
            double b2 = Convert.ToDouble(Console.ReadLine());;


            if (b1 != b2)
            {

                double crossPointX = (b2 - b1) / (k1 - k2);
                double crossPointY = k1 * crossPointX + b1;

                Console.WriteLine(crossPointX + " , " + crossPointY);
            }
            else
            {
                Console.WriteLine("Прямые не пересекаются или полностью совпадают");
            }
        }


    }


}







