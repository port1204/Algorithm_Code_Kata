namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; ++i)
            {
                int N = int.Parse(Console.ReadLine());
                int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Array.Sort(nums);
                Console.WriteLine(nums[0]);
                Console.WriteLine(nums[N - 1]);
            }
        }
    }
}