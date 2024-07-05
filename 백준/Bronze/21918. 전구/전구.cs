namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            int[] s = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int i = 0; i < M; ++i)
            {
                string[] nums = Console.ReadLine().Split();
                int a = int.Parse(nums[0]);
                int b = int.Parse(nums[1]);
                int c = int.Parse(nums[2]);
                if (a == 1)
                {
                    s[b - 1] = c;
                }
                else if(a == 2)
                {
                    for (int j = b - 1; j < c; ++j)
                    {
                        if (s[j] == 0)
                            s[j] = 1;
                        else
                            s[j] = 0;
                    }
                }
                else if (a == 3)
                {
                    for (int j = b - 1; j < c; ++j)
                    {
                        s[j] = 0;
                    }
                }
                else if (a == 4)
                {
                    for (int j = b - 1; j < c; ++j)
                    {
                        s[j] = 1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", s));
        }
    }
}