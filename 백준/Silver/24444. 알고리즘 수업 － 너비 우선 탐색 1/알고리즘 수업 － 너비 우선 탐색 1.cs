namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string[] input = sr.ReadLine().Split();
                int N = int.Parse(input[0]);
                int M = int.Parse(input[1]);
                int R = int.Parse(input[2]);

                List<int>[] graph = new List<int>[N + 1];
                for (int i = 1; i <= N; ++i)
                {
                    graph[i] = new List<int>();
                }

                for (int i = 0; i < M; ++i)
                {
                    input = sr.ReadLine().Split();
                    int u = int.Parse(input[0]);
                    int v = int.Parse(input[1]);
                    graph[u].Add(v);
                    graph[v].Add(u);
                }

                for (int i = 1; i <= N; ++i)
                {
                    graph[i].Sort();
                }

                int[] visitOrder = BFS(N, R, graph);

                for (int i = 1; i <= N; ++i)
                {
                    sw.WriteLine(visitOrder[i]);
                }
            }
        }

        static int[] BFS(int N, int start, List<int>[] graph)
        {
            Queue<int> queue = new Queue<int>();
            int[] visited = new int[N + 1];
            int order = 1; 

            queue.Enqueue(start);
            visited[start] = order;

            while (queue.Count > 0)
            {
                int u = queue.Dequeue();

                foreach (int v in graph[u])
                {
                    if (visited[v] == 0)
                    {
                        ++order;
                        visited[v] = order;
                        queue.Enqueue(v);
                    }
                }
            }

            return visited;
        }

    }
}