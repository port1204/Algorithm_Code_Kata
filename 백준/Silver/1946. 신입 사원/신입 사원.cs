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
                    (int, int)[] nums = new (int, int)[N];
                    for (int j = 0; j < N; ++j)
                    {
                        string[] input = sr.ReadLine().Split();
                        int a = int.Parse(input[0]);
                        int b = int.Parse(input[1]);
                        nums[j] = (a, b);
                    }

                    nums = nums.OrderBy(x => x.Item1).ToArray();

                    int count = 1;
                    int min = nums[0].Item2;

                    for (int j = 1; j < N ; ++j)
                    {
                        if (nums[j].Item2 < min)
                        {
                            ++count;
                            min = nums[j].Item2;
                        }
                    }

                    sw.WriteLine(count);
                }

            }
        }
    }
}