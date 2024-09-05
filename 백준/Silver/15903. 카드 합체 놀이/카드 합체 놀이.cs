namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string[] input = sr.ReadLine().Split();
                int N = int.Parse(input[0]);
                int M = int.Parse(input[1]);
                int[] nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                PriorityQueue<long, long> pq = new PriorityQueue<long, long>();
                for (int i = 0; i < N; ++i)
                {
                    pq.Enqueue(nums[i], nums[i]);
                }

                for (int i = 0; i < M; ++i)
                {
                    long x = pq.Dequeue();
                    long y = pq.Dequeue();
                    pq.Enqueue(x + y, x + y);
                    pq.Enqueue(x + y, x + y);
                }

                long sum = 0;
                for (int i = 0; i < N; ++i)
                {
                    sum += pq.Dequeue();
                }

                sw.WriteLine(sum);
            }
        }

    }
}