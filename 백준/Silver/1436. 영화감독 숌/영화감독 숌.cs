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
                int count = 0;
                int number = 666;

                while (true)
                {
                    if (number.ToString().Contains("666"))
                    {
                        ++count;
                    }

                    if (count == N)
                    {
                        Console.WriteLine(number);
                        break;
                    }

                    ++number;
                }
            }
        }

    }
}
