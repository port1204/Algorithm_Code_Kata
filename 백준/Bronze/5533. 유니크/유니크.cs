namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                int[,] nums = new int[N, 3];
                int[] sum = new int[N];

                for (int i = 0; i < N; i++)
                {
                    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    for (int j = 0; j < 3; j++)
                    {
                        nums[i, j] = input[j];
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    Dictionary<int, int> dic = new Dictionary<int, int>();
                    for (int j = 0; j < N; j++)
                    {
                        int score = nums[j, i];
                        if (dic.ContainsKey(score))
                        {
                            dic[score]++;
                        }
                        else
                        {
                            dic[score] = 1;
                        }
                    }

                    for (int j = 0; j < N; j++)
                    {
                        int score = nums[j, i];
                        if (dic[score] == 1)
                        {
                            sum[j] += score;
                        }
                    }
                }

                foreach (int total in sum)
                {
                    sw.WriteLine(total);
                }

            } // using
        } // Main
    } // class
} // namespace