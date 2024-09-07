namespace testcoding
{
    internal class Program
    {
        static int minus = 0;
        static int zero = 0;
        static int plus = 0;
        static int[,] sq;

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                sq = new int[N,N];
                for (int i = 0; i < N; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    for (int j = 0; j < N; ++j)
                    {
                        sq[i,j] = int.Parse(input[j]);
                    }
                }

                Paper(0, 0, N);
                sw.WriteLine(minus);
                sw.WriteLine(zero);
                sw.WriteLine(plus);
            }
        }

        static void Paper(int x, int y, int size)
        {
            if (IsColor(x, y, size))
            {
                if (sq[x, y] == -1)
                {
                    ++minus;
                }
                else if (sq[x, y] == 0)
                {
                    ++zero;
                }
                else if (sq[x, y] == 1)
                {
                    ++plus;
                }
            }
            else
            {
                int newSize = size / 3;
                Paper(x, y, newSize); // 1
                Paper(x + newSize, y, newSize); // 2
                Paper(x + (newSize * 2), y, newSize); // 3
                Paper(x, y + newSize, newSize); // 4
                Paper(x + newSize, y + newSize, newSize); // 5
                Paper(x + (newSize * 2), y + newSize, newSize); // 6
                Paper(x, y + (newSize * 2), newSize); // 7
                Paper(x + newSize, y + (newSize * 2), newSize); // 8
                Paper(x + (newSize * 2), y + (newSize * 2), newSize); // 9
            }
        }

        static bool IsColor(int x, int y, int size)
        {
            int color = sq[x, y];
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    if (sq[x + i, y + j] != color)
                        return false;
                }
            }
            return true;
        }
    }
}