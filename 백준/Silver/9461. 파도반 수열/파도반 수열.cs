namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int T = int.Parse(sr.ReadLine());

                for (int i = 0; i < T; ++i)
                {
                    int n = int.Parse(sr.ReadLine());
                    long[] P = new long[101];
                    P[1] = 1;
                    P[2] = 1;
                    P[3] = 1;
                    P[4] = 2;
                    P[5] = 2;
                    P[6] = 3;
                    for (int j = 7; j <= n; ++j)
                    {
                        P[j] = P[j - 1] + P[j - 5];
                    }

                    sw.WriteLine(P[n]);
                }

            }

        }


    }
}