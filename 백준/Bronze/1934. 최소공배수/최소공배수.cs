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
                    int num = 2;
                    string[] input = sr.ReadLine().Split();
                    int A = int.Parse(input[0]);
                    int B = int.Parse(input[1]);

                    int lcm = LCM(A, B);
                    sb.AppendLine(lcm.ToString());
                }
                sw.WriteLine(sb.ToString());
            }
        }


        static bool IsPrime(int n)
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

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int LCM(int a, int b)
        {
            return a * (b / GCD(a, b));
        }
    }
}