namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string N;
                while (true)
                {
                    N = sr.ReadLine();
                    if (N == "0")
                    {
                        break;
                    }
                    int count = N.Length + 1;
                    foreach (char c in N)
                    {
                        if (c == '1')
                        {
                            count += 2;
                        }
                        else if (c == '0')
                        {
                            count += 4;
                        }
                        else
                        {
                            count += 3;
                        }
                    }
                    sw.WriteLine(count);
                }

            } // using
        } // Main
    } // class
} // ns
