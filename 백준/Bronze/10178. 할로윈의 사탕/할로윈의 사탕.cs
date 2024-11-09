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
                    int a = int.Parse(input[0]);
                    int b = int.Parse(input[1]);
                    sw.WriteLine($"You get {a / b} piece(s) and your dad gets {a % b} piece(s).");
                }

            } // using
        } // Main
    } // class
} // ns
