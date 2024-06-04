namespace CodingTest2
{
    internal class Program
    {
        static bool[] visited;
        static List<int>[] network;
        static int infectedCount = 0;

        static void Main(string[] args)
        {
            int total = int.Parse(Console.ReadLine());
            int pairCount = int.Parse(Console.ReadLine());
            visited = new bool[total + 1];
            network = new List<int>[total + 1];
            for (int i = 1; i <= total; ++i)
            {
                network[i] = new List<int>();
            }

            for (int i = 0; i < pairCount; ++i)
            {
                string[] pair = Console.ReadLine().Split();
                int a = int.Parse(pair[0]);
                int b = int.Parse(pair[1]);
                network[a].Add(b);
                network[b].Add(a);
            }

            DFS(1);

            Console.WriteLine(infectedCount - 1);
        }//Main

        static void DFS(int computer)
        {
            visited[computer] = true;
            ++infectedCount;

            foreach (int connected in network[computer])
            {
                if (!visited[connected])
                {
                    DFS(connected);
                }
            }
        }//DFS()
    }
}