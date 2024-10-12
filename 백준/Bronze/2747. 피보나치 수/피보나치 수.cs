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
                int[] dp = new int[N + 1];
                dp[0] = 0;
                dp[1] = 1;
                for (int i = 2; i <= N; ++i)
                {
                    dp[i] = dp[i - 1] + dp[i - 2];
                }
                sw.WriteLine(dp[N]);
            }
        }
    }
}