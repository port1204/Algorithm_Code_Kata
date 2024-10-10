namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int sum = 0;    
                for (int  i = 0; i < 5; ++i)
                {
                    int N = int.Parse(sr.ReadLine());
                    if (N < 40)
                    {
                        N = 40;
                    }
                    sum += N;
                }
                sw.WriteLine(sum/5);
            }
        }
    }
}