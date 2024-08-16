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
                int T = int.Parse(sr.ReadLine());
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                int answer = 0;
                if (input.Length == 1)
                {
                    answer = input[0] * input[0];
                }
                else
                {
                    Array.Sort(input);
                    answer = input[0] * input[input.Length - 1];
                }

                sw.WriteLine(answer);

            }
        }
    }
}