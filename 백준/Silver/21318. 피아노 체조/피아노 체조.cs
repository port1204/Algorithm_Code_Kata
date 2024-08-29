namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                int[] ints = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int Q = int.Parse(sr.ReadLine());

                int[] diff = new int[N];
                for (int i = 1; i < N; ++i)
                {
                    diff[i] = (ints[i - 1] > ints[i]) ? 1 : 0;
                }

                int[] prefix = new int[N + 1];
                for (int i = 1; i < N; ++i)
                {
                    prefix[i] = prefix[i - 1] + diff[i];
                }

                for (int i = 0; i < Q; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    int x = int.Parse(input[0]);
                    int y = int.Parse(input[1]);

                    int count = prefix[y - 1] - prefix[x - 1];
                    sw.WriteLine(count);
                }
            }

        }
    }
}