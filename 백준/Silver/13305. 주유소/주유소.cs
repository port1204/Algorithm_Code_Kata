using System.ComponentModel;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            int N = int.Parse(Console.ReadLine());
            int[] Price = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] City = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int LowCity = City[0];

            answer += City[0] * Price[0];

            for (int i = 1; i < N - 1; ++i)
            {
                if (LowCity < City[i])
                {
                    answer += LowCity * Price[i];
                }
                else
                {
                    LowCity = City[i];
                    answer += City[i] * Price[i];
                }
            }

            Console.WriteLine(answer);
        }
    }
}
