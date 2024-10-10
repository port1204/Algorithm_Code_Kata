namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string[] input = sr.ReadLine().Split();
                long N = long.Parse(input[0]);
                long M = long.Parse(input[1]);
                long answer = Math.Abs(N - M);
                sw.WriteLine(answer);
            }
        }
    }
}