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
                int[] A = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int[] B = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int sum = 0;
                Array.Sort(A);
                Array.Sort(B);
                Array.Reverse(B);
                for (int i = 0; i <N; ++i)
                {
                    sum += A[i] * B[i];
                }
                sw.WriteLine(sum);
            }
        } 
    }
}