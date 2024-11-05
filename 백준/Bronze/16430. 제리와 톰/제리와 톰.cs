namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                sw.WriteLine($"{input[1] - input[0]} {input[1]}");

            } // using
        } // Main


    }
}