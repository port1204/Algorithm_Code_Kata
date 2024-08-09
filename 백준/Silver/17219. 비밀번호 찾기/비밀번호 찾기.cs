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
                Dictionary<string, string> S = new Dictionary<string, string>();
                string[] input = sr.ReadLine().Split();
                int N = int.Parse(input[0]);
                int M = int.Parse(input[1]);

                for (int i = 0; i < N; ++i)
                {
                    string[] com = sr.ReadLine().Split();
                    S.Add(com[0], com[1]);
                }

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i  < M; ++i)
                {
                    string key = sr.ReadLine();
                    sb.AppendLine(S[key]);
                }

                sw.WriteLine(sb);
            }

        }

    }
}