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
                    int[] A = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    sw.WriteLine(2 - A[0] + A[1]);
                }


            } // using
        } // Main
    } // class
} // ns
