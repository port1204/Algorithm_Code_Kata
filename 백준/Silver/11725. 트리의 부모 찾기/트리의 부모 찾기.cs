using System.Text;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());
            List<List<int>> adjList = new List<List<int>>(N + 1); // 인접 리스트
            for (int i = 0; i <= N; i++)
            {
                adjList.Add(new List<int>());
            }

            for  (int i = 0; i < N - 1; ++i)
            {
                string[] input = Console.ReadLine().Split();
                int u = int.Parse(input[0]);
                int v = int.Parse(input[1]);
                adjList[u].Add(v); // 각각의 노드에 연결된 노드를 저장
                adjList[v].Add(u);
            }

            int[] parent = new int[N + 1];
            bool[] visited = new bool[N + 1];

            Stack<int> stack = new Stack<int>();
            stack.Push(1); // root = 1
            visited[1] = true;

            while (stack.Count > 0)
            {
                int node = stack.Pop();

                foreach (int neighbor in adjList[node]) //인접 리스트에 저장된 노드 순회
                {
                    if (!visited[neighbor]) // 미방문시 진입
                    {
                        parent[neighbor] = node; // neighbor의 부모로 node를 입력
                        visited[neighbor] = true; // 방문 체크
                        stack.Push(neighbor); // 자식 노드 스택에 넣기
                    }
                }
            }

            for (int i = 2; i <= N; ++i) // 2번 노드 부터 출력
            {
                sb.AppendLine($"{parent[i]}");
            }

            Console.WriteLine(sb);
        }
    }
}