using System;
using System.IO;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                int[] small = new int[N - 1];
                int[] big = new int[N - 1];
                int[] dp = new int[N];
                int[] dpWithBigJump = new int[N];

                // 작은 점프와 큰 점프 값 읽기
                for (int i = 0; i < N - 1; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    small[i] = int.Parse(input[0]);
                    big[i] = int.Parse(input[1]);
                }

                int bigbig = int.Parse(sr.ReadLine()); // 매우 큰 점프의 에너지 소비량 읽기

                // DP 배열 초기화
                for (int i = 0; i < N; i++)
                {
                    dp[i] = int.MaxValue; // 매우 큰 점프를 사용하지 않는 경우의 에너지 소비
                    dpWithBigJump[i] = int.MaxValue; // 매우 큰 점프를 사용하는 경우의 에너지 소비
                }

                dp[0] = 0; // 첫 번째 돌에서 출발 (에너지 0 소비)
                dpWithBigJump[0] = 0; // 첫 번째 돌에서 출발 (에너지 0 소비, 매우 큰 점프 가능)

                // 매우 큰 점프를 사용하지 않는 경우
                for (int i = 1; i < N; ++i)
                {
                    // 작은 점프
                    dp[i] = Math.Min(dp[i], dp[i - 1] + small[i - 1]);

                    // 큰 점프
                    if (i > 1)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - 2] + big[i - 2]);
                    }
                }

                // 매우 큰 점프를 한 번 사용하는 경우
                for (int i = 1; i < N; ++i)
                {
                    // 작은 점프
                    dpWithBigJump[i] = Math.Min(dpWithBigJump[i], dpWithBigJump[i - 1] + small[i - 1]);

                    // 큰 점프
                    if (i > 1)
                    {
                        dpWithBigJump[i] = Math.Min(dpWithBigJump[i], dpWithBigJump[i - 2] + big[i - 2]);
                    }

                    // 매우 큰 점프: 모든 지점에서 시도 (한 번만 사용 가능)
                    if (i > 2)
                    {
                        dpWithBigJump[i] = Math.Min(dpWithBigJump[i], dp[i - 3] + bigbig);
                    }
                }

                // 결과 출력: 매우 큰 점프를 사용하는 경우와 사용하지 않는 경우 중 최소값
                int result = Math.Min(dp[N - 1], dpWithBigJump[N - 1]);
                sw.WriteLine(result);
            }
        }
    }
}
