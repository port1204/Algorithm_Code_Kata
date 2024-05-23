using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int T = int.Parse(Console.ReadLine());
            int N = 0;
            int max = 0;
            int[] tc = new int[T];

            for (int i  = 0; i < T; ++i)
            {
                N = int.Parse(Console.ReadLine());
                tc[i] = N;
                if (max < N)
                {
                    max = N;
                }
            }

            int[] dp = new int[max + 1];
            dp[0] = 1;
            dp[1] = 1;
            dp[2] = 2;
            dp[3] = 4;
            for (int i = 4; i <= max; ++i)
            {
                dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];
            }

            for (int i = 0; i < T; ++i)
            {
                sb.AppendLine(dp[tc[i]].ToString());
            }

            Console.Clear();
            Console.WriteLine(sb.ToString());
        }//main
    }
}