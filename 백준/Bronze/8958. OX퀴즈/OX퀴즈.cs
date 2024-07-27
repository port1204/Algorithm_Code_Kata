using System.Security.Cryptography;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int T = int.Parse(sr.ReadLine());

                for (int i = 0; i < T; ++i)
                {
                    int sum = 0;
                    int count = 1;
                    string ox = sr.ReadLine();
                    for (int j = 0; j < ox.Length; ++j)
                    {
                        if (ox[j] == 'O')
                        {
                            sum += count;
                            ++count;
                        }
                        else
                        {
                            count = 1;
                        }
                    }
                    sw.WriteLine(sum);
                }

            }
        }

    }
}
