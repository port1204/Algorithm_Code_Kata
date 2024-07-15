namespace testcoding
{
    internal class Program
    {

        static Dictionary<int, List<int>> failcom = new Dictionary<int, List<int>>();

        static void PutNums(int a, int b)
        {
            if (!failcom.ContainsKey(a))
            {
                failcom[a] = new List<int>();
            }

            failcom[a].Add(b);
        }

        static bool Check(int a , int b , int c)
        {
            if (a == b || a == c || b == c) return true;

            if (failcom.ContainsKey(a))
            {
                foreach (int i in failcom[a])
                {
                    if (i == b || i == c)
                    {
                        return true;
                    }
                }
            }
            
            if (failcom.ContainsKey(b))
            {
                foreach (int i in failcom[b])
                {
                    if (i == a || i == c)
                    {
                        return true;
                    }
                }
            }
            
            if (failcom.ContainsKey(c))
            {
                foreach (int i in failcom[c])
                {
                    if (i == a || i == b)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            int count = 0;

            for (int i  = 0; i < M; ++i)
            {
                string[] fail = Console.ReadLine().Split();
                int a = int.Parse(fail[0]);
                int b = int.Parse(fail[1]);
                PutNums(a, b);
            }

            for (int i = 1; i <= N; ++i)
            {
                for (int j = i + 1; j <= N; ++j)
                {
                    for (int k = j + 1; k <= N; ++k)
                    {
                        if(!Check(i, j, k))
                        {
                            ++count;
                        }
                    }
                }
            }

            Console.WriteLine(count);


        }// main
    }
}
