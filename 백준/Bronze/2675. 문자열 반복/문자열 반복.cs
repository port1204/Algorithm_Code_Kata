namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int T = int.Parse(sr.ReadLine());

                for (int i = 0; i < T; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    int R = int.Parse(input[0]);

                    string answer = "";

                    for (int j = 0; j < input[1].Length; ++j)
                    {
                        for (int k = 0; k < R; ++k)
                        {
                            answer += input[1][j];
                        }
                    }
                    sw.WriteLine(answer);
                }

            }
        }

    }
}
