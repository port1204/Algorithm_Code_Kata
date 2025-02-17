namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int T = int.Parse(sr.ReadLine());
                for (int  i = 0; i < T; i++)
                {
                    sr.ReadLine();

                    long num = 0;
                    long N = long.Parse(sr.ReadLine());

                    for (int j = 0; j < N; j++)
                    {
                        num = (num + long.Parse(sr.ReadLine())) % N;
                    }

                    if (num == 0)
                    {
                        sw.WriteLine("YES");
                    }
                    else
                    {
                        sw.WriteLine("NO");
                    }
                }

            } // using
        } // Main
    } // class
} // namespace