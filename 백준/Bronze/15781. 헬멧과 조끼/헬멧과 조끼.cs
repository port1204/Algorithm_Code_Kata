namespace TestCoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                string[] input = sr.ReadLine().Split();
                int N = int.Parse(input[0]);
                int M = int.Parse(input[1]);
                long cur = 0;
                input = sr.ReadLine().Split();
                long a = 0;
                for (int i = 0; i < N; i++)
                {
                    cur = long.Parse(input[i]);
                    if (cur > a)
                    {
                        a = cur;
                    }
                }
                
                input = sr.ReadLine().Split();
                long b = 0;
                for (int i = 0; i < M; i++)
                {
                    cur = long.Parse(input[i]);
                    if (cur > b)
                    {
                        b = cur;
                    }
                }
                

                sw.WriteLine(a + b);
            }
        }
    }
}
