// Задача 1. На вход подуются два числа n и m, такие, что n<m. Заполните массив случайными числами из промежутка [n, m].



using System;


namespace DZ_Task_11_1
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = 6;
            int m = 33;
            int[] array = new int[m - n];

            Random rand = new Random();
            int currentNmb;

            for (int i = 0; i < array.Length; i++)
            {
                currentNmb = rand.Next(n, m + 1);
                while (!array.Contains(currentNmb))
                {
                    array[i] = currentNmb;
                    Console.Write(currentNmb + " ");
                }
            }
        }
    }
}




