namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string input = sr.ReadLine();
                HashSet<string> set = new HashSet<string>();
                for (int i = 0; i < input.Length; ++i)
                {
                    for (int j = 1; j <= input.Length - i; ++j)
                    {
                        string S = input.Substring(i, j);
                        set.Add(S);
                    }
                }
                sw.WriteLine(set.Count);
            }
        }
    }
}