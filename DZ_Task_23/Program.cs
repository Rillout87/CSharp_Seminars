// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using System;
class Program  
{
   static void Main()

    {
        Console.Write ("Введите число :");
        int number = Convert.ToInt32(Console.ReadLine());

        number = Math.Abs(number);

        for(int i = 1; i <= number; i++)
        {
	    Console.Write(i + " -> ");
        Console.Write(Math.Pow(i, 3));
        Console.WriteLine();
	    } 
    
    }
    

}