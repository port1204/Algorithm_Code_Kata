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
                int sum = 0;
                for (int i = 1; i <= N; ++i)
                {
                    sum += i;
                }
                sw.WriteLine(sum);
            }
        }


    }
}