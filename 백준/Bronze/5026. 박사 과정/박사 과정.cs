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
                for (int i = 0; i < N; i++)
                {
                    string input = sr.ReadLine();
                    char[] c = input.ToArray();
                    string a = "";
                    string b = "";
                    int count = 0;
                    for (int j = 0; j < c.Length; j++)
                    {
                        if (c[j] == 'P')
                        {
                            break;
                        }
                        else if (c[j] == '+')
                        {
                            count++;
                        }
                        else if (count == 0)
                        {
                            a += c[j];
                        }
                        else if (count == 1)
                        {
                            b += c[j];
                        }
                    }
                    if (a == "")
                    {
                        sw.WriteLine("skipped");
                    }
                    else
                    {
                        sw.WriteLine(int.Parse(a) + int.Parse(b));
                    }
                }

            } // using
        } // Main
    } // class
} // namespace