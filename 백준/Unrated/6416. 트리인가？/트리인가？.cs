namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOver= false;
            int caseNumber = 1;
            while (true)
            {
                bool caseInputOver = false; // 케이스 입력 종료 체크
                var edges = new List<(int, int)>(); // 두개의 값을 동시에 저장하기 위한 TupleList사용
                var nodes = new HashSet<int>(); // 중복된 값을 넣지 않기 위해 HashSet으로 한다.

                while (true)
                {
                    var inputLine = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(inputLine)) // 빈줄 체크
                        continue;

                    var input = inputLine.Split();

                    for (int i = 0; i < input.Length; i += 3)
                    {
                        int u = int.Parse(input[i]);
                        int v = int.Parse(input[i + 1]);

                        if (u == -1 && v == -1) // 전체 끝
                        {
                            isOver = true;
                            break;
                        }

                        if (u == 0 && v == 0) // 케이스 끝
                        {
                            caseInputOver = true;
                            break;
                        } 

                        edges.Add((u, v)); // 간선 추가
                        nodes.Add(u); //노드 추가
                        nodes.Add(v); //노드 추가
                    }

                    if (edges.Count == 0 || caseInputOver) // 입력이 더이상 없을떄 멈추기 위한 부분
                        break;
                }

                if (isOver) // 전체 종료
                    break;

                if (edges.Count == 0 && nodes.Count == 0) // 아예 아무것도 없는 경우도 트리 이기 때문
                {
                    Console.WriteLine($"Case {caseNumber} is a tree.");
                    ++caseNumber;
                    continue; // 다음 루프로 이동
                }

                var indegree = new Dictionary<int, int>(); // 진입차수
                foreach (var node in nodes)
                    indegree[node] = 0; // 모든 노드를 순회하며 초기화

                foreach (var (u, v) in edges)
                    indegree[v]++; // 해당 노드로 들어오는 간선의 갯수를 의미함

                var rootCandidates = nodes.Where(node => indegree[node] == 0).ToList(); // 진입차수가 0인 루트노드를 찾기

                if (rootCandidates.Count != 1) // 루트 노드가 1개가 아니면 트리가 아니게 됨
                {
                    Console.WriteLine($"Case {caseNumber} is not a tree.");
                    ++caseNumber;
                    continue; // 다음 루프로 이동
                }

                int root = rootCandidates[0]; // 루트노드 지정

                // 트리 판별하기 위해DFS 사용
                var visited = new HashSet<int>();
                var stack = new Stack<int>();
                stack.Push(root); // 루트 노드를 스택에 추가하여 탐색 시작

                while (stack.Count > 0)
                {
                    var node = stack.Pop();
                    if (visited.Contains(node)) // 이미 방문했다면 다음으로 넘어감
                        continue;

                    visited.Add(node); // 노드 방문시 추가

                    foreach (var (u, v) in edges.Where(e => e.Item1 == node))
                        stack.Push(v); // 해당 노드와 이어진 간선을 체크해서 다음 노드를 스택에 모두 저장
                }

                // 루트를 제외한 모든 노드의 진입 차수가 1인지 체크
                bool isTree = visited.Count == nodes.Count && nodes.All(node => node == root || indegree[node] == 1);

                if (isTree) //결과 출력
                    Console.WriteLine($"Case {caseNumber} is a tree.");
                else
                    Console.WriteLine($"Case {caseNumber} is not a tree.");

                ++caseNumber;
            }
        }
    }
}