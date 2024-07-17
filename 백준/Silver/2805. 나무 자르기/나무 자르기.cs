namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            int[] tree = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(tree);

            int H = 0;
            int low = 0;
            int high = tree[N - 1];

            while (low <= high)
            {
                int mid = (low + high) / 2;
                long sum = 0;

                foreach (int h in tree)
                {
                    if (h > mid)
                    {
                        sum += h - mid;
                    }
                }

                if (sum >= M)
                {
                    H = mid;
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            Console.WriteLine(H);
        }// main
    }
}