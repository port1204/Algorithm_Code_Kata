namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long answer = (long)Math.Sqrt(N);
            if (N > answer * answer)
            {
                ++answer;
            }
            Console.WriteLine(answer);
        }// main
    }
}