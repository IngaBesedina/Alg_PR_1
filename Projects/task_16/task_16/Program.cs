using System;

namespace task_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int F(int n)
            {
                if (n <= 2)
                    return 2;
                else
                    return F(n - 1) * F(n - 2);
            }

            Console.WriteLine(F(5));
        }
    }
}
