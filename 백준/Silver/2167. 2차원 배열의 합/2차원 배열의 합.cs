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

                int[,] arr = new int[N + 1, M + 1];
                int[,] prefix = new int[N + 1, M + 1];

                for (int i = 1; i <= N; ++i)
                {
                    input = sr.ReadLine().Split();
                    for (int j = 1; j <= M; ++j)
                    {
                        arr[i, j] = int.Parse(input[j - 1]);
                        prefix[i, j] = arr[i, j] + prefix[i - 1, j] + prefix[i, j - 1] - prefix[i - 1, j - 1];
                    }
                }

                int K = int.Parse(sr.ReadLine());
                for (int k = 0; k < K; ++k)
                {
                    input = sr.ReadLine().Split();
                    int i = int.Parse(input[0]);
                    int j = int.Parse(input[1]);
                    int x = int.Parse(input[2]);
                    int y = int.Parse(input[3]);

                    int result = prefix[x, y] - prefix[i - 1, y] - prefix[x, j - 1] + prefix[i - 1, j - 1];
                    sw.WriteLine(result);
                }
            }

        }
    }
}