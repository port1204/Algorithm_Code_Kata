using System.Text;

namespace testcoding
{
    internal class Program
    {
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                sw.WriteLine("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.");
                Rec(N, 0);
                sw.WriteLine(sb);
            } // using
        } // Main

        static void Rec(int N, int i)
        {
            string U = new string('_', i * 4);

            sb.AppendLine($"{U}\"재귀함수가 뭔가요?\"");
            if (i == N)
            {
                sb.AppendLine($"{U}\"재귀함수는 자기 자신을 호출하는 함수라네\"");
            }
            else
            {
                sb.AppendLine($"{U}\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.");
                sb.AppendLine($"{U}마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.");
                sb.AppendLine($"{U}그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"");
                Rec(N, i + 1);
            }
            sb.AppendLine($"{U}라고 답변하였지.");
        }

    } // class
} // namespace