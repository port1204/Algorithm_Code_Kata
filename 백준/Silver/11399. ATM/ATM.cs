using System.ComponentModel;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] Time = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int sum = 0;
            int answer = 0;

            Array.Sort(Time);

            for (int i = 0; i < N; ++i)
            {
                sum = sum + Time[i];
                answer += sum;
            }

            Console.WriteLine(answer);
        }
    }
}
