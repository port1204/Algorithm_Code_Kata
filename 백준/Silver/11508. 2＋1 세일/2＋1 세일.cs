using System.ComponentModel;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] PriceS = new int[N];
            int count = 0;
            int answer = 0;

            for (int i = 0; i < N; ++i)
            {
                int Price = int.Parse(Console.ReadLine());
                PriceS[i] = Price;
            }

            Array.Sort(PriceS);
            Array.Reverse(PriceS);

            foreach (int i in PriceS)
            {
                ++count;
                if (count != 3)
                {
                    answer += i;
                }
                else
                {
                    count = 0;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
