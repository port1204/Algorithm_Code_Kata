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
                int count = 0;
                if (N < 6)
                {
                    sw.WriteLine(0);
                    return;
                }

                for (int i = 1; i <  N / 2; i++)
                {
                    count += ((N - (i * 2)) / 2) - 1;
                }

                sw.WriteLine(count);

            } // using
        } // Main
    } // class
} // namespace