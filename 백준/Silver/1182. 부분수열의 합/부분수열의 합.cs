namespace testcoding
{
    internal class Program
    {
        static int count = 0;

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            { 
                string[] input = sr.ReadLine().Split();
                int N = int.Parse(input[0]);
                int S = int.Parse(input[1]);

                string[] input2 = sr.ReadLine().Split();
                int[] nums = new int[N];
                for (int i = 0; i < N; ++i)
                {
                    nums[i] = int.Parse(input2[i]);
                }

                GenerateSequences(N, S, nums, 0 , 0);

                sw.Write(count);
            }
        }

        static void GenerateSequences(int N, int S, int[] nums, int start, int sum)
        {
            if (start > 0 && sum == S)
            {
                count++;
            }

            for (int i = start; i < N; ++i)
            {
                GenerateSequences(N, S, nums, i + 1, sum + nums[i]);
            }
        }
    }
}