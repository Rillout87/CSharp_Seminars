// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

using System;
class Program  
{
   static void Main()

    {
        Random rand = new Random ();

        int a_x = rand.Next (1, 10);
        int a_y = rand.Next (1, 10);
        int b_x = rand.Next (1, 10);
        int b_y = rand.Next (1, 10);

        Console.WriteLine("Точка А - " + a_x + ":" + a_y);
        Console.WriteLine("Точка В - " + b_x + ":" + b_y);

        double rasst = Math.Sqrt ((a_x - b_x)*(a_x - b_x) + (a_y - b_y)*(a_y - b_y));
        Console.WriteLine ("Длина отрезка " + rasst);

    
    
    }
    

}
