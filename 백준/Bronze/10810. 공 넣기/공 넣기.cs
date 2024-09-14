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
                int N = int.Parse(input[0]);
                int M = int.Parse(input[1]);
                int[] balls = new int[N]; 
                for (int i = 0; i < M; ++i)
                {
                    input = sr.ReadLine().Split();
                    int a = int.Parse(input[0]);
                    int b = int.Parse(input[1]);
                    int c = int.Parse(input[2]);
                    for (int j = a - 1; j < b; ++j)
                    {
                        balls[j] = c;
                    }
                }
                sw.WriteLine(string.Join(" ", balls));

            }
        }


    }
}