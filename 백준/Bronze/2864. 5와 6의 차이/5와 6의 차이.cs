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
                int a = int.Parse(input[0].Replace('6', '5'));
                int b = int.Parse(input[1].Replace('6', '5'));
                int min = a + b;
                a = int.Parse(input[0].Replace('5', '6'));
                b = int.Parse(input[1].Replace('5', '6'));
                int max = a + b;
                sw.WriteLine($"{min} {max}");
            }
        }


    }
}