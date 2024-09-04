namespace testcoding
{
    internal class Program
    {
        static int[] dx = { -1, 1, 0, 0 };
        static int[] dy = { 0, 0, -1, 1 };

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                int[,] map = new int[N, N];
                bool[,] visited = new bool[N, N];
                List<int> complexSizes = new List<int>();

                for (int i = 0; i < N; ++i)
                {
                    string line = sr.ReadLine();
                    for (int j = 0; j < N; ++j)
                    {
                        map[i, j] = line[j] - '0';
                    }
                }

                for (int i = 0; i < N; ++i)
                {
                    for (int j = 0; j < N; ++j)
                    {
                        if (map[i, j] == 1 && !visited[i, j])
                        {
                            int houseCount = DFS(map, visited, N, i, j);
                            complexSizes.Add(houseCount);
                        }
                    }
                }

                sw.WriteLine(complexSizes.Count);

                complexSizes.Sort();

                foreach (int size in complexSizes)
                {
                    sw.WriteLine(size);
                }
            }
        }

        static int DFS(int[,] map, bool[,] visited, int N, int x, int y)
        {
            Stack<(int, int)> stack = new Stack<(int, int)>();
            stack.Push((x, y));
            visited[x, y] = true;
            int count = 1;

            while (stack.Count > 0)
            {
                var (cx, cy) = stack.Pop();

                for (int i = 0; i < 4; i++)
                {
                    int nx = cx + dx[i];
                    int ny = cy + dy[i];

                    if (nx >= 0 && ny >= 0 && nx < N && ny < N && map[nx, ny] == 1 && !visited[nx, ny])
                    {
                        visited[nx, ny] = true;
                        stack.Push((nx, ny));
                        ++count;
                    }
                }
            }

            return count;
        }
    }
}