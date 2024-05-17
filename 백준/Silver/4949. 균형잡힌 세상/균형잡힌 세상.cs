using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); 
            Stack<char> stack = new Stack<char>();
            string input;
            do
            {
                input = Console.ReadLine();
                foreach (char c in input)
                {
                    if (c == '.')
                    {
                        if (input[0] == '.')
                        {
                            break;
                        }
                        else if(stack.Count != 0)
                        {
                            sb.AppendLine("no");
                            break;
                        }
                        else
                        {
                            sb.AppendLine("yes");
                            break;
                        }
                    }
                    else if (c == '(' || c == '[')
                    {
                        stack.Push(c);
                    }
                    else if (c == ')')
                    {
                        if (stack.Count == 0 || stack.Peek() != '(')
                        {
                            sb.AppendLine("no");
                            break;
                        }
                        else
                        {
                            stack.Pop();
                        }
                    }
                    else if (c == ']')
                    {
                        if (stack.Count == 0 || stack.Peek() != '[')
                        {
                            sb.AppendLine("no");
                            break;
                        }
                        else
                        {
                            stack.Pop();
                        }
                    }
                }
                stack.Clear();
            } while (input[0] != '.');

            Console.Clear();
            Console.WriteLine(sb.ToString());

        }//main
    }
}