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
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                List<int> answer = new List<int>(new int[N]);
                for (int i = 0; i < N; ++i)
                {
                    int count = input[i];

                    for (int j = 0; j < N; ++j)
                    {
                        if (answer[j] == 0)
                        {
                            if (count == 0)
                            {
                                answer[j] = i + 1;
                                break;
                            }
                            --count;
                        }
                    }
                }
                sw.WriteLine(string.Join(" ", answer));
            }
        }


    }
}