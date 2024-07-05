namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<int, int> Cows = new Dictionary<int, int>();
            int count = 0;
            for (int i = 0; i < N; ++i)
            {
                string[] input = Console.ReadLine().Split();
                int cow = int.Parse(input[0]);
                int p = int.Parse(input[1]);
                if (Cows.ContainsKey(cow))
                {
                    if (!Cows[cow].Equals(p))
                    {
                        Cows[cow] = p;
                        ++count;
                    }
                }
                else
                {
                    Cows.Add(cow, p);
                }
            }

            Console.WriteLine(count);
        }
    }
}