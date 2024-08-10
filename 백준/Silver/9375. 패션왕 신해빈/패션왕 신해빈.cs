namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int T = int.Parse(sr.ReadLine());
                for (int i = 0; i < T; ++i)
                {
                    int n = int.Parse(sr.ReadLine());
                    Dictionary<string, int> set = new Dictionary<string, int>();
                    for (int j = 0; j < n; ++j)
                    {
                        string[] s = sr.ReadLine().Split();
                        if (set.ContainsKey(s[1]))
                        {
                            ++set[s[1]];
                        }
                        else
                        {
                            set[s[1]] = 1;
                        }
                    }
                    int com = 1;
                    foreach (var count in set.Values)
                    {
                        com *= (count + 1);
                    }
                    com -= 1;
                    sw.WriteLine(com);
                }

            }

        }


    }
}