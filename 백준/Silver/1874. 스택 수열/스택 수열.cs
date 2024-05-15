using System;
using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); 
            int N = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            int[] nums = new int[N];
            int a = 1;

            for (int i = 0; i < N; ++i)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            foreach (int num in nums)
            {
                while (a <= num)
                {
                    stack.Push(a);
                    sb.AppendLine("+");
                    ++a;
                }

                if (stack.Peek() == num)
                {
                    stack.Pop();
                    sb.AppendLine("-");
                }
                else
                {
                    sb.Clear();
                    sb.AppendLine("NO");
                    break;
                }
            }

            Console.Clear();
            Console.WriteLine(sb);
          
        }//main
    }
}