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
                List<(int, int)> lines = new List<(int, int)>();
                for (int i = 0; i < N; i++)
                {
                    string[] input = sr.ReadLine().Split();
                    int a = int.Parse(input[0]);
                    int b = int.Parse(input[1]);
                    lines.Add((a, b));
                }

                lines.Sort();

                List<int> dp = new List<int>();

                foreach (var (_, b) in lines)
                {
                    int pos = dp.BinarySearch(b);
                    if (pos < 0) pos = ~pos;

                    if (pos == dp.Count)
                        dp.Add(b);
                    else
                        dp[pos] = b;
                }

                sw.WriteLine(N - dp.Count);

            } // using
        } // Main
    } // class
} // namespace