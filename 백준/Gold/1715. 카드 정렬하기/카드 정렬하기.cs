namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int N = int.Parse(sr.ReadLine());
                PriorityQueue<int, int> q = new PriorityQueue<int, int>();
                List<int> list = new List<int>();
                for (int i = 0; i < N; ++i)
                {
                    int x = int.Parse(sr.ReadLine());
                    q.Enqueue(x, x);
                }
                int sum = 0;
                while (q.Count > 1)
                {
                    sum = q.Dequeue() + q.Dequeue();
                    q.Enqueue(sum, sum);
                    list.Add(sum);
                }
                sum = 0;
                foreach (int x in list)
                {
                    sum += x;
                }
                sw.WriteLine(sum);
            }
        }

    }
}