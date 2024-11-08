namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int T = int.Parse(sr.ReadLine());
                for (int i = 0; i < T; i++)
                {
                    int N = int.Parse(sr.ReadLine());
                    int TC = 0;
                    float TG = 0;
                    for (int j = 0;  j < N; j++)
                    {
                        string[] input = sr.ReadLine().Split();
                        int C = int.Parse(input[0]);
                        float G = float.Parse(input[1]);
                        TC += C;
                        TG += C * G;
                    }

                    sw.WriteLine($"{TC} {TG / TC:F1}");
                }

            } // using
        } // Main
    } // class
} // ns
