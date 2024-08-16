namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string input = sr.ReadLine();
                char[] nums = input.ToCharArray();
                Array.Sort(nums);
                Array.Reverse(nums);
                int sum = 0;

                if (!nums.Contains('0'))
                {
                    sw.WriteLine(-1);
                    return;
                }

                foreach (char c in nums)
                {
                    sum += c - '0';
                }

                if (sum % 3 == 0)
                {
                    sw.WriteLine(nums);
                }
                else
                {
                    sw.WriteLine(-1);
                }
            }
        }

    }
}