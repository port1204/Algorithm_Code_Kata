namespace testcoding
{
    internal class Program
    {
        static int fibo = 0;
        static int dp = 0;

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                fib(N);
                fibonacci(N);
                sw.WriteLine($"{fibo} {dp}");
            }
        }

        static int fib(int n)
        {
            if (n == 1 || n == 2)
            {
                ++fibo;
                return 1;
            }
            else
            {
                return fib(n - 1) + fib(n - 2);
            }
        }

        static int fibonacci(int n)
        {
            int[] f = new int[n + 1];
            f[1] = f[2] = 1;
            for (int i = 3; i <= n; ++i)
            {
                f[i] = f[i - 1] + f[i - 2];
                ++dp;
            }
            return f[n];
        }
    }
}