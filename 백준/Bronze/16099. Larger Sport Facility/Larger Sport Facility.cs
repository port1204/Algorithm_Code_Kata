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
                for (int i  = 0; i < T; i++)
                {
                    string[] input = sr.ReadLine().Split();
                    BigInteger a1 = BigInteger.Parse(input[0]);
                    BigInteger a2 = BigInteger.Parse(input[1]);
                    BigInteger b1 = BigInteger.Parse(input[2]);
                    BigInteger b2 = BigInteger.Parse(input[3]);

                    if (a1 * a2 > b1 * b2)
                    {
                        sw.WriteLine("TelecomParisTech");
                    }
                    else if (a1 * a2 == b1 * b2)
                    {
                        sw.WriteLine("Tie");
                    }
                    else
                    {
                        sw.WriteLine("Eurecom");
                    }
                }

            } // using
        } // Main
    } // class
} // namespace