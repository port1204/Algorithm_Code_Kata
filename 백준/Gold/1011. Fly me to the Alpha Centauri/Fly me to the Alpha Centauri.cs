namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int T = int.Parse(sr.ReadLine());
                for (int i = 0; i < T; i++)
                {
                    long[] input = Array.ConvertAll(sr.ReadLine().Split(), long.Parse);

                    long max = 0;
                    long r = 0;
                    long sum = 0;

                    while (sum < (input[1] - input[0]))
                    {
                        r++;
                        max = (r + 1) / 2;
                        sum += max;
                    }

                    sw.WriteLine(r);
                }
            } // using
        } // Main
    } // class
} // namespace