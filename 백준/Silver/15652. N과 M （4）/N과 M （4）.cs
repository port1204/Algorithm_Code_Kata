using System.Text;

namespace testcoding
{
    internal class Program
    {
        static StringBuilder sb = new StringBuilder(); 
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            List<int> sequence = new List<int>();

            GenerateSequences(N, M, 1, sequence);

            Console.WriteLine(sb);
        }

        static void GenerateSequences(int N, int M, int start, List<int> sequence)
        {
            if (sequence.Count == M)
            {
               sb.AppendLine(string.Join(" ", sequence));
                return;
            }

            for (int i = start; i <= N; ++i)
            {
                sequence.Add(i);

                GenerateSequences(N, M, i, sequence);

                sequence.RemoveAt(sequence.Count - 1);
            }
        }
    }
}
