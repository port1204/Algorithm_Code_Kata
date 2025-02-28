namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                long N = long.Parse(sr.ReadLine());
                long target = N - 1;

                for (long K = 1; ; K++)
                {
                    if (K * K + K == target)
                    {
                        sw.WriteLine(K);
                        break;
                    }
                }
            } // using
        } // Main
    } // class
} // namespace