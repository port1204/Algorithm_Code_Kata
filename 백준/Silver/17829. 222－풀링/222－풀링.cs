namespace testcoding
{
    internal class Program
    {
        static int[,] map;

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                map = new int[N, N]; 
                for (int i = 0; i < N; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    for (int j = 0; j < N; ++j)
                    {
                        map[i, j] = int.Parse(input[j]);
                    }
                }

                sw.WriteLine(Pooling(0, 0, N));
            }

            static int Pooling(int x, int y, int size)
            {
                if (size == 2)
                {
                    return SecondNum(x, y);
                }

                int newSize = size / 2;
                int[] nums = new int[4];

                nums[0] = Pooling(x, y, newSize);
                nums[1] = Pooling(x, y + newSize, newSize);
                nums[2] = Pooling(x + newSize, y, newSize);
                nums[3] = Pooling(x + newSize, y + newSize, newSize);

                Array.Sort(nums);
                return nums[2];
            }

            static int SecondNum(int x, int y)
            {
                List<int> list = new List<int>();
                for (int i = 0; i < 2; ++i)
                {
                    for (int j = 0; j < 2; ++j)
                    {
                        list.Add(map[x + i, y + j]);
                    }
                }
                list.Sort();
                return list[2];
            }
        }


    }
}