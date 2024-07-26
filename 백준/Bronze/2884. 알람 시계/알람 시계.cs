namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                string[] input = sr.ReadLine().Split();
                int H = int.Parse(input[0]);
                int M = int.Parse(input[1]);
                string answer = "";
                M -= 45; 
                if (M < 0)
                {
                    M += 60;
                    --H;
                    if (H == -1)
                    {
                        H = 23;
                    }
                }
                answer += H + " " + M;
                sw.WriteLine(answer);
            }
        }

    }
}
