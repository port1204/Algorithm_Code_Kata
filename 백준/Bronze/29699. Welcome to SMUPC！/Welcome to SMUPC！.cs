namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string line = "WelcomeToSMUPC";
                int N = int.Parse(sr.ReadLine());
                N  = (N - 1) % 14;
                sw.WriteLine(line[N]);

            } // using
        } // Main
    } // class
} // namespace