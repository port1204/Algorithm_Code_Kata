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
                int N = int.Parse(sr.ReadLine());
                Queue<int> q = new Queue<int>();
                for (int i = 0; i < N; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    if (input[0] == "push")
                    {
                        q.Enqueue(int.Parse(input[1]));
                    }
                    else if (input[0] == "pop")
                    {
                        if (q.Count() > 0)
                        {
                            sb.AppendLine($"{q.Dequeue()}");
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                            
                    }
                    else if (input[0] == "size")
                    {
                        sb.AppendLine($"{q.Count()}");
                    }
                    else if (input[0] == "empty")
                    {
                        if (q.Count() > 0)
                        {
                            sb.AppendLine("0");
                        }
                        else
                        {
                            sb.AppendLine("1");
                        }
                    }
                    else if (input[0] == "front")
                    {
                        if (q.Count() > 0)
                        {
                            sb.AppendLine($"{q.First()}");
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                    }
                    else if (input[0] == "back")
                    {
                        if (q.Count() > 0)
                        {
                            sb.AppendLine($"{q.Last()}");
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                    }
                }
                sw.WriteLine(sb);
            }
        }
    }
}