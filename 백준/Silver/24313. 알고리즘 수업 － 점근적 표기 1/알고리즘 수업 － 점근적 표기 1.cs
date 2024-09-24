namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                long[] A = Array.ConvertAll(sr.ReadLine().Split(), long.Parse);
                long C = long.Parse(sr.ReadLine());
                long N = long.Parse(sr.ReadLine());

                if ((A[0] * N) + A[1] <= C * N && A[0] <= C)
                {
                    sw.WriteLine(1);
                }
                else
                {
                    sw.WriteLine(0);
                }
            }
        }


    }
}