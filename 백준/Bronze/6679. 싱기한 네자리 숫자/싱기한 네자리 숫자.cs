namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                for (int i = 1000; i <= 9999; i++)
                {
                    int A = sum(i, 10);
                    int B = sum(i, 12);
                    int C = sum(i, 16);

                    if (A == B && B == C)
                    {
                        sw.WriteLine(i);
                    }
                }
            } // using
        } // Main

        static int sum(int num, int ttt)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % ttt;
                num /= ttt;
            }
            return sum;
        }
    } // class
} // namespace