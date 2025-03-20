namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int[] times = new int[2];
                for (int i = 0; i < 2;  i++)
                {
                    string[] s = sr.ReadLine().Split(':');
                    int a = int.Parse(s[0]) * 60;
                    int b = int.Parse(s[1]);
                    times[i] = a + b;
                }

                int c = times[1] - times[0];
                if (c < 0)
                {
                    c += 1440;
                }

                sw.WriteLine((c / 60) + (c % 60));
            } // using
        } // Main
    } // class
} // namespace