namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                string[] input = sr.ReadLine().Split();
                int N = int.Parse(input[0]);
                int K = int.Parse(input[1]);

                long result = CalculateBinomialCoefficient(N, K);
                sw.WriteLine(result);
            }
        }

        static long CalculateBinomialCoefficient(int n, int k)
        {
            if (k > n - k)
            {
                k = n - k; 
            }

            long result = 1;
            for (int i = 0; i < k; i++)
            {
                result *= (n - i);
                result /= (i + 1);
            }
            return result;
        }

    }
}