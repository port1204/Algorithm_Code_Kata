namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int[] nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                Array.Sort(nums);
                sw.WriteLine(nums[0] * nums[2]);
            }
        }
    }
}
