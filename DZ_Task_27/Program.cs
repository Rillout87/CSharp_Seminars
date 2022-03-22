// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

using System;
//using System.Globalization;

namespace DZ_Task_27
{
    class Program
    {
        static void Main()

        {
            Console.WriteLine("Введите число");
            string number = Console.ReadLine();
            //string number = "6";

            SumNmb(number);

            void SumNmb (string nmb)
            {
                int count = 0;
                
                for (int i = 0; i < nmb.Length; i++)
                {
                    int dgt = int.Parse(number[i].ToString());
                    count += dgt;
                }
                Console.WriteLine(count);
            }

        }


    }


}



