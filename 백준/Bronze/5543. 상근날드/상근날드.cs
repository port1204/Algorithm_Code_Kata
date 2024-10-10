namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int input;
                int burger = int.MaxValue;
                for (int i = 0; i < 3; ++i)
                {
                    input = int.Parse(sr.ReadLine());
                    if (input < burger)
                    {
                        burger = input;
                    }
                }
                int juice = int.MaxValue;
                for (int i = 0; i < 2; ++i)
                {
                    input = int.Parse(sr.ReadLine());
                    if (input < juice)
                    {
                        juice = input;
                    }
                }
                sw.WriteLine(burger + juice - 50);
            }
        }
    }
}