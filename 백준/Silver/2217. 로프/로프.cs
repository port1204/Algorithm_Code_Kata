namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] Rope = new int[N];
            int sum = 0;
            int answer = 0;
            for (int i = 0; i < N; ++i)
            {
                Rope[i] = int.Parse(Console.ReadLine());
                sum += Rope[i];
            }

            Array.Sort(Rope);

            for (int i = 0; i < N; ++i)
            {
                sum = Rope[i] * (N - i);
                if (sum > answer)
                {
                    answer = sum;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
