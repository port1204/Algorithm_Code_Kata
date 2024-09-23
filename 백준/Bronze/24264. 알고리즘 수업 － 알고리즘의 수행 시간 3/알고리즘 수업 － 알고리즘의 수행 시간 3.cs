namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            { 
                long N = long.Parse(sr.ReadLine());
                sw.WriteLine(N*N);
                sw.WriteLine(2);
            }
        }


    }
}