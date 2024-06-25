namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] tip = new long[N];
            long answer = 0;

            for (int i = 0; i < N; ++i)
            {
                tip[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(tip);
            Array.Reverse(tip);

            for (int i = 0; i < N; ++i)
            {
                if (tip[i] - (i - 1) > 0)
                {
                    answer += tip[i] - i;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
