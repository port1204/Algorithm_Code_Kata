using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());
            sb.Append(DP(N));
            Console.Clear();
            Console.WriteLine(sb.ToString());
        }//main

        public static int DP(int N)
        {
            int[] dp = new int[N+1];
            dp[1] = 0;

            for (int i = 2; i <= N; ++i)
            {
                dp[i] = dp[i - 1] + 1;

                if (i % 2 == 0)
                {
                    dp[i] = Math.Min(dp[i], dp[i / 2] + 1);
                }

                if (i % 3 == 0)
                {
                    dp[i] = Math.Min(dp[i], dp[i / 3] + 1);
                }
            }

            return dp[N];
        }
    }
}