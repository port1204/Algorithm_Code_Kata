using System.ComponentModel;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);
            int[] Coins = new int[N];
            int answer = 0;

            for (int i = 0; i < N; ++i)
            {
                Coins[i] = int.Parse(Console.ReadLine());
                if (Coins[i] >= K) break;
            }

            Array.Sort(Coins);
            Array.Reverse(Coins);

            for (int i = 0; i < N; ++i)
            {
                while (Coins[i] <= K)
                {
                    K -= Coins[i];
                    ++answer;
                }

                if (K == 0) break;
            }

            Console.WriteLine(answer);
        }
    }
}
