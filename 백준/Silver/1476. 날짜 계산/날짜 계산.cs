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
                int E = int.Parse(input[0]);
                int S = int.Parse(input[1]);
                int M = int.Parse(input[2]);

                int e = 1, s = 1, m = 1;
                int answer = 1;

                while (E != e || S != s || M != m)
                {
                    ++e; ++s; ++m; ++answer;
                    if (e > 15) 
                        e = 1;

                    if (s > 28)
                        s = 1;

                    if (m > 19)
                        m = 1;
                }

                sw.WriteLine(answer);
            }
        }

    }
}