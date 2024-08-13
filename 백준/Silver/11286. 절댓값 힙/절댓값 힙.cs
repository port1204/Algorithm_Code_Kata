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
                PriorityQueue<int, (int,int)> q = new PriorityQueue<int, (int, int)>();
                for (int i = 0; i < N; ++i)
                {
                    int x = int.Parse(sr.ReadLine());
                    if (x != 0)
                    {
                        q.Enqueue(x, (Math.Abs(x), x));
                    }
                    else
                    {
                        if (q.Count > 0)
                        {
                            sw.WriteLine(q.Dequeue());
                        }
                        else
                        {
                            sw.WriteLine(0);
                        }
                    }
                }
            }
        }

    }
}