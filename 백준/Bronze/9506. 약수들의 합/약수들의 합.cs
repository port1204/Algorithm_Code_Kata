using System.Text;

namespace testcoding
{
    internal class Program
    {
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                while (true)
                {
                    int N = int.Parse(sr.ReadLine());
                    if (N == -1) break;

                    List<int> nums = new List<int>();
                    int sum = 0;
                    for (int i = 1; i < N; i++)
                    {
                        if (N % i == 0)
                        {
                            nums.Add(i);
                            sum += i;
                        }
                    }

                    if (sum == N)
                    {
                        sb.AppendLine($"{N} = {string.Join(" + ", nums)}");
                    }
                    else
                    {
                        sb.AppendLine($"{N} is NOT perfect.");
                    }
                }
                sw.WriteLine( sb.ToString() );
            }
        }

    }
}