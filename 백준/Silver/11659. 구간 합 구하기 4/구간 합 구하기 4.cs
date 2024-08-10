using static System.Net.Mime.MediaTypeNames;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                string[] input = sr.ReadLine().Split();
                int N = int.Parse(input[0]);
                int M = int.Parse(input[1]);

                string[] nums = sr.ReadLine().Split();

                int[] num = new int[N + 1];
                int[] prefix = new int[N + 1];
                for (int i = 1; i <= N; ++i)
                {
                    num[i] = int.Parse(nums[i - 1]);
                    prefix[i] = prefix[i - 1] + num[i];
                }

                for (int i = 0; i < M; ++i)
                {
                    string[] A = sr.ReadLine().Split();
                    int start = int.Parse(A[0]);
                    int end = int.Parse(A[1]);
                    int sum = prefix[end] - prefix[start - 1];
                    sw.WriteLine(sum);
                }

            }

        }


    }
}