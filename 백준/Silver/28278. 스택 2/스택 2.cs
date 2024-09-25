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
                Stack<int> stack = new Stack<int>();
                for (int i = 0; i < N; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    int num = int.Parse(input[0]);
                    if (num == 1)
                    {
                        stack.Push(int.Parse(input[1]));
                    }
                    else if (num == 2)
                    {
                        if (stack.Count > 0)
                        {
                            sw.WriteLine(stack.Pop());
                        }
                        else
                        {
                            sw.WriteLine(-1);
                        }
                    }
                    else if (num == 3)
                    {
                        sw.WriteLine(stack.Count);
                    }
                    else if (num == 4)
                    {
                        if (stack.Count == 0)
                        {
                            sw.WriteLine(1);
                        }
                        else
                        {
                            sw.WriteLine(0);
                        }
                    }
                    else if (num == 5)
                    {
                        if (stack.Count > 0)
                        {
                            sw.WriteLine(stack.Peek());
                        }
                        else
                        {
                            sw.WriteLine(-1);
                        }
                    }
                }

            }
        }

    }
}