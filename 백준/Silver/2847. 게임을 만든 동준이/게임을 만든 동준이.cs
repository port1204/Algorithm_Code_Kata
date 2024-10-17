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
                int[] score = new int[N];
                for (int i = 0; i < N; ++i)
                {
                    score[i] = int.Parse(sr.ReadLine());
                }

                for (int i = N - 1; i > 0; --i)
                {
                    if (score[i] <= score[i - 1])
                    {
                        int a = score[i] - 1;
                        count += score[i - 1] - a;
                        score[i - 1] = a;
                    }
                }

                sw.WriteLine(count);
            }
        }

    }
}