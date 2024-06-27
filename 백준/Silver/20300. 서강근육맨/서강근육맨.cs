namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] LostM = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long M = 0;
            long answer = 0;

            Array.Sort(LostM);

            for (int i = 0; i < N / 2; ++i)
            {
                if (N % 2 == 0)
                {
                    M = LostM[i] + LostM[N - (i + 1)];
                }
                else
                {
                    M = LostM[i] + LostM[N - (i + 2)];
                }

                if (M > answer)
                {
                    answer = M;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
