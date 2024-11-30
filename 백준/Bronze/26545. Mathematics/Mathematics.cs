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
                int sum = 0;
                for (int i = 0; i < T; i++)
                {
                    sum += int.Parse(sr.ReadLine());
                }
                sw.WriteLine(sum);
            } // using
        } // Main
    } // class
} // namespace