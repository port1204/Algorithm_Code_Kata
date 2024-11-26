namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {

                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int[] nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int sum = 0;
                int answer = 0;
                for (int i = 0; i < input[0]; i++)
                {
                    sum += nums[i];
                    if (sum > input[1])
                    {
                        break;
                    }
                    answer++;
                }
                sw.WriteLine(answer);

            } // using
        } // Main
    } // class
} // namespace
