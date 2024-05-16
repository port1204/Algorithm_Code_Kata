using System;
using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); 
            string N = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            //int num = 0;
            int nums = 0;

            for (int i = 0; i < N.Length; ++i)
            {
                if (N[i] == '(')
                {
                    //++num;
                    stack.Push(N[i]);
                }
                else if (N[i] == ')' && stack.Count != 0)
                {
                    stack.Pop();
                    if (N[i-1] == '(')
                    {
                        //nums += num;
                        nums += stack.Count;
                    }
                    else
                    {
                        ++nums;
                    }
                }
            }
            sb.Append(nums);
            Console.Clear();
            Console.WriteLine(sb);
          
        }//main
    }
}