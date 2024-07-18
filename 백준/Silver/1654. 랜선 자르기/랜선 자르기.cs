namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int K = int.Parse(input[0]);
            int N = int.Parse(input[1]);

            int[] line = new int[K];
            for (int i = 0; i < K; i++)
            {
                line[i] = int.Parse(Console.ReadLine());
            }

            long low = 1;
            long high = line.Max();
            long answer = 0;

            while (low <= high)
            {
                long mid = (low + high) / 2;
                long count = 0;

                foreach (int i in line)
                {
                    count += i / mid;
                }

                if (count >= N)
                {
                    answer = mid;
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            Console.WriteLine(answer);
        }// main
    }
}