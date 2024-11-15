namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string[] input = sr.ReadLine().Split();
                int S = int.Parse(input[0]);
                int T = int.Parse(input[1]);
                int D = int.Parse(input[2]);

                int F = (T * D) / (2 * S);

                sw.WriteLine(F);

            } // using
        } // Main
    } // class
} // ns
