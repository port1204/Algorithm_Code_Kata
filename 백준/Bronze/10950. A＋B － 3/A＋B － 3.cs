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
                for (int i = 0; i < T; i++)
                {
                    string[] input = sr.ReadLine().Split();
                    int A = int.Parse(input[0]);
                    int B = int.Parse(input[1]);
                    sw.WriteLine(A + B);
                }
            }
        }//main
    }
}