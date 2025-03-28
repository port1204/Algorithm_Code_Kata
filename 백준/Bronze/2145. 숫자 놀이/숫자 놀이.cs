namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                while (true)
                {
                    string input = sr.ReadLine();
                    if (input == "0")
                    {
                        break;
                    }

                    int num = int.Parse(input);

                    while (num >= 10)
                    {
                        int sum = 0;
                        while (num > 0)
                        {
                            sum += num % 10;
                            num /= 10;
                        }
                        num = sum;
                    }

                    sw.WriteLine(num);
                }
            } // using
        } // Main
    } // class
} // namespace