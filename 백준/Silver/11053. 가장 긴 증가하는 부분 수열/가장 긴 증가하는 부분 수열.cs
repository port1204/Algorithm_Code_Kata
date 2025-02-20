using System;

namespace LIS
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[] dp = new int[N];
            for (int i = 0; i < N; i++)
            {
                dp[i] = 1;
            }

            for (int i = 1; i < N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (A[i] > A[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }

            int lisLength = 0;
            for (int i = 0; i < N; i++)
            {
                lisLength = Math.Max(lisLength, dp[i]);
            }

            Console.WriteLine(lisLength);
        }
    }
}