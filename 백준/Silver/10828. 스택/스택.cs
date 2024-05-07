namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Stack<int> MyStack = new Stack<int>();
            List<string> Answer = new List<string>();

            for (int i = 0; i < N; ++i)
            {
                string[] input = Console.ReadLine().Split(" ");

                if (input[0] == "push")
                {
                    int X = int.Parse(input[1]);
                    MyStack.Push(X); 
                }
                else if (input[0] == "pop")
                {
                    if (MyStack.Count == 0)
                    {
                        Answer.Add("-1");
                    }
                    else
                    {
                        Answer.Add(MyStack.Pop().ToString());
                    }
                }
                else if (input[0] == "size")
                {
                        Answer.Add(MyStack.Count.ToString());
                }
                else if (input[0] == "empty")
                {
                    if (MyStack.Count == 0)
                    {
                        Answer.Add("1");
                    }
                    else
                    {
                        Answer.Add("0");
                    }
                }
                else if (input[0] == "top")
                {
                    if (MyStack.Count == 0)
                    {
                        Answer.Add("-1");
                    }
                    else
                    {
                        Answer.Add(MyStack.Peek().ToString());
                    }
                }
            }

            Console.Clear();

            foreach (var answer in Answer)
            {
                Console.WriteLine(answer);
            }
        }
    }
}
