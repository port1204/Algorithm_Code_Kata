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
                int[,] A = new int[N, M];

                for (int i = 0; i < N; ++i)
                {
                    input = sr.ReadLine().Split();
                    for (int j = 0; j < M; ++j)
                    {
                        A[i, j] = int.Parse(input[j]);
                    }
                }

                for (int i = 0; i < N; ++i)
                {
                    input = sr.ReadLine().Split();
                    for (int j = 0; j < M; ++j)
                    {
                        A[i, j] += int.Parse(input[j]);
                        sw.Write(A[i, j]);
                        if (j != M - 1)
                        {
                            sw.Write(" ");
                        }
                    }
                    sw.WriteLine();
                }

            }
        }


    }
}