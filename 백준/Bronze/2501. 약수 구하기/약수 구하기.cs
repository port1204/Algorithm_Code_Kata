using System.Text;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string[] input = sr.ReadLine().Split();
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);
                int count = 0;
                StringBuilder sb = new StringBuilder();
                for (int i = 1; i <= A; ++i)
                {
                    if (A % i == 0)
                    {
                        ++count;
                        if (B == count)
                        {
                            sb.AppendLine(i.ToString());
                            break;
                        }
                    }
                }

                if (sb.Length > 0)
                {
                    sw.WriteLine(sb);
                }
                else
                {
                    sw.WriteLine(0);
                }

            }
        }


    }
}