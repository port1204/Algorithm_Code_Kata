namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (j - i >= 0)
                        {
                            sw.Write("*");
                        }
                        else
                        {
                            sw.Write(" ");
                        }
                        
                    }
                    sw.WriteLine();
                }
            }
        }


    }
}