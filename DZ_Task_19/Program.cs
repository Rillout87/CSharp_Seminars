// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using System;
class Program  
{
   static void Main()

    {
        void ChekPalindrome (string nmb)
        {
                        
            if ((nmb[0]==nmb[4]) && (nmb[1]==nmb[3]))
            Console.WriteLine ($"Число {nmb} - палиндром");
            else Console.WriteLine ($"Число {nmb} - не палиндром");
        }
        
        Console.WriteLine("Введите пятизначное число");
        string number = Console.ReadLine();
        
        while (number.Length != 5)
        {

            Console.WriteLine("Введите пятизначное число");
            number = Console.ReadLine();
        }
        ChekPalindrome(number);
    
    }
    

}