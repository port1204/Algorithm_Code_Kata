using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Queue<int> q = new Queue<int>();
            int Lastq = 0;
            StringBuilder Answer = new StringBuilder();
            string[] inputs = new string[N];

            for (int i = 0; i < N; ++i)
            {
                inputs[i] = Console.ReadLine();
            }

            for (int i = 0; i < N; ++i)
            {
                string[] input = inputs[i].Split(" ");

                switch (input[0]) 
                {
                    case "push":
                        int X = int.Parse(input[1]);
                        Lastq = X;
                        q.Enqueue(X);
                        break;
                    case "pop":
                        if (q.Count == 0)
                            Answer.Append("-1\n");
                        else
                            Answer.Append(q.Dequeue().ToString() + "\n");
                        break;
                    case "size":
                        Answer.Append(q.Count.ToString() + "\n");
                        break;
                    case "empty":
                        if (q.Count == 0)
                            Answer.Append("1\n");
                        else
                            Answer.Append("0\n");
                        break;
                    case "front":
                        if (q.Count == 0)
                            Answer.Append("-1\n");
                        else
                            Answer.Append(q.First().ToString() + "\n");
                        break;
                    case "back":
                        if (q.Count == 0)
                            Answer.Append("-1\n");
                        else
                            Answer.Append(Lastq.ToString() + "\n");
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine(Answer);
        }
    }
}
