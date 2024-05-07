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

                switch (input[0])
                {
                    case "push":
                        int X = int.Parse(input[1]);
                        MyStack.Push(X);
                        break;
                    case "pop":
                        if (MyStack.Count == 0)
                        {
                            Answer.Add("-1");
                        }
                        else
                        {
                            Answer.Add(MyStack.Pop().ToString());
                        }
                        break;
                    case "size":
                        Answer.Add(MyStack.Count.ToString());
                        break;
                    case "empty":
                        if(MyStack.Count == 0)
                        {
                            Answer.Add("1");
                        }
                        else
                        {
                            Answer.Add("0");
                        }
                        break;
                    case "top":
                        if (MyStack.Count == 0)
                        {
                            Answer.Add("-1");
                        }
                        else
                        {
                            Answer.Add(MyStack.Peek().ToString());
                        }
                        break;
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
