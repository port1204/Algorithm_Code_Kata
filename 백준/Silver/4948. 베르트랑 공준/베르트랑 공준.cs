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
                while (true)
                {
                    int N = int.Parse(sr.ReadLine());
                    if (N == 0) break;

                    int count = 0;
                    for (int i = N + 1; i <= N * 2; ++i)
                    {
                        if (IsPrime(i))
                        {
                            ++count;
                        }
                    }
                    sb.AppendLine(count.ToString());
                }
                sw.WriteLine(sb.ToString());
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