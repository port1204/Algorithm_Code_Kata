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
                BigInteger N = BigInteger.Parse(sr.ReadLine());
                sw.WriteLine(N % 20000303);


            } // using
        } // Main


    }
}