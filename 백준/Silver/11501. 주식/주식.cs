namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int T = int.Parse(sr.ReadLine());
                for (int i = 0; i < T; ++i)
                {
                    int N = int.Parse(sr.ReadLine());
                    int[] nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    long sum = 0;
                    int max = nums[N - 1];
                    for (int j = N - 2; j >= 0; --j)
                    {
                        if (nums[j] > max)
                        {
                            max = nums[j];
                        }
                        else
                        {
                            sum += max - nums[j];
                        }
                    }
                    sw.WriteLine(sum);
                }

            }
        }

    }
}