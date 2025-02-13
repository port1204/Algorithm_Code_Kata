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
                int D = int.Parse(input[0]);
                int H = int.Parse(input[1]);
                int M = int.Parse(input[2]);

                int curNum = 11;

                int sm = (curNum * 24 * 60) + (curNum * 60) + curNum;
                int em = (D * 24 * 60) + (H * 60) + M;

                if (em < sm)
                {
                    sw.WriteLine(-1);
                }
                else
                {
                    sw.WriteLine(em - sm);
                }

            } // using
        } // Main
    } // class
} // namespace