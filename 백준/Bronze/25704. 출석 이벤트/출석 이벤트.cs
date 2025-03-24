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
                int P = int.Parse(sr.ReadLine());

                if (N >= 20)
                {
                    P -= Math.Max((int)(P * 0.25), 2000);
                }
                else if (N >= 15)
                {
                    P -= Math.Max((int)(P * 0.1), 2000);
                }
                else if (N >= 10)
                {
                    P -= Math.Max((int)(P * 0.1), 500);
                }
                else if (N >= 5)
                {
                    P -= 500;
                }

                P = Math.Max(0, P);
                sw.WriteLine(P);
            } // using
        } // Main
    } // class
} // namespace