namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int max = 0;
                int current = 0;
                for (int i = 0; i < 10; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    current -= int.Parse(input[0]);
                    current += int.Parse(input[1]);
                    if (max < current)
                    {
                        max = current;
                    }
                }
                sw.WriteLine(max);
            }
        }


    }
}