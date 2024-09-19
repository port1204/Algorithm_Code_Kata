namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int[,] A = new int[9, 9];
                int max = int.MinValue;
                int h = 0;
                int v = 0;
                for (int i = 0; i < 9; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    for (int j = 0; j < 9; ++j)
                    {
                        A[i, j] = int.Parse(input[j]);
                        if (max < A[i, j])
                        {
                            max = A[i, j];
                            h = j + 1;
                            v = i + 1;
                        }
                    }
                }
                sw.WriteLine(max);
                sw.WriteLine($"{v} {h}");
            }
        }


    }
}