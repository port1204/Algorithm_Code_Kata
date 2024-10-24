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
                int K = int.Parse(input[0]);
                int N = int.Parse(input[1]);
                int M = int.Parse(input[2]);
                int answer = 0;
                if (K * N > M)
                {
                    answer = (K * N) - M;
                }
                else
                {
                    answer = 0;
                }
                sw.WriteLine(answer);
            }
        }


    }
}