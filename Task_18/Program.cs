// Задача 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

using System;
class Program  
{
   static void Main()

    {
        

        int znak_x = 0;
        int znak_y = 0;
        Console.WriteLine("Введите номер четверти");
        int QuaterNumber = Convert.ToInt32(Console.ReadLine());
        QuarterCheckRange (QuaterNumber);
        //PrintPoints (znak_x,  znak_y);

        Console.WriteLine(znak_X +","+ znak_Y);
        

        int QuarterCheckRange (int QuaterNmb)
        {
            
            int znak_X = 0;
            int znak_Y = 0;
            
            if ((QuaterNmb == 1) | (QuaterNmb == 4))
            {
                znak_X = 1;
            }
            else znak_X = -1;
            
            if ((QuaterNmb == 1) | (QuaterNmb == 2))
            {
                znak_Y = 1;
            }
            else znak_Y = -1;

            return znak_X + znak_Y;
            

        }
    
        void PrintPoints (int znakX, int znakY)
        {
            int i = 0;
            while (i < 10)
            {
                int pointX = new Random().Next(1, 100) * znakX;
                int pointY = new Random().Next(1, 100) * znakY;
                Console.WriteLine(pointX +","+ pointY);
                i++;
            }
        }


    }
    

}
