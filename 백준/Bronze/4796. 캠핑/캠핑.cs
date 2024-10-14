namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int Case = 1;
                while (true)
                {
                    string[] input = sr.ReadLine().Split();
                    if (input[0] == "0")
                    {
                        break;
                    }
                    int L = int.Parse(input[0]);
                    int P = int.Parse(input[1]);
                    int V = int.Parse(input[2]);
                    int answer = ((V / P) * L);
                    if (V % P <= L)
                    {
                        answer += V % P;
                    }
                    else
                    {
                        answer += L;
                    }
                    sw.WriteLine($"Case {Case}: {answer}");
                    ++Case;
                }
            }
        }

    }
}