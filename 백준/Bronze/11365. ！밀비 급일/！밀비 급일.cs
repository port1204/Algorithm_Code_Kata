namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                foreach (char c in input)
                {
                    stack.Push(c);
                }

                while (stack.Count > 0)
                {
                    Console.Write(stack.Pop());
                }

                Console.WriteLine();
            }
        }
    }
}
