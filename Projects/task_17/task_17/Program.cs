using System;

namespace task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0, maxSum = 0;

            Random rnd = new Random();
            int[] sequence = new int[10000];

            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = rnd.Next(1, 10000);
            }

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                for (int j = i + 1; j < sequence.Length; j++)
                {
                    if (((sequence[i] + sequence[j]) % 80 == 0) & (sequence[i] % 50 == 0 | sequence[j] % 50 == 0))
                    {
                        cnt += 1;
                        maxSum = Math.Max(maxSum, sequence[i] + sequence[j]);
                    }
                }
            }

            Console.WriteLine($"{cnt}, {maxSum}");
        }
    }
}
