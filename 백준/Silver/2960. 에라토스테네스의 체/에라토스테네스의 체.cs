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
                
                List<int> nums = new List<int>();
                for (int i = 2; i <= N; ++i)
                {
                    nums.Add(i);
                }

                int count = 0;
                while (0 < nums.Count)
                {
                    int P = nums[0];

                    for (int j = 0; j < nums.Count; ++j)
                    {
                        if (nums[j] % P == 0)
                        {
                            ++count;
                            int R = nums[j];
                            nums.RemoveAt(j);
                            --j;

                            if (count == K)
                            {
                                sw.WriteLine(R);
                                return;
                            }
                        }
                    }
                }
            }
        }


    }
}