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
                int Xmin = int.MaxValue;
                int Ymin = int.MaxValue;
                int answer = 0;
                for (int i = 0; i < M; ++i)
                {
                    input = sr.ReadLine().Split();
                    int x = int.Parse(input[0]);
                    int y = int.Parse(input[1]);
                    
                    Xmin = Math.Min(Xmin, x);
                    Ymin = Math.Min(Ymin, y);
                }

                if (N >= 6)
                {
                    if (N % 6 == 0)
                    {  // 패키지, 낱개 * 6
                        answer = Math.Min(Xmin, (Ymin * 6));
                        answer *= (N / 6);
                    }
                    else
                    {  // 패키지 * (몫 + 1), (패키지 * 몫) + (낱개 * 나머지)
                        answer = Math.Min(Xmin * ((N/6) + 1), (Xmin * (N / 6)) + (Ymin * (N % 6)));
                        // vs 낱개 * 요구개수
                        answer = Math.Min(answer, (Ymin * N));
                    }
                }
                else
                {  // 패키지, 낱개 * 요구개수
                    answer = Math.Min(Xmin, (Ymin * N));
                }

                sw.WriteLine(answer);

            }
        }

    }
}