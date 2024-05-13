namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<double> stack = new Stack<double>();
            double answer = 0;
            int N = int.Parse(Console.ReadLine());
            string ex = Console.ReadLine();
            double[] values = new double[N];

            for (int i = 0; i < N; i++)
            {
                values[i] = int.Parse(Console.ReadLine());
            }

            foreach (char c in ex)
            {
                if (char.IsLetter(c))
                {
                    int alpha = c - 'A';
                    double value = values[alpha];
                    stack.Push(value);
                }
                else
                {
                    double b = stack.Pop();
                    double a = stack.Pop();

                    if (c == '+')
                    {
                        answer = a + b;
                    }
                    else if(c == '-')
                    {
                        answer = a - b;
                    }
                    else if (c == '*')
                    {
                        answer = a * b;
                    }
                    else if (c == '/')
                    {
                        answer = a / b;
                    }

                    stack.Push(answer);
                }
            }

            answer = stack.Pop();
            Console.WriteLine($"{answer:F2}");
        }
    }
}