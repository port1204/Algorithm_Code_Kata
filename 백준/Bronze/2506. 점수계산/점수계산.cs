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
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int score = 0;
                int current = 0;
                for (int i = 0; i < N; ++i)
                {
                    if (input[i] == 1)
                    {
                        ++current;
                        score += current;
                    }
                    else
                    {
                        current = 0;
                    }
                }
                sw.WriteLine(score);

            } // using
        } // Main


    }
}