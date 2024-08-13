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
                for (int i = 0; i < N; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    for (int j = 0; j < N; ++j)
                    {
                        int num = int.Parse(input[j]);
                        q.Enqueue(num, num);

                        if (q.Count > N)
                        {
                            q.Dequeue();
                        }
                    }
                }

                sw.WriteLine(q.Dequeue());
            }
        }

    }
}