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
                int X = int.Parse(input[1]);

                int[] arrayA = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                // 초기 슬라이딩 윈도우 설정
                int currentSum = 0;
                for (int i = 0; i < X; i++)
                {
                    currentSum += arrayA[i];
                }

                int maxSum = currentSum;
                int count = 1;

                // 슬라이딩 윈도우 실행
                for (int i = X; i < N; i++)
                {
                    // 윈도우를 한 칸 오른쪽으로 이동
                    currentSum = currentSum - arrayA[i - X] + arrayA[i];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        count = 1;
                    }
                    else if (currentSum == maxSum)
                    {
                        count++;
                    }
                }

                // 출력 처리
                if (maxSum == 0)
                {
                    sw.WriteLine("SAD");
                }
                else
                {
                    sw.WriteLine(maxSum);
                    sw.WriteLine(count);
                }
            }
        }

    }
}