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
                int A = int.Parse(input[0]);
                int B = int.Parse(input[2]);
                int C = int.Parse(input[4]);
                if (A + B == C)
                {
                    sw.WriteLine("YES");
                }
                else
                {
                    sw.WriteLine("NO");
                }



            } // using
        } // Main
    } // class
} // namespace