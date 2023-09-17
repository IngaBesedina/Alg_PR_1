using System;
namespace Alg_LR_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, min = 0;

            int[,] nums = new int[10, 10] 
            { 
                {34, 66, 69, 20, 81, 54, 51, 94, 90, 1}, {80, 83, 69, 78, 43, 41, 73, 9, 15, 66}, {15, 7, 22, 20, 6, 19, 89, 11, 17, 100}, 
                {40, 80, 76, 73, 71, 95, 60, 77, 68, 96}, {44, 85, 75, 49, 48, 37, 70, 53, 7, 73}, {7, 3, 80, 98, 50, 45, 15, 47, 48, 51}, 
                {9, 73, 44, 94, 75, 15, 21, 70, 8, 57}, {100, 30, 34, 58, 5, 96, 91, 32, 29, 63}, {45, 63, 8, 91, 37, 45, 64, 83, 9, 45}, 
                {42, 11, 88, 55, 50, 1, 82, 16, 8, 32}
            };

            int[,] rez = new int[10, 10];

            rez[0, 0] = 34;

            for (int i = 1; i < 10; i++)
            {
                rez[0, i] = rez[0, i - 1] + nums[0, i];
                rez[i, 0] = rez[i - 1, 0] + nums[i, 0];
            }

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    rez[i, j] = nums[i, j] + Math.Max(rez[i - 1, j], rez[i, j - 1]);
                }
            }

            max = rez[9, 9];

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    rez[i, j] = nums[i, j] + Math.Min(rez[i - 1, j], rez[i, j - 1]);
                }
            }

            min = rez[9, 9];

            Console.WriteLine($"{max} {min}");
        }
    }
}
