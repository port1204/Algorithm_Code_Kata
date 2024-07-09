using System;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char[,] map = new char[N, N];
            char[,] click = new char[N, N];
            bool isBomb = false;

            for (int i = 0; i < N; ++i)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < N; ++j)
                {
                    map[i, j] = input[j];
                }
            }

            for (int i = 0; i < N; ++i)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < N; ++j)
                {
                    click[i, j] = input[j];
                    if (click[i, j] == 'x' && map[i, j] == '*')
                    {
                        isBomb = true;
                    }
                }
            }

            char[,] result = new char[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (isBomb && map[i, j] == '*')
                    {
                        result[i, j] = '*';
                    }
                    else if (click[i, j] == 'x')
                    {
                        int count = 0;
                        for (int di = -1; di <= 1; di++)
                        {
                            for (int dj = -1; dj <= 1; dj++)
                            {
                                int ni = i + di;
                                int nj = j + dj;
                                if (ni >= 0 && ni < N && nj >= 0 && nj < N && map[ni, nj] == '*')
                                {
                                    count++;
                                }
                            }
                        }
                        result[i, j] = (char)('0' + count);
                    }
                    else
                    {
                        result[i, j] = '.';
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(result[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
