namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                string input = sr.ReadLine();
                int i = int.Parse(sr.ReadLine());
                char[] S = input.ToCharArray();
                sw.WriteLine(S[i - 1]);
            }
        }

    }
}
