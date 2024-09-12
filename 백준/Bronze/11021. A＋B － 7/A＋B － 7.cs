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
                for (int i = 0; i < N; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    int A = int.Parse(input[0]);
                    int B = int.Parse(input[1]);
                    sw.WriteLine($"Case #{i+1}: {A + B}");
                }
            }
        }


    }
}