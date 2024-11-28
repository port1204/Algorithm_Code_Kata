namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                double B = int.Parse(sr.ReadLine());
                double A = B / 11;
                sw.WriteLine(B - A);
            } // using
        } // Main
    } // class
} // namespace