using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int T = int.Parse(Console.ReadLine());
            for ( int i = 0; i < T; ++i )
            {
                int N = int.Parse(Console.ReadLine());
                int[,] S = new int[2, N];
                for ( int j = 0; j < 2; ++j )
                {
                    string[] input = Console.ReadLine().Split();
                    for ( int k = 0; k < N; ++k )
                    {
                        S[j,k] = int.Parse(input[k]);
                    }
                }

                if (N == 1)
                {
                    sb.AppendLine(Math.Max(S[0, 0], S[1, 0]).ToString());
                    continue;
                }

                int[,] dp = new int[2, N];
                dp[0, 0] = S[0,0];
                dp[1, 0] = S[1, 0];
                dp[0, 1] = S[1, 0] + S[0, 1];
                dp[1, 1] = S[0, 0] + S[1, 1];
                for ( int k = 2; k < N; ++k)
                {
                    dp[0, k] = Math.Max(dp[1, k - 1], dp[1, k - 2]) + S[0, k];
                    dp[1, k] = Math.Max(dp[0, k - 1], dp[0, k - 2]) + S[1, k];
                }
                int answer = Math.Max(dp[0, N - 1], dp[1, N - 1]);
                sb.AppendLine(answer.ToString());
            }
            Console.WriteLine(sb);
        }//Main
    }
}