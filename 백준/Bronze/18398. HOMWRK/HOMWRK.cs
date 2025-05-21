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
                    int N = int.Parse(sr.ReadLine());
                    for (int j = 0; j < N; j++)
                    {
                        string[] input = sr.ReadLine().Split();
                        int a = int.Parse(input[0]);
                        int b = int.Parse(input[1]);
                        sw.WriteLine($"{a + b} {a * b}");
                    }
                }

            } // using
        } // Main
    } // class
} // namespace