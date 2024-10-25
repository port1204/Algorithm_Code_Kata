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
                long A = long.Parse(input[0]);
                long B = long.Parse(input[1]);
                sw.WriteLine((A + B) * (A - B));
            }
        }


    }
}