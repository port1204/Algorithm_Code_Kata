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
                nums[0] *= 56;
                nums[1] *= 24;
                nums[2] *= 14;
                nums[3] *= 6;
                sw.WriteLine(nums[0] + nums[1] + nums[2] + nums[3]);
            } // using
        } // Main
    } // class
} // ns
