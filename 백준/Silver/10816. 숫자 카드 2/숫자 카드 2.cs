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
                string[] input1 = sr.ReadLine().Split();
                int M = int.Parse(sr.ReadLine());
                string[] input2 = sr.ReadLine().Split();
                Dictionary<string, int> set = new Dictionary<string, int>();
                foreach (var input in input1)
                {
                    if (set.ContainsKey(input))
                    {
                        ++set[input];
                    }
                    else
                    {
                        set[input] = 1;
                    }
                }
                int[] answer = new int[M];
                for (int i = 0; i < M; ++i)
                {
                    if (set.ContainsKey(input2[i]))
                    {
                        answer[i] = set[input2[i]];
                    }
                    else
                    {
                        answer[i] = 0;
                    }
                }
                sw.WriteLine(string.Join(" ", answer));
            }
        }
    }
}