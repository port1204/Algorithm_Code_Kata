namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int T = int.Parse(sr.ReadLine());
                for (int i = 0; i < T; i++)
                {
                    string input = sr.ReadLine();
                    char c = input[input.Length - 1];
                    int a = int.Parse(c.ToString());
                    if (a % 2 == 0)
                    {
                        sw.WriteLine("even");
                    }
                    else
                    {
                        sw.WriteLine("odd");
                    }
                }

            } // using
        } // Main
    } // class
} // ns
