namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                double[] input = Array.ConvertAll(sr.ReadLine().Split(), double.Parse);

                double a = (input[0] * input[1]) / input[2];
                double b = (input[0] / input[1]) * input[2];
                double c = input[0] * (input[1] / input[2]);

                double Max = Math.Max(Math.Max(a, b), c);

                sw.WriteLine((int)Max);
            } // using
        } // Main
    } // class
} // ns
