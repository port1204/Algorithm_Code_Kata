namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int maxN = 1000000; // 문제 조건에 따라 적절히 설정
                bool[] isPrime = new bool[maxN + 1];
                SieveOfEratosthenes(isPrime, maxN);

                int T = int.Parse(sr.ReadLine());
                for (int i = 0; i < T; ++i)
                {
                    int N = int.Parse(sr.ReadLine());
                    int count = 0;
                    for (int j = 1; j <= N / 2; ++j)
                    {
                        if (isPrime[j] && isPrime[N - j])
                        {
                            ++count;
                        }
                    }
                    sw.WriteLine(count); 
                }

            }
        }

        static void SieveOfEratosthenes(bool[] isPrime, int maxN)
        {
            for (int i = 2; i <= maxN; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i * i <= maxN; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= maxN; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }
        }

    }
}