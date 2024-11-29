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
                    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    int answer = input[0] * (input[2] - 1) + input[1];
                    sw.WriteLine(answer);
                }
            } // using
        } // Main
    } // class
} // namespace