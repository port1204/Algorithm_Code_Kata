namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string[] A = sr.ReadLine().Split(":");
                string[] B = sr.ReadLine().Split(":");
                int H = int.Parse(B[0]) - int.Parse(A[0]);
                int M = int.Parse(B[1]) - int.Parse(A[1]);
                int S = int.Parse(B[2]) - int.Parse(A[2]);

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

                if (H < 0)
                {
                    H += 24;
                }

                sw.WriteLine($"{H:00}:{M:00}:{S:00}");
            } // using
        } // Main
    } // class
} // ns
