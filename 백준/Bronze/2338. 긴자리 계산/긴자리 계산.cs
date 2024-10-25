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
                string input = sr.ReadLine();
                BigInteger A = BigInteger.Parse(input);
                input = sr.ReadLine();
                BigInteger B = BigInteger.Parse(input);
                sw.WriteLine(A + B);
                sw.WriteLine(A - B);
                sw.WriteLine(A * B);
            }
        }


    }
}