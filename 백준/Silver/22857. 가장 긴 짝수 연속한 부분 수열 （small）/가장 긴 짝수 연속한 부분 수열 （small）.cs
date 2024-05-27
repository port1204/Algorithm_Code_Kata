using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);
            int[] S = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int maxLength = 0;
            int start = 0;
            int oddCount = 0;

            // 슬라이딩 윈도우 적용
            for (int end = 0; end < N; ++end)
            {
                // 현재 요소가 홀수라면 홀수 카운트 증가
                if (S[end] % 2 != 0)
                {
                    oddCount++;
                }

                // 홀수 카운트가 K를 초과하면 start 포인터 이동
                while (oddCount > K)
                {
                    if (S[start] % 2 != 0)
                    {
                        oddCount--;
                    }
                    start++;
                }

                // 현재 윈도우의 길이를 갱신
                maxLength = Math.Max(maxLength, end - start + 1 - oddCount);
            }
            sb.Append(maxLength);
            Console.WriteLine(sb);
        }//Main
    }
}