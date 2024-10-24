namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string[] input = sr.ReadLine().Split();
                int H = int.Parse(input[0]);
                int M = int.Parse(input[1]);
                int S = int.Parse(input[2]);
                S += int.Parse(sr.ReadLine());
                if (S > 59)
                {
                    M += S / 60;
                    S %= 60;
                    if (M > 59)
                    {
                        H += M / 60;
                        M %= 60;
                        if (H > 23)
                        {
                            H %= 24;
                        }
                    }
                }
                sw.WriteLine($"{H} {M} {S}");
            }
        }


    }
}