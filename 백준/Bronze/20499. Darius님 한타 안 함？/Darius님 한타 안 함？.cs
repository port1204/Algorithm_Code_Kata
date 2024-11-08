namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string[] input = sr.ReadLine().Split("/");
                int K = int.Parse(input[0]);
                int D = int.Parse(input[1]);
                int A = int.Parse(input[2]);
                if (K + A < D || D == 0)
                {
                    sw.WriteLine("hasu");
                }
                else
                {
                    sw.WriteLine("gosu");
                }

            } // using
        } // Main
    } // class
} // ns
