using System;

namespace CAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputA = { 1, 2, 3, 4, 5 };
            int[] inputB = { 15, 25, 35 };
            int[] inputC = { 8, 8 };

            Console.WriteLine(Output(inputA));
            Console.WriteLine(Output(inputB));
            Console.WriteLine(Output(inputC));
        }

        public static int Output(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                if ((item % 2) == 0)
                    sum++;
                if ((item % 2) != 0)
                    sum += 3;
                if (item == 8)
                    sum += 5;
            }
            return sum;
        }

    }
}
