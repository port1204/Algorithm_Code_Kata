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
                int[] nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int[] result = new int[N];
                Stack<int> stack = new Stack<int>();
                for (int i = 0; i < N; ++i)
                {
                    while (stack.Count > 0 && nums[stack.Peek()] < nums[i])
                    {
                        result[stack.Pop()] = nums[i];
                    }
                    stack.Push(i);
                }

                while (stack.Count > 0)
                {
                    result[stack.Pop()] = -1;
                }

                sw.WriteLine(string.Join(" ", result));
            }
        }
    }
}