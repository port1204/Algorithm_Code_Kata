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
                int N = int.Parse(input[0]); // 학생 수
                int K = int.Parse(input[1]); // 조는 놈 수
                int Q = int.Parse(input[2]); // 출석코드 받는 수
                int M = int.Parse(input[3]); // 구간

                int[] stu = new int[N + 3];
                bool[] IsSleep = new bool[N + 3];
                string[] sleepingStudents = sr.ReadLine().Split();
                foreach (string s in sleepingStudents)
                {
                    int sleepyStudent = int.Parse(s);
                    IsSleep[sleepyStudent] = true;
                }

                int[] codeReceivedStudents = sr.ReadLine().Split().Select(int.Parse).ToArray();
                bool[] attendance = new bool[N + 3]; 

                foreach (var student in codeReceivedStudents)
                {
                    if (IsSleep[student])
                        continue;

                    for (int i = student; i <= N + 2; i += student)
                    {
                        if (!IsSleep[i])
                        {
                            attendance[i] = true;
                        }
                    }
                }

                int[] prefixSum = new int[N + 3];
                for (int i = 3; i <= N + 2; i++)
                {
                    prefixSum[i] = prefixSum[i - 1] + (attendance[i] ? 0 : 1);
                }

                for (int i = 0; i < M; i++)
                {
                    string[] range = sr.ReadLine().Split();
                    int S = int.Parse(range[0]);
                    int E = int.Parse(range[1]);

                    int absentCount = prefixSum[E] - prefixSum[S - 1];
                    sw.WriteLine(absentCount);
                }
            


            }

        }
    }
}