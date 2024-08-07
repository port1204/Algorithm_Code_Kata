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
                int K = int.Parse(input[1]);

                List<int> num = new List<int>();
                for (int i = 1; i <= N; ++i)
                {
                    num.Add(i);
                }

                int[] nums = new int[N];
                int a = 0;
                for (int i = 0; i < N; ++i)
                {
                    a = (a + K - 1) % num.Count;
                    nums[i] = num[a];
                    num.RemoveAt(a);
                }

                sw.WriteLine("<" + string.Join(", ", nums) + ">");
            }
        }
    }
}