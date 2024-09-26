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
                int count = 0;
                HashSet<string> set = new HashSet<string>();
                string input;
                for (int i = 0; i < N; ++i)
                {
                    input = sr.ReadLine();
                    if (input == "ENTER")
                    {
                        set = new HashSet<string>();
                    }
                    else if (!set.Contains(input))
                    {
                        set.Add(input);
                        ++count;
                    }
                }
                sw.WriteLine(count);
            }
        }

    }
}