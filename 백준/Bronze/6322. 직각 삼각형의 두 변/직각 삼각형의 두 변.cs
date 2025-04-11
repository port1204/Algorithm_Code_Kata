namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int num = 1;
                while (true)
                {
                    string[] input = sr.ReadLine().Split();

                    double a = double.Parse(input[0]);
                    double b = double.Parse(input[1]);
                    double c = double.Parse(input[2]);
                    if (a == 0 && b == 0 && c == 0)
                    {
                        break;
                    }

                    if (a == -1)
                    {
                        sw.WriteLine($"Triangle #{num}");
                        if (b >= c)
                        {
                            sw.WriteLine("Impossible.");
                        }
                        else
                        {
                            a = Math.Sqrt((c * c) - (b * b));
                            sw.WriteLine($"a = {a:F3}");
                        }
                    }
                    else if ( b == -1)
                    {
                        sw.WriteLine($"Triangle #{num}");

                        if (a >= c)
                        {
                            sw.WriteLine("Impossible.");
                        }
                        else
                        {
                            b = Math.Sqrt((c * c) - (a * a));
                            sw.WriteLine($"b = {b:F3}");
                        }
                    }
                    else if ( c == -1 )
                    {
                        c = Math.Sqrt((a * a) + (b * b));
                        sw.WriteLine($"Triangle #{num}");
                        sw.WriteLine($"c = {c:F3}");
                    }

                    sw.WriteLine();
                    ++num;
                }

            } // using
        } // Main
    } // class
} // namespace