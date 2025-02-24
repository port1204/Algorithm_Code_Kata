namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int A = int.Parse(sr.ReadLine());
                int B = int.Parse(sr.ReadLine());
                if (A < B)
                {
                    sw.WriteLine(-1);
                }
                else if (A == B)
                {
                    sw.WriteLine(0);
                }
                else
                {
                    sw.WriteLine(1);
                }

            } // using
        } // Main
    } // class
} // namespace