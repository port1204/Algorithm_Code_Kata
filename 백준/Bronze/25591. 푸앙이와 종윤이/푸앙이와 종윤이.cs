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
                int inputA = int.Parse(input[0]);
                int inputB = int.Parse(input[1]);

                int a = 100 - inputA;
                int b = 100 - inputB;
                int c = 100 - (a + b);
                int d = a * b;
                int q = 0;
                int r = d;
                string str = d.ToString();

                if (str.Length >= 3)
                {
                    int cutLine = str.Length - 2;
                    q = int.Parse(str.Substring(0, cutLine));
                    r = int.Parse(str.Substring(cutLine));
                }

                sw.WriteLine($"{a} {b} {c} {d} {q} {r}");
                sw.WriteLine($"{c + q} {r}");

            } // using
        } // Main
    } // class
} // namespace