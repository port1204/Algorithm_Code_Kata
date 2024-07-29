namespace testcoding
{
    internal class Program
    {

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int N = int.Parse(sr.ReadLine());
                int[] count = new int[10001];

                for (int i = 0; i < N; ++i)
                {
                    int num = int.Parse(sr.ReadLine());
                    count[num]++;
                }

                for (int i = 0; i < count.Length; ++i)
                {
                    for (int j = 0; j < count[i]; ++j)
                    {
                        sw.WriteLine(i);
                    }
                }
            }
        }

    }
}
