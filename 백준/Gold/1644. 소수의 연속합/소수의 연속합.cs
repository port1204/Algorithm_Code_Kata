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

                List<int> primes = GetPrimes(N);

                int count = 0;
                int start = 0, end = 0, sum = 0;

                while (true)
                {
                    if (sum >= N)
                    {
                        if (sum == N)
                        {
                            count++;
                        }
                        sum -= primes[start++];
                    }
                    else
                    {
                        if (end == primes.Count)
                            break;
                        sum += primes[end++];
                    }
                }

                sw.WriteLine(count);
            }
        }

        static List<int> GetPrimes(int n)
        {
            bool[] isPrime = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i * i <= n; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            List<int> primes = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

    }
}