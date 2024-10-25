namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int total = int.Parse(sr.ReadLine());
                for (int i = 0; i < 9; ++i)
                {
                    total -= int.Parse(sr.ReadLine());
                }
                sw.WriteLine(total);
            }
        }


    }
}