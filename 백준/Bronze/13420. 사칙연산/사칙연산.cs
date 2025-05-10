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
                for  (int i = 0; i < N; i++)
                {
                    string[] input = sr.ReadLine().Split();
                    long a = long.Parse(input[0]);
                    long b = long.Parse(input[2]);
                    long c = long.Parse(input[4]);

                    if (input[1] == "+")
                    {
                        if (a + b == c)
                        {
                            sw.WriteLine("correct");
                        }
                        else
                        {
                            sw.WriteLine("wrong answer");
                        }
                    }
                    else if (input[1] == "-")
                    {
                        if (a - b == c)
                        {
                            sw.WriteLine("correct");
                        }
                        else
                        {
                            sw.WriteLine("wrong answer");
                        }
                    }
                    else if (input[1] == "*")
                    {
                        if (a * b == c)
                        {
                            sw.WriteLine("correct");
                        }
                        else
                        {
                            sw.WriteLine("wrong answer");
                        }
                    }
                    else if (input[1] == "/")
                    {
                        if (a / b == c)
                        {
                            sw.WriteLine("correct");
                        }
                        else
                        {
                            sw.WriteLine("wrong answer");
                        }
                    }
                }

            } // using
        } // Main
    } // class
} // namespace