namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int sum = 0;
                for (int i = 0; i < input.Length; ++i)
                {
                    sum += input[i] * input[i];
                }

                sw.WriteLine(sum%10);
            }
        }//main
    }
}