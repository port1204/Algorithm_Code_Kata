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
                List<(int kg, int cm)> size = new List<(int, int)>();
                for (int i = 0; i < N; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    int a = int.Parse(input[0]);
                    int b = int.Parse(input[1]);
                    size.Add((a,b));
                }

                List<int> ranks = new List<int>(new int[N]);

                for (int i = 0; i < size.Count; ++i)
                {
                    int rank = 1;
                    for (int j = 0; j < size.Count; ++j)
                    {
                        if (i != j && size[j].kg > size[i].kg && size[j].cm > size[i].cm)
                        {
                            ++rank;
                        }
                    }
                    ranks[i] = rank;
                }

                sw.WriteLine(string.Join(" ", ranks));
            }
        }

    }
}
