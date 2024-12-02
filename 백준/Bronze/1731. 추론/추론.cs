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
                long[] longs = new long[N];
                long[] longss = new long[N - 1];
                longs[0] = long.Parse(sr.ReadLine());
                for (int i = 1; i < N; i++)
                {
                    longs[i] = long.Parse(sr.ReadLine());
                    longss[i - 1] = longs[i] - longs[i - 1];
                }

                if (longss[0] == longss[1])
                {
                    sw.WriteLine(longs[N - 1] + longss[0]);
                }
                else
                {
                    sw.WriteLine(longs[N - 1] * (longss[1] / longss[0]));
                }
            } // using
        } // Main
    } // class
} // namespace