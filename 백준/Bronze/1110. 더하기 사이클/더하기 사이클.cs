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
                int count = 0;
                int ten = 0;
                if (N > 9)
                {
                    ten = (N / 10);
                }
                int one = (N % 10);
                int sum = ten + one;
                while (true)
                {
                    ++count;
                    int newsum = (one * 10) + (sum % 10);
                    if (newsum == N)
                        break;
                    ten = (newsum / 10);
                    one = (newsum % 10);
                    sum = ten+ one;
                }
                sw.WriteLine(count);
            }
        }


    }
}