namespace CodingTest2
{
    internal class Program
    {
        static bool[] visited;
        static List<int>[] network;
        static List<int> _DFS = new List<int>();
        static List<int> _BFS = new List<int>();

        static void Main(string[] args)
        {
            string[] T = Console.ReadLine().Split();
            int N = int.Parse(T[0]);
            int M = int.Parse(T[1]);
            int V = int.Parse(T[2]);
            visited = new bool[N + 1];
            network = new List<int>[N + 1];
            for (int i = 1; i <= N; ++i)
            {
                network[i] = new List<int>();
            }

            for (int i = 0; i < M; ++i)
            {
                string[] pair = Console.ReadLine().Split();
                int a = int.Parse(pair[0]);
                int b = int.Parse(pair[1]);
                network[a].Add(b);
                network[b].Add(a);
            }

            for (int i = 1; i <= N; ++i)
            {
                network[i].Sort();
            }

            DFS(V);
            Console.WriteLine(string.Join(" ", _DFS));

            visited = new bool[N + 1];
            BFS(V);
            Console.WriteLine(string.Join(" ", _BFS));
        }//Main

        static void DFS(int now)
        {
            visited[now] = true;
            _DFS.Add(now);

            foreach (int next in network[now])
            {
                if (!visited[next])
                {
                    DFS(next);

                }
            }
        }//DFS()

        static void BFS(int start)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            visited[start] = true;
            
            while (queue.Count > 0)
            {
                int now = queue.Dequeue();
                _BFS.Add(now);

                foreach (int next in network[now])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);
                    }
                }
            }
        }//BFS()
    }
}