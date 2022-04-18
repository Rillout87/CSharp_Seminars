// 2. Дана монотонная последовательность, в которой каждое натуральное число n встречается ровно n раз:
// 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... Дано число m. Выведите первые m членов этой последовательности.

using System;


namespace DZ_Task_10_2
{
    class Program
    {
        static void Main(string[] args)

        {
            int m = 12;
            List<int> Sequence = new List<int>();

            PrintMonoSequence(m, Sequence);
            
        }
        static void PrintMonoSequence(int m, List<int> Seq, int currentNmb = 1)
        {

            if (Seq.Count < m)
            {
                for (int i = 0; i < currentNmb; i++)
                {
                    Seq.Add(currentNmb);
                }

                PrintMonoSequence(m, Seq, ++currentNmb);
            }
            else
            {
                for (int i = 0; i < m; i++) Console.Write($"{Seq[i]}, ");
            }
        }



    }
}