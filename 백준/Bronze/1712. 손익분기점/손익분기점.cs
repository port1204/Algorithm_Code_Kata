namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                long[] nums = Array.ConvertAll(sr.ReadLine().Split(), long.Parse);
                if (nums[1] < nums[2])
                {
                    long goal = nums[0] / (nums[2] - nums[1]) + 1;
                    sw.WriteLine(goal);
                }
                else
                {
                    sw.WriteLine(-1);
                }
            }
        }
    }
}