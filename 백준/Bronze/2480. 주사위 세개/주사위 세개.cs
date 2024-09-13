using System.Numerics;

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
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);
                int C = int.Parse(input[2]);

                int answer = 0;
                if (A == B && A == C)
                {
                    answer = 10000 + (A * 1000);
                }
                else if (A == B || A == C || B == C)
                {
                    if (A == B)
                    {
                        answer = 1000 + (A * 100);
                    }
                    else
                    {
                        answer = 1000 + (C * 100);
                    }
                }
                else
                {
                    if (A >= B && A >= C)
                    {
                        answer = A * 100;
                    }
                    else if (B >= A && B >= C)
                    {
                        answer = B * 100;
                    }
                    else
                    {
                        answer = C * 100;
                    }
                }

                sw.WriteLine(answer);

            }
        }


    }
}