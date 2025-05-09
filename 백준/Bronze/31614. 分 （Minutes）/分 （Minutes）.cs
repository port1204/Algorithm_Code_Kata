namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int H = int.Parse(sr.ReadLine());
                int M = int.Parse(sr.ReadLine());
                sw.WriteLine((H * 60) + M);

            } // using
        } // Main
    } // class
} // namespace