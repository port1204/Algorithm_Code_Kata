using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); 
            int TC = int.Parse(Console.ReadLine());

            for (int i = 0; i < TC; i++)
            {
                Queue<int> q = new Queue<int>();
                Queue<int> q1 = new Queue<int>();
                int count = 0;

                string[] NM = Console.ReadLine().Split(" ");
                int N = int.Parse(NM[0]);
                int M = int.Parse(NM[1]);
                int[] O = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int  j = 0; j < N; j++)
                {
                    q.Enqueue(O[j]);
                    q1.Enqueue(j);
                }

                while (q.Count > 0)
                {
                    if (q.Peek() == q.Max())
                    {
                        if (q1.Peek() == M)
                        {
                            sb.AppendLine($"{count + 1}");
                            break;
                        }
                        else
                        {
                            q.Dequeue();
                            q1.Dequeue();
                            count++;
                        }
                    }
                    else
                    {
                        q.Enqueue(q.Dequeue());
                        q1.Enqueue(q1.Dequeue());
                    }
                }
            }
            Console.Clear();
            Console.WriteLine(sb);
        }//main
    }
}