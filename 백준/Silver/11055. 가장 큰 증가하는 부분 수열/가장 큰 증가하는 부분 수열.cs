using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int answer = A[0];
            int[] dp = new int[N];
            for (int i = 0; i < N; ++i)
            {
                dp[i] = A[i];
            }
            for (int i = 1; i < N; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    if (A[i] > A[j])
                    {
                        dp[i] = Math.Max(dp[i], A[i] + dp[j]);
                    }
                    answer = Math.Max(answer, dp[i]);
                }
            }
            sb.Append(answer);
            Console.WriteLine(sb);
        }//Main
    }
}