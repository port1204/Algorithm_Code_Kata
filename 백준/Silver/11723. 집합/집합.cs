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
                HashSet<int> S = new HashSet<int>();
                StringBuilder sb = new StringBuilder();
                int M = int.Parse(sr.ReadLine());
                for (int i = 0; i < M; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    if (input[0] == "add")
                    {
                        S.Add(int.Parse(input[1]));
                    }
                    else if (input[0] == "remove")
                    {
                        S.Remove(int.Parse(input[1]));
                    }
                    else if (input[0] == "check")
                    {
                        if (S.Contains(int.Parse(input[1])))
                        {
                            sb.AppendLine("1");
                        }
                        else
                        {
                            sb.AppendLine("0");
                        }
                    }
                    else if (input[0] == "toggle")
                    {
                        if (S.Contains(int.Parse(input[1])))
                        {
                            S.Remove(int.Parse(input[1]));
                        }
                        else
                        {
                            S.Add(int.Parse(input[1]));
                        }
                    }
                    else if (input[0] == "all")
                    {
                        for (int j = 1; j <= 20; ++j)
                        {
                            S.Add(j);
                        }
                    }
                    else if (input[0] == "empty")
                    {
                        S.Clear();
                    }
                }

                sw.WriteLine(sb);
            }

        }

    }
}