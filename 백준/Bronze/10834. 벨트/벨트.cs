using System.Numerics;

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

                BigInteger numerator = 1;
                BigInteger denominator = 1;
                int direction = 0;

                for (int i = 0; i < N;  i++)
                {
                    string[] input = sr.ReadLine().Split();
                    int a = int.Parse(input[0]);
                    int b = int.Parse(input[1]);
                    int c = int.Parse(input[2]);

                    numerator *= b;
                    denominator *= a;

                    if (c == 1)
                    {
                        direction ^= 1;
                    }

                    BigInteger gcd = BigInteger.GreatestCommonDivisor(numerator, denominator);
                    numerator /= gcd;
                    denominator /= gcd;
                }

                sw.WriteLine($"{direction} {numerator / denominator}");
            } // using
        } // Main
    } // class
} // namespace