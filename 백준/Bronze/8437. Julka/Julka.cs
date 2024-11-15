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
                BigInteger T = BigInteger.Parse(sr.ReadLine());
                BigInteger D = BigInteger.Parse(sr.ReadLine());

                sw.WriteLine((T + D) / 2);
                sw.WriteLine((T - D) / 2);

            } // using
        } // Main
    } // class
} // ns
