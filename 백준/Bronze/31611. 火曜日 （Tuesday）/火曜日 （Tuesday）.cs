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
                if (N == 2 || (N > 7  && (N - 2) % 7 == 0))
                {
                    sw.WriteLine(1);
                }
                else
                {
                    sw.WriteLine(0);
                }



            } // using
        } // Main
    } // class
} // namespace