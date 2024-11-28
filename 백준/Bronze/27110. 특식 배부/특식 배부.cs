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
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int sum = 0;

                if (input[0] >= N)
                {
                    sum += N;
                }
                else
                {
                    sum += input[0];
                }

                if (input[1] >= N)
                {
                    sum += N;
                }
                else
                {
                    sum += input[1];
                }

                if (input[2] >= N)
                {
                    sum += N;
                }
                else
                {
                    sum += input[2];
                }

                sw.WriteLine(sum);
            } // using
        } // Main
    } // class
} // namespace