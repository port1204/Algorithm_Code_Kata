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
                long R = long.Parse(input[0]);
                long C = long.Parse(input[1]);
                long N = long.Parse(input[2]);
                long H = 0, W = 0;
                if (R % N == 0)
                {
                    H += R / N;
                }
                else
                {
                    H += R / N;
                    ++H;
                }

                if (C % N == 0)
                {
                    W += C / N;
                }
                else
                {
                    W += C / N;
                    ++W;
                }
                sw.WriteLine(H * W);
            } // using
        } // Main
    } // class
} // namespace