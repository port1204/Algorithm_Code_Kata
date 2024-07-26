namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                string[] input;

                while (true)
                {
                    input = sr.ReadLine().Split();
                    int A = int.Parse(input[0]);
                    int B = int.Parse(input[1]);
                    if (A == 0 && B == 0) break;
                    sw.WriteLine(A + B);
                }
            }
        }//main
    }
}