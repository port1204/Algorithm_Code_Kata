namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {

                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int A = input[0];
                int B = input[1];
                input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int C = input[0];
                int D = input[1];

                double[] sum = new double[4];
                sum[0] = (double)A / C + (double)B / D;
                sum[1] = (double)C / D + (double)A / B;
                sum[2] = (double)D / B + (double)C / A;
                sum[3] = (double)B / A + (double)D / C;

                int answer = 0;
                double max = sum[0];
                for (int i = 1; i < 4; i++)
                {
                    if (sum[i] > max)
                    {
                        max = sum[i];
                        answer = i;
                    }
                }

                sw.WriteLine(answer);
            } // using
        } // Main
    } // class
} // namespace
