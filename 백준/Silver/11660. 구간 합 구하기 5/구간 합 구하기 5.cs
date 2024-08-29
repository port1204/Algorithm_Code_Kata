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
                int N = int.Parse(input[0]);
                int M = int.Parse(input[1]);

                int[,] ints = new int[N + 1, N + 1];
                int[,] sum = new int[N + 1, N + 1];
                for (int i = 1; i <= N ; ++i)
                {
                    int[] nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    for (int j = 1; j <= N; ++j)
                    {
                        ints[i, j] = nums[j - 1];
                        sum[i, j] = ints[i, j] + sum[i - 1, j] + sum[i, j - 1] - sum[i - 1, j - 1];
                    }
                }

                for (int i = 0; i < M; ++i)
                {
                    string[] query = sr.ReadLine().Split();
                    int x = int.Parse(query[0]);
                    int y = int.Parse(query[1]);
                    int xx = int.Parse(query[2]);
                    int yy = int.Parse(query[3]);

                    int result = sum[xx, yy] - sum[x - 1, yy] - sum[xx, y - 1] + sum[x - 1, y - 1];
                    sw.WriteLine(result);
                }


            }

        }
    }
}