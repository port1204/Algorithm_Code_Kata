namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int M = int.Parse(Console.ReadLine());
            Array.Sort(nums);
            int low = 0;
            int high = nums[N - 1];
            int answer = 0;
            while (low <= high)
            {
                int baseNum = (low + high) / 2;
                long sum = 0;
                foreach (int num in nums)
                {
                    sum += Math.Min(num, baseNum);
                }

                if (sum <= M)
                {
                    answer = baseNum;
                    low = baseNum + 1;
                }
                else
                {
                    high = baseNum - 1;
                }
            }
            Console.WriteLine(answer);
        }// main
    }
}