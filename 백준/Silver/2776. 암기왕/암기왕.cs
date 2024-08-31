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
                for (int i = 0; i < T; ++i)
                {
                    int N = int.Parse(sr.ReadLine());
                    string[] A = sr.ReadLine().Split();
                    Array.Sort(A);
                    int M = int.Parse(sr.ReadLine());
                    string[] B = sr.ReadLine().Split();

                    string[] answer = new string[M];
                    for (int j  = 0; j < M; ++j)
                    {
                        if (Array.BinarySearch(A, B[j]) >= 0)
                        {
                            answer[j] = "1";
                        }
                        else
                        {
                            answer[j] = "0";
                        }
                    }
                    sw.WriteLine(string.Join("\n", answer));
                }
            }
        }
    }
}