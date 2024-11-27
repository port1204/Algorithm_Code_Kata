namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                while (true)
                {
                    string input = sr.ReadLine();
                    if (input == "0")
                    {
                        break;
                    }
                    string[] line = input.Split();
                    int N = int.Parse(line[0]);
                    int[] heights = new int[N];

                    for (int i = 0; i < N; i++)
                    {
                        heights[i] = int.Parse(line[i + 1]);
                    }

                    long maxArea = GetLargestRectangleArea(heights);
                    sw.WriteLine(maxArea);

                }


            } // using

            static long GetLargestRectangleArea(int[] heights)
            {
                Stack<int> stack = new Stack<int>();
                long maxArea = 0;
                int n = heights.Length;

                for (int i = 0; i < n; i++)
                {
                    while (stack.Count > 0 && heights[stack.Peek()] > heights[i])
                    {
                        int height = heights[stack.Pop()];
                        int width = stack.Count == 0 ? i : i - stack.Peek() - 1;
                        maxArea = Math.Max(maxArea, (long)height * width);
                    }
                    stack.Push(i);
                }

                while (stack.Count > 0)
                {
                    int height = heights[stack.Pop()];
                    int width = stack.Count == 0 ? n : n - stack.Peek() - 1;
                    maxArea = Math.Max(maxArea, (long)height * width);
                }

                return maxArea;
            }

        } // Main
    } // class
} // namespace
