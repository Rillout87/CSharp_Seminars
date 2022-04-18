// 3. Дано натуральное число n > 1. Вывести все простые множители данного числа.


using System;


namespace DZ_Task_10_3
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = 12;
            //List<int> multipliers = new List<int>();

            FindSimpleMultiplier(n, new List<int>());
            
        }
        static void FindSimpleMultiplier(int n, List<int> multipliers)
        {
            
            for (int i = 2; i<=n/2; i++)
            {
                if (n%i == 0) multipliers.Add(i);
            }

            for (int i = 0; i < multipliers.Count; i++) Console.Write($"{multipliers[i]}, ");

        }



    }
}
