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
                N = 1000 - N;
                int count = 0;
                while (N > 0)
                {
                    if (N >= 500)
                    {
                        N -= 500;
                        ++count;
                    }
                    else if (N >= 100)
                    {
                        N -= 100;
                        ++count;
                    }
                    else if (N >= 50)
                    {
                        N -= 50;
                        ++count;
                    }
                    else if (N >= 10)
                    {
                        N -= 10;
                        ++count;
                    }
                    else if (N >= 5)
                    {
                        N -= 5;
                        ++count;
                    }
                    else if (N >= 1)
                    {
                        N -= 1;
                        ++count;
                    }
                }
                sw.WriteLine(count);
            }
        } 
    }
}