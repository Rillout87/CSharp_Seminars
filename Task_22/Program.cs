// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

using System;
class Program  
{
   static void Main()

    {
        Console.Write ("Введите число :");
        int number = Convert.ToInt32(Console.ReadLine());

        number = Math.Abs(number);

        for(int i = 1; i <= number; i++){
	    Console.WriteLine(Math.Pow(i, 2));
	    }
        
        
    
    }
    

}