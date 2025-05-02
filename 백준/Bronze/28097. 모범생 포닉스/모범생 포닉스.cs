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
                string[] times = sr.ReadLine().Split();
                int total = 0;
                for (int i = 0; i < N; i++)
                {
                    total += int.Parse(times[i]);
                }

                total += 8 * (N - 1);

                sw.WriteLine($"{total / 24} {total % 24}");

            } // using
        } // Main
    } // class
} // namespace