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
                string[] input = sr.ReadLine().Split();
                BigInteger A = BigInteger.Parse(input[0]);
                BigInteger B = BigInteger.Parse(input[1]);
                BigInteger anaswer = A / B;
                sw.Write(anaswer);
                sw.Write('.');
                A %= B;
                int p = 1100;
                for (int i = 0; i < p; i++)
                {
                    A *= 10;
                    BigInteger d = A / B;
                    sw.Write(d);
                    A %= B;
                    if (A == 0)
                        break;
                }

            } // using
        } // Main
    } // class
} // namespace