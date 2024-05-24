using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());
            sb.Append($"{DP(N)}");
            Console.Clear();
            Console.WriteLine(sb.ToString());
        }//Main

        public static int DP(int N)
        {
            int[] dp = new int[1001];

            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 3;

            for (int i = 3; i <= N; ++i)
            {
                dp[i] = dp[i - 1] + dp[i - 2] * 2;
                dp[i] %= 10007;
            }

            return dp[N];
        }//DP()
    }
}