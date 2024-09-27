using System.Linq;

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
                long answer = 1;
                for (int i = 0; i < N; ++i)
                {
                    answer += answer * i;
                }
                sw.WriteLine(answer);
            }
        }

    }
}