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
                float[] nums = Array.ConvertAll(sr.ReadLine().Split(), float.Parse);
                Array.Sort(nums);

                float sum = 0;
                for (int i = 0; i < N; ++i)
                {
                    nums[i] = (nums[i] / nums[N - 1]) * 100;
                    sum += nums[i];
                }

                sw.WriteLine(sum/N);

            }
        }

    }
}
