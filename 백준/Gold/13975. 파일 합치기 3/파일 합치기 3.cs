namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int T = int.Parse(sr.ReadLine());
                for (int i = 0; i < T; ++i)
                {
                    int N = int.Parse(sr.ReadLine());
                    PriorityQueue<long, long> q = new PriorityQueue<long, long>();
                    string[] input = sr.ReadLine().Split();
                    for (int j = 0; j < N; ++j)
                    {
                        int num = int.Parse(input[j]);
                        q.Enqueue(num, num);
                    }

                    long answer = 0;
                    while (q.Count > 1)
                    {
                        long sum = q.Dequeue() + q.Dequeue();
                        answer += sum;
                        q.Enqueue(sum, sum);
                    }

                    sw.WriteLine(answer);
                }
            }
        }

    }
}