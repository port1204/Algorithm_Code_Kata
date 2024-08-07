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
                List<(int x, int y)> maps = new List<(int, int)>();

                for (int i = 0; i < N; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    int x = int.Parse(input[0]);
                    int y = int.Parse(input[1]);
                    maps.Add((x, y));
                }

                maps.Sort((a, b) => 
                {
                    int yComparison = a.y.CompareTo(b.y);
                    if (yComparison == 0)
                    {
                        return a.x.CompareTo(b.x);
                    }
                    return yComparison;
                });

                foreach (var map in maps)
                {
                    sw.WriteLine($"{map.x} {map.y}");
                }
            }
        }
    }
}