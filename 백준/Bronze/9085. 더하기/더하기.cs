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
                for (int i = 0; i < T; ++i)
                {
                    int N = int.Parse(sr.ReadLine());
                    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    int sum = 0;
                    for (int j = 0; j < N; ++j)
                    {
                        sum += input[j];
                    }
                    sw.WriteLine(sum);
                }
                
            } // using
        } // Main


    }
}