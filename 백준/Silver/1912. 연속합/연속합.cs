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
            dp[0] = A[0];

            for (int i = 1; i < N; ++i)
            {
                dp[i] = Math.Max(A[i] + dp[i - 1], A[i]);
                answer = Math.Max(answer, dp[i]);
            }

            sb.Append(answer);
            Console.Clear();
            Console.WriteLine(sb.ToString());
        }//Main
    }
}