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
                int start = int.Parse(time[0]);
                int end = int.Parse(time[1]);
                list.Add((start, end));
            }

            list = list.OrderBy(m => m.b).ThenBy(m => m.a).ToList();

            int count = 0;
            int lastEndTime = 0;

            foreach (var meeting in list)
            {
                if (meeting.a >= lastEndTime)
                {
                    lastEndTime = meeting.b;
                    ++count;
                }
            }

            Console.WriteLine(count);
        }
    }
}

