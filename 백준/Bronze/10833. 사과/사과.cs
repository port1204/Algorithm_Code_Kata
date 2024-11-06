namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                int count = 0;
                for (int i = 0; i < N; ++i)
                {
                    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    if (input[0] <= input[1])
                    {
                        count += input[1] % input[0];
                    }
                    else
                    {
                        count += input[1];
                    }
                }
                sw.WriteLine(count);
            } // using
        } // Main


    }
}