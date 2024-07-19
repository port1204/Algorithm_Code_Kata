namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            List<int> sequence = new List<int>();
            bool[] used = new bool[N + 1];

            // 백트래킹 함수 호출
            GenerateSequences(N, M, sequence, used);
        }

        static void GenerateSequences(int N, int M, List<int> sequence, bool[] used)
        {
            // 수열이 길이 M에 도달하면 출력
            if (sequence.Count == M)
            {
                Console.WriteLine(string.Join(" ", sequence));
                return;
            }

            for (int i = 1; i <= N; ++i)
            {
                if (!used[i])
                {
                    // 같은 수 체크
                    sequence.Add(i);
                    used[i] = true;

                    // 재귀 호출
                    GenerateSequences(N, M, sequence, used);

                    // 백트래킹 (되돌리기) 중요
                    sequence.RemoveAt(sequence.Count - 1);
                    used[i] = false;
                }
            }
        }
    }
}
