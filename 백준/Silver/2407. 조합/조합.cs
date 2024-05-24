using System.Text;
using System.Numerics;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            BigInteger answer = 1;
            for (int i = 0; i < M; ++i)
            {
                answer *= (N - i);
                answer /= (i + 1);
            }
            sb.Append(answer);
            Console.Clear();
            Console.WriteLine(sb.ToString());
        }//Main
    }
}