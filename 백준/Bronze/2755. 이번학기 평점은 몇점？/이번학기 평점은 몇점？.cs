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
                float sum = 0;
                int s = 0;
                Dictionary<string, float> dic = new Dictionary<string, float>
                {
                    {"A+", 4.3f}, {"A0", 4.0f}, {"A-", 3.7f},
                    {"B+", 3.3f}, {"B0", 3.0f}, {"B-", 2.7f},
                    {"C+", 2.3f}, {"C0", 2.0f}, {"C-", 1.7f},
                    {"D+", 1.3f}, {"D0", 1.0f}, {"D-", 0.7f},
                    {"F", 0.0f}
                };

                for (int i = 0; i < N; i++)
                {
                    string[] input = sr.ReadLine().Split();
                    sum += int.Parse(input[1]) * dic[input[2]];
                    s += int.Parse(input[1]);
                }

                sum /= s;
                sw.WriteLine($"{sum:F2}");

            } // using
        } // Main
    } // class
} // namespace