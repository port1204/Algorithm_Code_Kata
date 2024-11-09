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
                long w = long.Parse(input[0]);
                long h = long.Parse(input[1]);

                input = sr.ReadLine().Split();
                long x = long.Parse(input[0]);
                long y = long.Parse(input[1]);

                long t = long.Parse(sr.ReadLine());
                long xx = (x + t) % (w * 2);
                if (xx > w)
                {
                    xx = 2 * w - xx;
                }
                long yy = (y + t) % (h * 2);
                if (yy > h)
                {
                    yy = 2 * h - yy;
                }
                sw.WriteLine($"{xx} {yy}");
            } // using
        } // Main
    } // class
} // ns
