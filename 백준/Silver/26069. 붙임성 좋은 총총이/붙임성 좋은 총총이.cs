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
                HashSet<string> set = new HashSet<string>();
                string[] input;
                set.Add("ChongChong");
                for (int i = 0; i < N; ++i)
                {
                    input = sr.ReadLine().Split();
                    if (set.Contains(input[0]) || set.Contains(input[1]))
                    {
                        set.Add(input[0]);
                        set.Add(input[1]);
                    }
                }
                sw.WriteLine(set.Count);
            }
        }

    }
}