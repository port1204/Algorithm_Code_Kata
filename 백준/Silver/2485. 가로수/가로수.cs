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
                long[] trees = new long[N];
                long[] btw = new long[N - 1];
                long answer = 0;
                for (int i = 0; i < N; ++i)
                {
                    trees[i] = long.Parse(sr.ReadLine());
                }

                for (int i = 0; i < N - 1; ++i)
                {
                    btw[i] = trees[i + 1] - trees[i];
                }

                long gcd = btw[0];
                for (int i = 1; i < btw.Length; ++i)
                {
                    gcd = GCD(gcd, btw[i]);
                }

                for (int i = 0; i < btw.Length; i++)
                {
                    answer += (btw[i] / gcd) - 1;
                }

                sw.WriteLine(answer);
            }
        }

        static long GCD(long a, long b) // 최대공약수
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static long LCM(long a, long b) // 최소공배수
        {
            return a * (b / GCD(a, b));
        }
    }
}