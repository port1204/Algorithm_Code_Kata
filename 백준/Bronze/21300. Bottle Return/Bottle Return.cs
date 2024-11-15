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
                int sum = 0;
                foreach (int i in input)
                {
                    sum += i * 5;
                }

                sw.WriteLine(sum);
            } // using
        } // Main
    } // class
} // ns
