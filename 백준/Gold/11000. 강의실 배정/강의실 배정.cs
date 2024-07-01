namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<(int a, int b)> list = new List<(int, int)>();

            for (int i = 0; i < N; ++i)
            {
                string[] time = Console.ReadLine().Split();
                int S = int.Parse(time[0]);
                int T = int.Parse(time[1]);
                list.Add((S, T));
            }

            list = list.OrderBy(c => c.a).ToList();

            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

            pq.Enqueue(list[0].b, list[0].b);

            for (int i = 1; i < N; ++i)
            {
                var room = list[i];

                if (pq.Peek() <= room.a)
                {
                    pq.Dequeue();
                }

                pq.Enqueue(room.b, room.b);
            }

            Console.WriteLine(pq.Count);
        }
    }
}