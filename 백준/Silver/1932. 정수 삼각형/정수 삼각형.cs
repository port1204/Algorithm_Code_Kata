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

                int[,] nums = new int[N,N];
                int[,] dp = new int[N,N];
                for (int i = 0; i < N; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    for (int j = 0; j < i + 1; ++j)
                    {
                        nums[i,j] = int.Parse(input[j]);
                        dp[i,j] = nums[i, j];
                    }
                }

                for (int i = 1; i < N; ++i)
                {
                    for (int j = 0; j <= i; ++j)
                    {
                        if (j == 0)
                        {
                            dp[i, j] = dp[i - 1, j] + nums[i, j];
                        }
                        else if (j == i)
                        {
                            dp[i, j] = dp[i - 1, j - 1] + nums[i, j];
                        }
                        else
                        {
                            dp[i, j] = Math.Max(dp[i - 1, j - 1], dp[i - 1, j]) + nums[i, j];
                        }
                    }
                }

                int sum = 0;
                for (int i = 0; i < N; i++)
                {
                    if (dp[N - 1, i] > sum)
                    {
                        sum = dp[N - 1, i];
                    }
                }

                sw.WriteLine(sum);
            }
        }

    }
}