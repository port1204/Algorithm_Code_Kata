namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                long N;
                long sum = 0;
                while (true)
                {
                    N = long.Parse(sr.ReadLine());
                    if (N == -1)
                    {
                        break;
                    }

                    sum += N;
                }

                sw.WriteLine(sum);

            }
        }
    }
}
