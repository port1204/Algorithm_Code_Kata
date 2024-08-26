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
                int[] X = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                long sum = 0;
                long answer = 0;

                for (int i = 0; i < N; ++i)
                {
                    sum += X[i];
                }

                for (int i = 0; i < N; ++i)
                {
                    sum -= X[i];
                    answer += X[i] * sum;
                }

                sw.WriteLine(answer);
            }

        }
    }
}