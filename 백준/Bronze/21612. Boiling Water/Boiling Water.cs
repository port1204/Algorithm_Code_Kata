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
                int P = (N * 5) - 400;
                sw.WriteLine(P);
                if (P > 100)
                {
                    sw.WriteLine(-1);
                }
                else if (P == 100)
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