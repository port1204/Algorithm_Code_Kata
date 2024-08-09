using System;
using System.IO;

namespace FibonacciCount
{
    internal class Program
    {
        // 최대 N 값
        const int MAX_N = 40;

        // 호출 횟수 배열
        static int[,] count = new int[MAX_N + 1, 2];

        static void Main(string[] args)
        {
            // 사전 계산
            CalculateFibonacciCounts();

            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int T = int.Parse(sr.ReadLine());
                
                for (int i = 0; i < T; ++i)
                {
                    int N = int.Parse(sr.ReadLine());
                    sw.WriteLine($"{count[N, 0]} {count[N, 1]}");
                }
            }
        }

        static void CalculateFibonacciCounts()
        {
            // 초기화
            count[0, 0] = 1; // fibonacci(0) 호출 시 0이 1번 출력됨
            count[0, 1] = 0; // fibonacci(0) 호출 시 1은 출력되지 않음
            count[1, 0] = 0; // fibonacci(1) 호출 시 0은 출력되지 않음
            count[1, 1] = 1; // fibonacci(1) 호출 시 1이 1번 출력됨

            for (int i = 2; i <= MAX_N; ++i)
            {
                count[i, 0] = count[i - 1, 0] + count[i - 2, 0];
                count[i, 1] = count[i - 1, 1] + count[i - 2, 1];
            }
        }
    }
}
