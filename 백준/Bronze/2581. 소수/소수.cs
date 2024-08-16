namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int M = int.Parse(sr.ReadLine());
                int N = int.Parse(sr.ReadLine());

                int sum = 0;
                int min = 0;
                bool Ismin = false;
                for (int i = M; i <= N; ++i)
                {
                    if (IsPrime(i))
                    {
                        if (!Ismin)
                        {
                            min = i;
                            Ismin = true;
                        }
                        sum += i;
                    }
                }

                if (Ismin)
                {
                    sw.WriteLine(sum);
                    sw.WriteLine(min);
                }
                else
                {
                    sw.WriteLine(-1);
                }
            }
        }

        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            if (n == 2)
                return true;

            if (n % 2 == 0)
                return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}