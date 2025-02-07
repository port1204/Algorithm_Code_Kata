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
                int[] heights = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int[] results = new int[N];
                Stack<(int height, int index)> stack = new Stack<(int, int)>();

                for (int i = 0; i < N; i++)
                {
                    while (stack.Count > 0 && stack.Peek().height < heights[i])
                    {
                        stack.Pop();
                    }

                    if (stack.Count == 0)
                    {
                        results[i] = 0;
                    }
                    else
                    {
                        results[i] = stack.Peek().index + 1;
                    }

                    stack.Push((heights[i], i));
                }

                sw.WriteLine(string.Join(" ", results));

            } // using
        } // Main
    } // class
} // namespace