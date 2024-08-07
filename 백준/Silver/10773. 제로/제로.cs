namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int N = int.Parse(sr.ReadLine());
                Stack<int> stack = new Stack<int>();
                for (int i = 0; i < N; ++i)
                {
                    int num = int.Parse(sr.ReadLine());
                    if (num == 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(num);
                    }
                }
                int sum = 0;
                foreach (int i in stack)
                {
                    sum += i;
                }
                sw.WriteLine(sum);
            }
        }
    }
}