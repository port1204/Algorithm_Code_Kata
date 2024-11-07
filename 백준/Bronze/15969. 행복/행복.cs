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
                Array.Sort(A);
                sw.WriteLine(A[A.Length - 1] - A[0]);
            } // using
        } // Main
    } // class
} // ns
