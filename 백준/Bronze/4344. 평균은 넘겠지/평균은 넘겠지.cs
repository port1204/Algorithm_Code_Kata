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
                for (int i = 0; i < N; ++i)
                {
                    float[] nums = Array.ConvertAll(sr.ReadLine().Split(), float.Parse);
                    float sum = 0;
                    for (int j = 1; j < nums.Length; ++j)
                    {
                        sum += nums[j];
                    }
                    float average = sum / nums[0];
                    float count = 0;
                    for (int j = 1; j < nums.Length; ++j)
                    {
                        if (nums[j] > average)
                        {
                            ++count;
                        }
                    }
                    sw.WriteLine($"{((count/nums[0])*100).ToString("F3")}%");
                }
            }
        }

    }
}