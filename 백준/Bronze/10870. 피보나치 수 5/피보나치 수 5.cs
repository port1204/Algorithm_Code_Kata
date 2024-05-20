using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int[] F = new int[N+2];
            F[0] = 0;
            F[1] = 1;
            for (int i = 2; i <= N; ++i)
            {
                F[i] = F[i -1] + F[i - 2];
            }
            sb.AppendLine($"{F[N]}");
            Console.Clear();
            Console.WriteLine(sb.ToString());

        }//main
    }
}