namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine()) - 2013;

                int A = (9 + N % 10 + 10) % 10;
                int B = (5 + N % 12 + 12) % 12;

                char[] c = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L' };
                char answer = c[B];

                sw.WriteLine($"{answer}{A}");
            } // using
        } // Main
    } // class
} // namespace