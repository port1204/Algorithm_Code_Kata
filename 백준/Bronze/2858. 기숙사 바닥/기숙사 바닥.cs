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
                int size = input[0] + input[1];
                for (int i = 1; (i * i)<= size; i++)
                {
                    if (size % i == 0)
                    {
                        int outSide = size / i;
                        if ((outSide + i - 2) * 2 == input[0]) 
                        {
                            sw.WriteLine($"{outSide} {i}");
                            return;
                        }
                    }
                }
            } // using
        } // Main
    } // class
} // namespace