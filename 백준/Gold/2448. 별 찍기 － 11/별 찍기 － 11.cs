namespace testcoding
{
    internal class Program
    {
        static string[,] stars;

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                stars = new string[N, N * 2]; // 24, 47
                for (int i = 0; i < N; ++i)
                {
                    for (int j = 0; j < N * 2; ++j)
                    {
                        stars[i, j] = " ";
                    }
                }

                STAR(0, N - 1, N);

                for (int i = 0; i < N; ++i)
                {
                    for (int j = 0; j < N * 2; ++j)
                    {
                        sw.Write(stars[i, j]);
                    }
                    sw.WriteLine();
                }

            }

            static void STAR(int x, int y, int N)
            {
                if (N == 3)
                {
                    stars[x, y] = "*"; // 1
                    stars[x + 1, y - 1] = "*"; // 2
                    stars[x + 1, y + 1] = "*";
                    stars[x + 2, y - 2] = "*"; // 3
                    stars[x + 2, y - 1] = "*";  
                    stars[x + 2, y] = "*";
                    stars[x + 2, y + 1] = "*";
                    stars[x + 2, y + 2] = "*";
                }
                else
                {
                    int M = N / 2;
                    STAR(x, y, M); // 위
                    STAR(x + M, y - M, M); // 왼
                    STAR(x + M, y + M, M); // 오
                }
            }


        }
    }
}