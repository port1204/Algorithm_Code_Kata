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
                for (int i = 0; i < 3; i++)
                {
                    int N = int.Parse(sr.ReadLine());
                    BigInteger sum = 0;
                    for (int j = 0; j < N; j++)
                    {
                        BigInteger A = BigInteger.Parse(sr.ReadLine());
                        sum += A;
                    }
                    if (sum > 0)
                    {
                        sw.WriteLine("+");
                    }
                    else if (sum < 0)
                    {
                        sw.WriteLine("-");
                    }
                    else if (sum == 0)
                    {
                        sw.WriteLine("0");
                    }
                }

            } // using
        } // Main
    } // class
} // ns
