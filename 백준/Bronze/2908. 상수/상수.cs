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
                int[] nums = new int[2];
                for (int i = 0; i < 2; ++i)
                {
                    char[] c = input[i].ToCharArray();
                    Array.Reverse(c);
                    nums[i] = int.Parse(c);
                }

                int answer = Math.Max(nums[0], nums[1]);
                sw.WriteLine(answer);
            }
        }


    }
}