using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int[] a = new int[N];
            for (int i = 0; i < N; ++i)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            if (N == 1)
            {
                sb.AppendLine($"{a[0]}");
                Console.WriteLine(sb);
                return;
            }

            int[] dp = new int[N];
            dp[0] = a[0];
            dp[1] = a[0] + a[1];
            if (N > 2)
            {
                dp[2] = Math.Max(dp[1], Math.Max(a[0] + a[2], a[1] + a[2]));
            }

            for (int i = 3; i < N; ++i)
            {
                dp[i] = Math.Max(dp[i - 1], Math.Max(dp[i - 2] + a[i], dp[i - 3] + a[i - 1] + a[i]));
            }

            sb.AppendLine($"{dp[N - 1]}");
            Console.WriteLine(sb);
        }//Main
    }
}