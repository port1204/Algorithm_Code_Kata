namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                while (true)
                {
                    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    if (input[0] == 0 && input[1] == 0 && input[2] == 0)
                    {
                        break;
                    }

                    if (input[2] - input[1] == input[1] - input[0])
                    {
                        sw.WriteLine($"AP {(input[2] - input[1]) + input[2]}");
                    }
                    else
                    {
                        sw.WriteLine($"GP {(input[2] / input[1]) * input[2]}");
                    }

                }
            } // using
        } // Main
    } // class
} // namespace
