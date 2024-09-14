namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());
                int a = N / 4;
                string word1 = "long";
                string  answer = String.Join(" ", new string[a].Select(_ => word1));
                answer += " int";
                sw.WriteLine(answer);
            }
        }


    }
}