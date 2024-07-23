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

            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(nums);

            GenerateSequences(N, M, nums, sequence, 0);

            Console.WriteLine(sb);
        }

        static void GenerateSequences(int N, int M, int[] nums, List<int> sequence, int start)
        {
            if (sequence.Count == M)
            {
               sb.AppendLine(string.Join(" ", sequence));
                return;
            }

            for (int i = start; i < N; ++i)
            {
                if (sequence.Contains(nums[i]))
                {
                    continue;
                }

                sequence.Add(nums[i]);

                GenerateSequences(N, M, nums, sequence, i + 1);

                sequence.RemoveAt(sequence.Count - 1);
            }
        }
    }
}