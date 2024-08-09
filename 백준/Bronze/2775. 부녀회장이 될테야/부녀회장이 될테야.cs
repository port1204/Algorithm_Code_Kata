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
                    int k = int.Parse(sr.ReadLine());
                    int n = int.Parse(sr.ReadLine());
                    int[] p = new int[n + 1];
                    for (int j = 1; j <= n; ++j)
                    {
                        p[j] = j;
                    }

                    for (int j = 1; j <= k; ++j)
                    {
                        for (int l = 1; l <= n; ++l)
                        {
                            p[l] += p[l - 1];
                        }
                    }

                    sw.WriteLine(p[n]);
                }
            }
        }


    }
}