using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int TC = int.Parse(Console.ReadLine());
            for (int i = 0; i < TC; ++i)
            {
                string[] input = Console.ReadLine().Split();
                int N = int.Parse(input[0]);
                int M = int.Parse(input[1]);
                long answer = 1;
                for (int j = 0; j < N; ++j)
                {
                    answer *= (M - j);
                    answer /= (j + 1);
                }
                sb.AppendLine($"{answer}");
            }

            Console.Clear();
            Console.WriteLine(sb.ToString());

        }//main
    }
}