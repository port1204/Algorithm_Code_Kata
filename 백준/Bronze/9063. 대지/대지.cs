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
                if (N == 1)
                {
                    sw.WriteLine(0);
                }
                else
                {
                    int[] a = new int[N];
                    int[] b = new int[N];
                    for (int i = 0; i < N; ++i)
                    {
                        string[] input = sr.ReadLine().Split();
                        a[i] = int.Parse(input[0]);
                        b[i] = int.Parse(input[1]);
                    }

                    int answer = (a.Max() - a.Min()) * (b.Max() - b.Min());
                    sw.WriteLine(answer);
                }
            }
        }


    }
}