namespace testcoding
{
    internal class Program
    {
        static int max = int.MinValue;
        static int min = int.MaxValue;
        static int N;
        static int[] nums;
        static int[] rlgh;
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                N = int.Parse(sr.ReadLine());
                nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                rlgh = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                Calculation(1, nums[0]);

                sw.WriteLine(max);
                sw.WriteLine(min);
            }
        }

        static void Calculation(int index, int v)
        {
            if (index == N)
            {
                max = Math.Max(max, v);
                min = Math.Min(min, v);
                return;
            }

            for (int i = 0; i < 4; ++i)
            {
                if (rlgh[i] > 0)
                {
                    --rlgh[i];
                    if (i == 0)
                    {
                        Calculation(index + 1, v + nums[index]);
                    }
                    else if(i == 1)
                    {
                        Calculation(index + 1, v - nums[index]);
                    }
                    else if (i == 2)
                    {
                        Calculation(index + 1, v * nums[index]);
                    }
                    else if (i == 3)
                    {
                        Calculation(index + 1, v / nums[index]);
                    }
                    ++rlgh[i];
                }
            }
        }

    }
}