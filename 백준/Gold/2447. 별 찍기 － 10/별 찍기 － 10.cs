using System.Text;

namespace testcoding
{
    internal class Program
    {
        static string[,] stars;
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                stars = new string[N,N];
                for (int i = 0; i < N; ++i)
                {
                    for (int j = 0; j < N; ++j)
                    {
                        stars[i, j] = "*";
                    }
                }

                STAR(0, 0, N);
                for (int i = 0; i < N; ++i)
                {
                    for (int j = 0; j < N; ++j)
                    {
                        sb.Append(stars[i, j]);
                    }
                    sb.AppendLine();
                }
                sw.WriteLine(sb.ToString());
            }

            static void STAR(int x, int y, int size)
            {
                if (size == 1)
                {
                    return;
                }

                int newSize = size / 3;
                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        if (i == 1 && j == 1)
                        {
                            RemoveStars(x + (i * newSize), y + (j * newSize), newSize);
                        }
                        else
                        {
                            STAR(x + (i * newSize), y + (j * newSize), newSize);
                        }
                    }
                }
            }

            static void RemoveStars(int x, int y, int size)
            {
                for (int i = 0; i < size; ++i)
                {
                    for (int j = 0; j < size; ++j)
                    {
                        stars[x + i, y + j] = " ";
                    }
                }
            }

        }
    }
}