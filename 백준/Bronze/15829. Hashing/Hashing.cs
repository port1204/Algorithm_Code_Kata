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
                string input = sr.ReadLine();
                long r = 31;
                long rr = 1;
                int M = 1234567891;
                long answer = 0;
                foreach (char c in input)
                {
                    int num = c - 'a' + 1;
                    answer = (answer + num * rr) % M;
                    rr = (rr *r) % M;
                }
                sw.WriteLine(answer);
            }
        }

    }
}