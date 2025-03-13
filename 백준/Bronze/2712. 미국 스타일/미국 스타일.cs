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
                    string[] input = sr.ReadLine().Split();
                    double a = double.Parse(input[0]);
                    if (input[1] == "kg")
                    {
                        a *= 2.2046;
                        input[1] = "lb";
                    }
                    else if (input[1] == "l")
                    {
                        a *= 0.2642;
                        input[1] = "g";
                    }
                    else if (input[1] == "lb")
                    {
                        a *= 0.4536;
                        input[1] = "kg";
                    }
                    else if (input[1] == "g")
                    {
                        a *= 3.7854;
                        input[1] = "l";
                    }
                    sw.WriteLine($"{a:F4}" + $" {input[1]}");
                }

            } // using
        } // Main
    } // class
} // namespace