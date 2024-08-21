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
                    int[] nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    long sum = 0;
                    int n = nums[0];

                    for (int j = 1; j < n; ++j)
                    {
                        for (int k = j + 1; k <= n; ++k)
                        {
                            sum += GCD(nums[j], nums[k]);
                        }
                    }
                    sw.WriteLine(sum);
                }
            }
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

    }
}