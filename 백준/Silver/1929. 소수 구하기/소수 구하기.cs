using System.Text;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                StringBuilder sb = new StringBuilder();
                string[] input = sr.ReadLine().Split();
                int M = int.Parse(input[0]);
                int N = int.Parse(input[1]);
                for (int i = M; i <= N; ++i)
                {
                    if (IsPrime(i))
                    {
                        sb.AppendLine($"{i}");
                    }
                }
                sw.WriteLine(sb);
            }
        }

        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            if (num == 2)
            {
                return true;
            }
            if (num % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}