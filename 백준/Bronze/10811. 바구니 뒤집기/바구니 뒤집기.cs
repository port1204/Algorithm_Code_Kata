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
                int[] basket = new int[N];
                List<int> list = new List<int>();
                for (int i = 0; i < N; ++i)
                {
                    basket[i] = i + 1;
                }

                for (int i = 0; i < M; ++i)
                {
                    input = sr.ReadLine().Split();
                    int a = int.Parse(input[0]);
                    int b = int.Parse(input[1]);
                    for (int j = a; j <= b; ++j)
                    {
                        list.Add(basket[j - 1]);
                    }
                    list.Reverse();
                    for (int j = a; j <= b; ++j)
                    {
                        basket[j - 1] = list[j - a];
                    }
                    list.Clear();
                }

                sw.WriteLine(string.Join(" ", basket));

            }
        }


    }
}