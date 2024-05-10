using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder answer = new StringBuilder();
            Queue<int> q = new Queue<int>();
            string[] input = Console.ReadLine().Split(" ");
            int co = 0;

            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            for (int i = 1; i < (N+1); ++i)
            {
                q.Enqueue(i);
            }

            answer.Append("<");
            while (q.Count != 0)
            {
                ++co;
                if (co == K)
                {
                    if (q.Count == 1)
                    {
                        answer.Append(q.Dequeue());
                    }
                    else
                    {
                        answer.Append(q.Dequeue() + ", ");
                    }
                    co = 0;
                }
                else
                {
                    q.Enqueue(q.Dequeue());
                }
            }
            answer.Append(">");

            Console.Clear();
            Console.WriteLine(answer);
        }
    }
}
