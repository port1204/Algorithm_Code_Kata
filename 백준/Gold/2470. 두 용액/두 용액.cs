namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {

                int N = int.Parse(sr.ReadLine());
                long[] nums = Array.ConvertAll(sr.ReadLine().Split(), long.Parse);

                Array.Sort(nums);

                int left = 0;
                int right = N - 1;
                long min = long.MaxValue;
                long L = 0;
                long R = 0;

                while (left < right)
                {
                    long sum = nums[left] + nums[right];

                    if (Math.Abs(sum) < Math.Abs(min))
                    {
                        min = sum;
                        L = nums[left];
                        R = nums[right];
                    }

                    if (sum < 0)
                    {
                        ++left;
                    }
                    else
                    {
                        --right;
                    }
                }

                sw.WriteLine($"{L} {R}");
            }
        }

    }
}