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
                int T = int.Parse(sr.ReadLine());
                for (int i = 0; i < T; i++)
                {
                    string[] input = sr.ReadLine().Split();
                    BigInteger A = BigInteger.Parse(input[0]);
                    BigInteger B = BigInteger.Parse(input[1]);
                    sw.WriteLine(A + B);
                }

            } // using
        } // Main
    } // class
} // ns
