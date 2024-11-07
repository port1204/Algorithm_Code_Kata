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
                for (int i = 0; i < T; i++)
                {
                    int[] nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    List<int> list = new List<int>();
                    int sum = 0;
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[j] % 2 == 0)
                        {
                            sum += nums[j];
                            list.Add(nums[j]);
                        }
                    }
                    list.Sort();
                    sw.WriteLine($"{sum} {list[0]}");
                }
                
            } // using
        } // Main
    } // class
} // ns
