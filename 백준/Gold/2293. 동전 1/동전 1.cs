namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string[] input = sr.ReadLine().Split();
                int n = int.Parse(input[0]);
                int k = int.Parse(input[1]);
                int[] coin = new int[n];
                for (int i = 0; i < n; ++i)
                {
                    coin[i] = int.Parse(sr.ReadLine());
                }

                int[] dp = new int[k + 1];
                dp[0] = 1;

                foreach (int c in coin)
                {
                    for (int i = c; i <= k; ++i)
                    {
                        dp[i] += dp[i - c];
                    }
                }

                sw.WriteLine(dp[k]);
            }
        } 
    }
}