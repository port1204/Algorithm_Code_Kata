namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                float N = float.Parse(sr.ReadLine());
                sw.WriteLine(N/4);

            } // using
        } // Main
    } // class
} // namespace