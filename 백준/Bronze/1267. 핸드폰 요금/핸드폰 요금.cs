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
                int Y = N;
                int M = N;
                string[] times = sr.ReadLine().Split();
                for (int i = 0; i < N; ++i)
                {
                    int time = int.Parse(times[i]);
                    if (time > 29)
                    {
                        Y += time / 30;
                    }

                    if (time > 59)
                    {
                        M += time / 60;
                    }
                }

                if (Y * 10 == M * 15)
                {
                    sw.WriteLine($"Y M {Y * 10}");
                }
                else
                {
                    if (Y * 10 > M * 15)
                    {
                        sw.WriteLine($"M {M * 15}");
                    }
                    else
                    {
                        sw.WriteLine($"Y {Y * 10}");
                    }
                }
            }
        }


    }
}