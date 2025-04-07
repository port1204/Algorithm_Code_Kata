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
                    string[] input = sr.ReadLine().Split();
                    if (input[0] == "0" && input[1] == "0")
                    {
                        break;
                    }
                    long a = long.Parse(input[0]);
                    long b = long.Parse(input[1]);
                    sw.WriteLine(a - (b - a));
                }
            } // using
        } // Main
    } // class
} // namespace