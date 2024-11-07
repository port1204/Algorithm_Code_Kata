namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                for (int i = 0; i < 3; i++)
                {
                    int[] A = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    int H = A[3] - A[0];
                    int M = A[4] - A[1];
                    int S = A[5] - A[2];
                    if (S < 0)
                    {
                        S += 60;
                        --M;
                    }

                    if (M < 0)
                    {
                        M += 60;
                        --H;
                    }
                    sw.WriteLine($"{H} {M} {S}");
                }


            } // using
        } // Main
    } // class
} // ns
