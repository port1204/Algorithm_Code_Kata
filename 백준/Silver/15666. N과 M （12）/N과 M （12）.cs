using System.Text;

namespace testcoding
{
    internal class Program
    {
        static StringBuilder sb = new StringBuilder();
        static HashSet<string> hs = new HashSet<string>();

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            { 
                string[] input = sr.ReadLine().Split();
                int N = int.Parse(input[0]);
                int M = int.Parse(input[1]);

                string[] input2 = sr.ReadLine().Split();
                int[] nums = new int[N];
                for (int i = 0; i < N; ++i)
                {
                    nums[i] = int.Parse(input2[i]);
                }
                Array.Sort(nums);

                GenerateSequences(N, M, nums, new List<int>(), 0);

                sw.Write(sb);
            }
        }

        static void GenerateSequences(int N, int M, int[] nums, List<int> sequence, int start)
        {
            if (sequence.Count == M)
            {
                string answer = string.Join(" ", sequence);
                if (!hs.Contains(answer))
                {
                    hs.Add(answer);
                    sb.AppendLine(answer);
                }
                return;
            }

            for (int i = start; i < N; ++i)
            {
                sequence.Add(nums[i]);
                GenerateSequences(N, M, nums, sequence, i);
                sequence.RemoveAt(sequence.Count - 1);
            }
        }
    }
}