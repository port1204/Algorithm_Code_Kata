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
                for (int i = 0; i < T; ++i)
                {
                    int N = int.Parse(sr.ReadLine());
                    int[] coins = new int[4];
                    while (N > 0)
                    {
                        if (N >= 25)
                        {
                            N -= 25;
                            ++coins[0];
                        }
                        else if (N >= 10)
                        {
                            N -= 10;
                            ++coins[1];
                        }
                        else if (N >= 5)
                        {
                            N -= 5;
                            ++coins[2];
                        }
                        else if (N >= 1)
                        {
                            N -= 1;
                            ++coins[3];
                        }
                    }
                    sw.WriteLine(string.Join(" ", coins));
                }
            }
        }
    }
}