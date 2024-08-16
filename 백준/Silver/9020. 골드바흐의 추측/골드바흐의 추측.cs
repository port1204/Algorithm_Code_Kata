using System.Text;

namespace testcoding
{
    internal class Program
    {
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int T = int.Parse(sr.ReadLine());
                for (int i = 0; i < T; ++i)
                {
                    int N = int.Parse(sr.ReadLine());
                    for (int j = N / 2; j <= N; ++j)
                    {
                        if (IsPrime(j) && IsPrime(N - j))
                        {
                            sb.AppendLine($"{N - j} {j}");
                            break;
                        }
                    }
                }
                sw.WriteLine( sb.ToString() );
            }
        }


        static bool IsPrime(int n) // 소수
        {
            if (n <= 1)
                return false;

            if (n == 2)
            {
                return true;
            }

            if (n % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}