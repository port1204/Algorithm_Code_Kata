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
                int[] nums = new int[N];
                for (int i = 0; i < N; ++i)
                {
                    nums[i] = int.Parse(sr.ReadLine());
                }
                Array.Sort(nums);
                for (int i = 0; i < N; ++i)
                {
                    sw.WriteLine(nums[i]);
                }
            }
        }


    }
}