namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {

                List<int> nums = new List<int>();
                int sum = 0;
                for (int i = 0; i < 9; ++i)
                {
                    nums.Add(int.Parse(sr.ReadLine()));
                    sum += nums[i];
                }

                for (int i = 0; i < nums.Count; ++i)
                {
                    for (int j = i + 1; j < nums.Count; ++j)
                    {
                        if (sum - (nums[i] + nums[j]) == 100)
                        {
                            nums.Remove(nums[i]);
                            nums.Remove(nums[j - 1]);
                            break;
                        }
                    }
                    if (nums.Count == 7)
                    {
                        break;
                    }
                }

                nums.Sort();

                foreach (int i in nums)
                {
                    sw.WriteLine(i);
                }

            }
        }

    }
}