namespace testcoding
{
    internal class Program
    {
        static int W = 0;
        static int B = 0;
        static int[,] map;

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                map = new int[N, N]; 
                for (int i = 0; i < N; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    for (int j = 0; j < N; ++j)
                    {
                        map[i, j] = int.Parse(input[j]);
                    }
                }
                DivideAndConquer(0, 0, N);

                sw.WriteLine(W);
                sw.WriteLine(B);
            }
        }

        static void DivideAndConquer(int x, int y, int size)
        {
            if (IsUniformColor(x, y, size))
            {
                if (map[x, y] == 0)
                    ++W;
                else
                    ++B;
            }
            else
            {
                int newSize = size / 2;
                DivideAndConquer(x, y, newSize); 
                DivideAndConquer(x, y + newSize, newSize); 
                DivideAndConquer(x + newSize, y, newSize); 
                DivideAndConquer(x + newSize, y + newSize, newSize); 
            }
        }

        static bool IsUniformColor(int x, int y, int size)
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