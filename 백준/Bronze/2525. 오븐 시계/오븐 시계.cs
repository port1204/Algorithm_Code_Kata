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
                int C = int.Parse(sr.ReadLine());
                int D = B + C;

                A += D / 60;
                B = D % 60;  
                A %= 24;

                sw.WriteLine($"{A} {B}");
            }
        }


    }
}