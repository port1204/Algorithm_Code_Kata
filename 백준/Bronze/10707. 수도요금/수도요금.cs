namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int[] nums = new int[5];
                for (int i = 0; i < 5;  i++)
                {
                    nums[i] = int.Parse(sr.ReadLine());
                }

                if (nums[4] > nums[2])
                {
                    nums[1] += (nums[4] - nums[2]) * nums[3];
                }

                int min = Math.Min(nums[1] , nums[0] * nums[4]);

                sw.WriteLine(min);
            } // using
        } // Main
    } // class
} // ns
