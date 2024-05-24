using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int best = 0;
            int[] floor = new int[N];
            for (int i  = 0; i < N; ++i)
            {
                int S = int.Parse(Console.ReadLine());
                floor[i] = S;
            }
            int[] dp = new int[N];
            if (N == 1)
            {
                sb.AppendLine($"{floor[0]}");
                Console.Clear();
                Console.WriteLine(sb.ToString());
                return;
            }
            dp[0] = floor[0];
            dp[1] = floor[0] + floor[1];
            if (N == 2)
            {
                sb.AppendLine($"{dp[1]}");
                Console.Clear();
                Console.WriteLine(sb.ToString());
                return;
            }
            if (N >= 3)
            {
                dp[2] = floor[0] + floor[2];
                best = floor[1] + floor[2];
                if (dp[2] < best)
                {
                    dp[2] = best;
                }
            }
            for (int i = 3; i < N; ++i)
            {
                dp[i] = dp[i - 2] + floor[i];
                best = dp[i - 3] + floor[i - 1] + floor[i];
                if (dp[i] < best)
                {
                    dp[i] = best;
                }
            }
            sb.AppendLine($"{dp[N - 1]}");
            Console.Clear();
            Console.WriteLine(sb.ToString());
        }//Main
    }
}