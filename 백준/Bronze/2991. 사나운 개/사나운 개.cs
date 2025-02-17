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
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);
                int C = int.Parse(input[2]);
                int D = int.Parse(input[3]);

                string[] del = sr.ReadLine().Split();
                int P = int.Parse(del[0]);
                int M = int.Parse(del[1]);
                int N = int.Parse(del[2]);

                sw.WriteLine(delivery(P, A, B, C, D));
                sw.WriteLine(delivery(M, A, B, C, D));
                sw.WriteLine(delivery(N, A, B, C, D));


            } // using
        } // Main

        static int delivery(int t, int A, int B, int C, int D)
        {
            int count = 0;

            if (t % (A + B) > 0 && t % (A + B) <= A ) // 1
            {
                count++;
            }

            if (t % (C + D)> 0 && t % (C + D) <= C) // 2
            {
                count++;
            }

            return count;
        }

    } // class
} // namespace