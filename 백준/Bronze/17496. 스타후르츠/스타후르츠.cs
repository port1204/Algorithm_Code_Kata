namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string[] nums = sr.ReadLine().Split();
                int N = int.Parse(nums[0]);
                int T = int.Parse(nums[1]);
                int C = int.Parse(nums[2]);
                int P = int.Parse(nums[3]);

                sw.WriteLine((((N - 1) / T) * C) * P);
            }
        }
    }
}
