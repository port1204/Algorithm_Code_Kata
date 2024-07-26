namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int A = int.Parse(sr.ReadLine());
                int B = int.Parse(sr.ReadLine());
                int C = int.Parse(sr.ReadLine());

                sw.WriteLine(A + B - C);

                string sum = A.ToString() + B.ToString() ;
                sw.WriteLine(int.Parse(sum) - C);
            }
        }

    }
}
