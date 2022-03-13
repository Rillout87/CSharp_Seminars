// Задача 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

using System;
class Program  
{
   static void Main()

    {

        Console.WriteLine("Введите номер четверти");
        int QuaterNumber = Convert.ToInt32(Console.ReadLine());

        int znak_x = QuarterCheckX(QuaterNumber);
        int znak_y = QuarterCheckY(QuaterNumber);

        PrintPoints(znak_x, znak_y);


        int QuarterCheckX(int QuaterNmb) // функция, которая присваивает знак иксу
        {

            int znak_X = 0;

            if ((QuaterNmb == 1) | (QuaterNmb == 4))
            {
                znak_X = 1;
            }
            else znak_X = -1;
            return znak_X;
        }
        int QuarterCheckY(int QuaterNmb) // функция, которая присваивает знак игреку
        {
            int znak_Y = 0;

            if ((QuaterNmb == 1) | (QuaterNmb == 2))
            {
                znak_Y = 1;
            }
            else znak_Y = -1;

            return znak_Y;

        }
        // Возможно ли вместо функций QuarterCheckX и QuarterCheckY объединить их в одну вернуть через return две переменные сразу, например return znak_X, znak_Y? У меня никак не получилось разобраться.

        void PrintPoints(int znakX, int znakY)
        {
            int i = 0;
            while (i < 10)
            {
                int pointX = new Random().Next(1, 100) * QuarterCheckX(QuaterNumber); ;
                int pointY = new Random().Next(1, 100) * QuarterCheckY(QuaterNumber); ;
                Console.WriteLine(pointX + "," + pointY);
                i++;
            }
        }


    }


}
