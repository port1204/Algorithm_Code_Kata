namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int N = int.Parse(sr.ReadLine());
                if (N != 0)
                {
                    double per = 15;
                    double a = (double)N * (per / 100);
                    int b = (int)Math.Round(a, MidpointRounding.AwayFromZero);
                    int sum = 0;
                    int[] nums = new int[N];
                    for (int i = 0; i < N; ++i)
                    {
                        int input = int.Parse(sr.ReadLine());
                        nums[i] = input;
                    }
                    Array.Sort(nums);
                    for (int i = b ;i < N - b; ++i)
                    {
                        sum += nums[i];
                    }
                    double c = (double)sum / (nums.Length - (b*2));
                    int answer = (int)Math.Round(c, MidpointRounding.AwayFromZero);
                    sw.WriteLine(answer);
                }
                else
                {
                    sw.WriteLine(N);
                }
            }
        }

    }
}