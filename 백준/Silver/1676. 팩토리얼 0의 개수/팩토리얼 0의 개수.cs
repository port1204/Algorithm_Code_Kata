namespace testcoding
{
    internal class Program
    {

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int N = int.Parse(sr.ReadLine());
                int count = 0;
                for (int i = 5; i <= N; i *= 5)
                {
                    count += N / i;
                }
                sw.WriteLine(count);
            }
        }

    }
}
