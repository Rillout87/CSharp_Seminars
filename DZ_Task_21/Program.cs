// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

using System;
class Program  
{
   static void Main()

    {
        int i, n = 3;
        int[] a = new int[n];
        int[] b = new int[n];
        
        Console.WriteLine("Введите координаты точки А через пробел");
        string[] strA = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries); // нашел этот способ где-то на форуме, он работает, но объснить не смогу))
        for (i = 0; i < (n < strA.Length ? n : strA.Length); ++i)
        a[i] = Convert.ToInt32(strA[i]);

        int a_x = a[0];
        int a_y = a[1];
        int a_z = a[2];

        Console.WriteLine("Введите координаты точки B через пробел");
        string[] strB = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        for (i = 0; i < (n < strB.Length ? n : strB.Length); ++i)
        b[i] = Convert.ToInt32(strB[i]);

        int b_x = b[0];
        int b_y = b[1];
        int b_z = b[2];

        Console.WriteLine("Точка А - " + a_x + ":" + a_y + ":" + a_z);
        Console.WriteLine("Точка В - " + b_x + ":" + b_y + ":" + b_z);

        double rasst = Math.Sqrt(Math.Pow((a_x - b_x),2) + Math.Pow((a_y - b_y),2) + Math.Pow((a_z - b_z),2));
        Console.WriteLine ("Длина отрезка " + rasst);
    
    }
    

}