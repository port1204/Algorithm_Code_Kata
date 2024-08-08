namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int N = int.Parse(sr.ReadLine());
                int answer = 0;
                for (int i = Math.Max(0, N - 54); i < N; ++i)
                {
                    if (i + DigitSum(i) == N)
                    {
                        answer = i;
                        break;
                    }
                }
                sw.WriteLine(answer);
            }
        }

        static int DigitSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}