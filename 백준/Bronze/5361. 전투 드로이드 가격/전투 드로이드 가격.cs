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
                    double sum = 0;
                    double[] input = Array.ConvertAll(sr.ReadLine().Split(), double.Parse);
                    sum += input[0] * 350.34;
                    sum += input[1] * 230.90;
                    sum += input[2] * 190.55;
                    sum += input[3] * 125.30;
                    sum += input[4] * 180.90;
                    sw.WriteLine($"${sum.ToString("F2")}");
                }
            } // using
        } // Main
    } // class
} // namespace
