namespace testcoding
{
    internal class Program
    {
        static char[,] candy;
        static int Max = 0;

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                candy = new char[N, N];
                for (int i = 0; i < N; ++i)
                {
                    string input = sr.ReadLine();
                    for (int j = 0; j < N; ++j)
                    {
                        candy[i,j] = input[j];
                    }
                }

                for (int i = 0; i < N; ++i)
                {
                    for (int j = 0; j < N; ++j)
                    {
                        if (j + 1 < N)
                        {
                            ChangeCandy(i, j, i, j + 1);
                            MatchCandy(N);
                            ChangeCandy(i, j, i, j + 1);
                        }

                        if (i + 1 < N)
                        {
                            ChangeCandy(i, j, i + 1, j);
                            MatchCandy(N);
                            ChangeCandy(i, j, i + 1, j);
                        }
                    }
                }

                sw.WriteLine(Max);
            }
        }

        static void MatchCandy(int size)
        {
            for (int i = 0; i < size; ++i)
            {
                int count = 1;
                for (int j = 1; j < size; ++j)
                {
                    if (candy[i, j] == candy[i, j - 1])
                    {
                        ++count;
                    }
                    else
                    {
                        count = 1;
                    }
                    Max = Math.Max(Max, count);
                }

                count = 1;
                for (int j = 1; j < size; ++j)
                {
                    if (candy[j, i] == candy[j - 1, i])
                    {
                        ++count;
                    }
                    else
                    {
                        count = 1;
                    }
                    Max = Math.Max(Max, count);
                }
            }
        }

        static void ChangeCandy(int a, int b, int aa, int bb)
        {
            char temp = candy[a, b];
            candy[a, b] = candy[aa, bb];
            candy[aa, bb] = temp;
        }

    }
}