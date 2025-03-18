namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                while (true)
                { 
                    double N = double.Parse(sr.ReadLine());
                    if (N == -1.0)
                    {
                        break;
                    }
                    sw.WriteLine($"Objects weighing {N:F2} on Earth will weigh {(N * 0.167):F2} on the moon.");
                }

            } // using
        } // Main
    } // class
} // namespace