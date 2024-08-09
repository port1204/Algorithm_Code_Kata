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
                HashSet<string> S = new HashSet<string>();
                string[] input = sr.ReadLine().Split();
                int N = int.Parse(input[0]);
                int M = int.Parse(input[1]);

                for (int i = 0; i < N; ++i)
                {
                    string name = sr.ReadLine();
                    S.Add(name);
                }

                int count = 0;
                List<string> answer = new List<string>();
                for (int i = 0; i  < M; ++i)
                {
                    string name = sr.ReadLine();
                    if (S.Contains(name))
                    {
                        answer.Add(name);
                        ++count;
                    }
                }
                answer.Sort();
                sw.WriteLine(count);
                foreach (string s in answer)
                {
                    sw.WriteLine(s);
                }
            }

        }

    }
}