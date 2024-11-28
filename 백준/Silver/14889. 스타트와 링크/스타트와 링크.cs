namespace testcoding
{
    internal class Program
    {
        static int N;
        static int[,] sum;
        static bool[] visited;
        static int min = int.MaxValue;

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                N = int.Parse(sr.ReadLine());
                sum = new int[N, N];
                visited = new bool[N];

                for (int i = 0; i < N; i++)
                {
                    string[] input = sr.ReadLine().Split();
                    for (int j = 0; j < N; j++)
                    {
                        sum[i, j] = int.Parse(input[j]);
                    }
                }

                Solve(0, 0);
                sw.WriteLine(min);

            } // using
        } // Main

        static void Solve(int depth, int start)
        {
            if (depth == N / 2)
            {
                CalculateDifference();
                return;
            }

            for (int i = start; i < N; i++)
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    Solve(depth + 1, i + 1);
                    visited[i] = false;
                }
            }
        }

        static void CalculateDifference()
        {
            int start = 0;
            int link = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (visited[i] && visited[j])
                    {
                        start += sum[i, j];
                    }
                    else if (!visited[i] && !visited[j])
                    {
                        link += sum[i, j];
                    }
                }
            }

            min = Math.Min(min, Math.Abs(start - link));
        }

    } // class
} // namespace
  //s12 + s21 + s13 + s31 + s23 + s32