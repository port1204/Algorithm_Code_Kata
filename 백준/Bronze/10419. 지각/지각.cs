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
                for (int i = 0; i < T; i++)
                {
                    int N = int.Parse(sr.ReadLine());
                    for (int j = 1; j <= N; j++)
                    {
                        if (j + (j * j) > N)
                        {
                            sw.WriteLine(j - 1);
                            break;
                        }
                    }
                }
            } // using
        } // Main
    } // class
} // namespace