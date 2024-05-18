using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); 
            Dictionary<string, int> Dict = new Dictionary<string, int>();
            int answer = 0;
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            
            for (int i = 0; i < N; ++i)
            {
                string A = Console.ReadLine();
                Dict.Add(A, i);
            }

            for (int i = 0;i < M; ++i)
            {
                string B = Console.ReadLine();
                if (Dict.ContainsKey(B))
                {
                    ++answer;
                }
            }
            sb.AppendLine($"{answer}");
            Console.Clear();
            Console.WriteLine(sb);

        }//main
    }
}