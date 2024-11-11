namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int n = int.Parse(sr.ReadLine());
                while (true)
                {

                    int input = int.Parse(sr.ReadLine());
                    if (input == 0) break;

                    if (input % n == 0)
                    {
                        sw.WriteLine($"{input} is a multiple of {n}.");
                    }
                    else
                    {
                        sw.WriteLine($"{input} is NOT a multiple of {n}.");
                    }
                }
            } // using
        } // Main
    } // class
} // ns
