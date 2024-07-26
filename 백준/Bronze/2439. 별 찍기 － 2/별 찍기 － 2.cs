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
                for (int i = 0; i < N; ++i)
                {
                    string answer = "";
                    for (int j = 0; j < N; ++j)
                    {
                        if (N - (i+j) > 1)
                        {
                            answer += " ";
                        }
                        else 
                        {
                            answer += "*";
                        }
                    }
                    sw.WriteLine(answer);
                }

            }
        }

    }
}
