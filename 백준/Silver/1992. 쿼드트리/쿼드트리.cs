using System.Text;

namespace testcoding
{
    internal class Program
    {

        static int[,] map;
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                map = new int[N, N];
                for (int i = 0; i < N; ++i)
                {
                    string input = sr.ReadLine();
                    for (int j = 0; j < N; ++j)
                    {
                        map[i, j] = int.Parse(input[j].ToString());
                    }
                }

                QuadTree(0, 0, N);
                sw.WriteLine(sb.ToString());
            }

            static void QuadTree(int x, int y, int size)
            {
                if (CheckMono(x, y, size))
                {
                    sb.Append($"{map[x, y]}");
                }
                else
                {
                    sb.Append("(");
                    int newSize = size / 2;
                    QuadTree(x, y, newSize);
                    QuadTree(x, y + newSize, newSize);
                    QuadTree(x + newSize, y, newSize);
                    QuadTree(x + newSize, y + newSize, newSize);
                    sb.Append(")");
                }
            }

            static bool CheckMono(int x, int y, int size)
            {
                int color = map[x, y];
                for (int i = 0; i < size; ++i)
                {
                    for (int j = 0; j < size; ++j)
                    {
                        if (map[x + i, y + j] != color)
                            return false;
                    }
                }
                return true;
            }

        }
    }
}