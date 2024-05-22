using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());
            sb.Append(MinSquares(N));
            Console.Clear();
            Console.WriteLine(sb.ToString());
        }//main

        public static int MinSquares(int N)
        {
            int[] DP = new int[N + 1];

            for (int i = 0; i <= N; i++)
            {
                DP[i] = int.MaxValue;
            }

            DP[0] = 0;

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j * j <= i; j++)
                {
                    DP[i] = Math.Min(DP[i], DP[i - j * j] + 1);
                }
            }

            return DP[N];
        }
    }
}