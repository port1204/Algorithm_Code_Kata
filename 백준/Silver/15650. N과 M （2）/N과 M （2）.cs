class Program
{
    static void Main()
    {
        // 입력 받기
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);

        // 결과를 담을 리스트 초기화
        List<int> sequence = new List<int>();

        // 백트래킹 함수 호출
        GenerateSequences(N, M, 1, sequence);
    }

    static void GenerateSequences(int N, int M, int start, List<int> sequence)
    {
        // 수열이 길이 M에 도달하면 출력
        if (sequence.Count == M)
        {
            Console.WriteLine(string.Join(" ", sequence));
            return;
        }

        for (int i = start; i <= N; i++)
        {
            // 숫자를 수열에 추가
            sequence.Add(i);

            // 재귀 호출
            GenerateSequences(N, M, i + 1, sequence);

            // 백트래킹 (되돌리기)
            sequence.RemoveAt(sequence.Count - 1);
        }
    }
}
