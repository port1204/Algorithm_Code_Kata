namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            List<char[]> DNA = new List<char[]>(N);
            string answer = "";
            int count = 0;
            int minCount = M;
            char[] main = new char[M];

            for (int i = 0; i < N; ++i)
            {
                string s = Console.ReadLine();
                DNA.Add(s.ToCharArray());
            }

            for (int i = 0 ; i < M ; ++i)
            {
                Dictionary<char, int> check = new Dictionary<char, int>();
                for (int j = 0 ; j < N; ++j)
                {
                    char c = DNA[j][i];
                    if (check.ContainsKey(c))
                    {
                        ++check[c];
                    }
                    else
                    {
                        check[c] = 1;
                    }
                }

                char p = ' ';
                int max = 0;
                foreach (var k in check)
                {
                    if(k.Value > max || (k.Value == max && k.Key < p))
                    {
                        max = k.Value;
                        p = k.Key;
                    }
                }

                main[i] = p;
            }

            for (int i = 0;i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                {
                    if (main[j] != DNA[i][j])
                    {
                        ++count;
                    }
                }
            }

            answer = new string(main);

            Console.WriteLine(answer);
            Console.WriteLine(count);
        }
    }
}
