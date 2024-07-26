namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int num = 0;
                int max = int.MinValue;

                for (int i = 0; i < 9; i++)
                {
                    int input = int.Parse(sr.ReadLine());

                    if (input > max)
                    {
                        max = input;
                        num = i + 1;
                    }
                }

                sw.WriteLine(max);
                sw.WriteLine(num);
            }
        }

    }
}
