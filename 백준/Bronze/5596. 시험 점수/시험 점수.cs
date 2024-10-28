namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int[] A = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int[] B = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int AA = 0;
                int BB = 0;
                for (int i = 0; i < A.Length; ++i)
                {
                    AA += A[i];
                    BB += B[i];
                }
                sw.WriteLine(Math.Max(AA, BB));
            }
        }


    }
}