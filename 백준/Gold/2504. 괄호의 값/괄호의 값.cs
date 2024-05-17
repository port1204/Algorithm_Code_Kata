using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); 
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            int count = 0;
            int mul = 1;
            int sum = 0;
            bool isMade = true;

            foreach (char c in input)
            {
                if (c == '(')
                {
                    stack.Push(c);
                    mul *= 2;
                }
                else if (c == ')')
                {
                    if (stack.Count == 0 || stack.Peek() != '(')
                    {
                        isMade = false;
                        break;
                    }

                    if(input[count - 1] == '(')
                    {
                        sum += mul;
                    }
                    stack.Pop();
                    mul /= 2;
                }
                else if (c == '[')
                {
                    stack.Push(c);
                    mul *= 3;
                }
                else if (c == ']')
                {
                    if (stack.Count == 0 || stack.Peek() != '[')
                    {
                        isMade = false;
                        break;
                    }

                    if (input[count - 1] == '[')
                    {
                        sum += mul;
                    }
                    stack.Pop();
                    mul /= 3;
                }
                ++count;
            }

            if (stack.Count != 0 || !isMade)
            {
                sb.Append("0");
            }
            else
            {
                sb.Append(sum);
            }

            Console.Clear();
            Console.WriteLine(sb.ToString());

        }//main
    }
}