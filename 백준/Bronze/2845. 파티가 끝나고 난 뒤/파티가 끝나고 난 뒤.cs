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
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);
                int[] nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int i = 0; i < 5; ++i)
                {
                    nums[i] -= A * B;
                }
                sw.WriteLine(string.Join(" ", nums));
            }
        }


    }
}