// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


using System;
class Program  
{
   static void Main()

    {
        int[] mass = new int [2];

        mass [0] = Convert.ToInt32(Console.ReadLine());
        mass [1] = Convert.ToInt32(Console.ReadLine());
        PointCheck(mass [0], mass [1]);

        void PointCheck (int x, int y)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка лежит в первой четверти");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка лежит во второй четверти");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка лежит в третьей четверти");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка лежит в четвертой четверти");
            }
            else Console.WriteLine("Неверно заданы x и/или y");
        }
    
    
    }
    

}
