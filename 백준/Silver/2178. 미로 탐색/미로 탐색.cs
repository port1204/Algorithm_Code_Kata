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
                string[] input = sr.ReadLine().Split();
                int N = int.Parse(input[0]);
                int M = int.Parse(input[1]);
                int[,] map = new int[N, M];
                bool[,] visited = new bool[N, M];

                for (int i = 0; i < N; ++i)
                {
                    string line = sr.ReadLine();
                    for (int j = 0; j < M; ++j)
                    {
                        map[i, j] = line[j] - '0';
                    }
                }

                int result = BFS(map, visited, N, M);
                sw.WriteLine(result);
            }
        }
        
        static int BFS(int[,] map, bool[,] visited, int N, int M)
        {
            Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
            queue.Enqueue((0, 0, 1));
            visited[0, 0] = true;

            while (queue.Count > 0)
            {
                var (x, y, dist) = queue.Dequeue();

                if (x == N - 1 && y == M - 1)
                {
                    return dist;
                }

                for (int i = 0; i < 4; ++i)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];

                    if (nx >= 0 && nx < N && ny >= 0 && ny < M && map[nx, ny] == 1 && !visited[nx, ny])
                    {
                        visited[nx, ny] = true; 
                        queue.Enqueue((nx, ny, dist + 1)); 
                    }
                }
            }

            return -1;
        }
    }
}