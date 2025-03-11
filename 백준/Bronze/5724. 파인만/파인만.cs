namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                while(true)
                {
                    string input = sr.ReadLine();
                    if (input == "0")
                    {
                        break;
                    }

                    int N = int.Parse(input);
                    int sum = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        sum += i * i;
                    }

                    sw.WriteLine(sum);
                }
            } // using
        } // Main
    } // class
} // namespace