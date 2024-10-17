namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string[] input = sr.ReadLine().Split();
                int N = int.Parse(input[0]);
                int Length = int.Parse(input[1]);
                int[] nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                Array.Sort(nums);
                for (int i = 0; i < N; ++i)
                {
                    if (Length >= nums[i])
                    {
                        ++Length;
                    }
                    else
                    {
                        break;
                    }
                }
                sw.WriteLine(Length);
            }
        }

    }
}