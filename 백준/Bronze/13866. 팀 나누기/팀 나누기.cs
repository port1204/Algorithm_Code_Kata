namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                Array.Sort(input);

                int answer1 = Math.Abs((input[3] + input[0]) - (input[2] + input[1]));
                int answer2 = Math.Abs((input[3] + input[1]) - (input[2] + input[0]));

                int answer = Math.Min(answer1, answer2);
                sw.WriteLine(answer);
            }
        }
    }
}
