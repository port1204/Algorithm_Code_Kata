namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] nums = new bool[31];
            int count = 0;
            for (int i = 0; i < 28; ++i)
            {
                int num = int.Parse(Console.ReadLine());
                nums[num] = true;
            }

            for (int i = 1; i <= 30; ++i)
            {
               if (!nums[i])
                {
                    Console.WriteLine(i);
                    ++count;
                    if (count == 2) break;
                }
            }
        }
    }
}