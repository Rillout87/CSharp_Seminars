// 1. Дано число n. Получите число, записанное в обратном порядке.

using System;


namespace DZ_Task_10_1
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = 345;
            

            ReverseNumber(n);
            
        }
        static void ReverseNumber(int nmb, int revNmb = 0)
        {
            if (nmb == 0) Console.WriteLine(revNmb);
            else
            {
            revNmb = revNmb*10 + nmb%10;
            ReverseNumber(nmb/=10, revNmb);
            }            
            
        }
    }



}
