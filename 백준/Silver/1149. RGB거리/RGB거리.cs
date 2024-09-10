namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                int[,] dp = new int[N, 3];
                string[] input = sr.ReadLine().Split();
                dp[0, 0] = int.Parse(input[0]);
                dp[0, 1] = int.Parse(input[1]);
                dp[0, 2] = int.Parse(input[2]);
                for (int i = 1; i < N; ++i)
                {
                    input = sr.ReadLine().Split();
                    int R = int.Parse(input[0]);
                    int G = int.Parse(input[1]);
                    int B = int.Parse(input[2]);
                    dp[i, 0] = R + Math.Min(dp[i - 1, 1], dp[i - 1, 2]); // 0,(1,2)
                    dp[i, 1] = G + Math.Min(dp[i - 1, 0], dp[i - 1, 2]); // (0),1,(2)
                    dp[i, 2] = B + Math.Min(dp[i - 1, 0], dp[i - 1, 1]); // (0,1),2
                }
                int min = Math.Min(dp[N - 1, 0], dp[N - 1, 1]);
                min = Math.Min(dp[N - 1, 2], min);
                sw.WriteLine(min);
            }
        }

    }
}