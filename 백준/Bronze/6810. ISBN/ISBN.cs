namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int A = int.Parse(sr.ReadLine()) * 1;
                int B = int.Parse(sr.ReadLine()) * 3;
                int C = int.Parse(sr.ReadLine()) * 1;
                sw.WriteLine($"The 1-3-sum is {A + B + C + 91}");
            } // using
        } // Main
    } // class
} // namespace