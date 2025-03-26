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
                    string[] input = sr.ReadLine().Split();
                    int N = int.Parse(input[0]);
                    int D = int.Parse(input[1]);
                    int count = 0;
                    for (int j = 0; j < N; j++)
                    {
                        input = sr.ReadLine().Split();
                        float vfc = float.Parse(input[0]) * (float.Parse(input[1]) / float.Parse(input[2]));

                        if (vfc >= D)
                        {
                            ++count;
                        }
                    }
                    sw.WriteLine(count);
                }
            } // using
        } // Main
    } // class
} // namespace