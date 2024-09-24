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
                int K = int.Parse(input[1]);
                int[] nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                Array.Sort(nums);
                Array.Reverse(nums);
                sw.WriteLine(nums[K - 1]);
            }
        }


    }
}