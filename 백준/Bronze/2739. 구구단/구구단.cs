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
                for (int i = 1; i <= 9; ++i)
                {
                    sw.WriteLine($"{N} * {i} = {N*i}");
                }
            }
        }//main
    }
}