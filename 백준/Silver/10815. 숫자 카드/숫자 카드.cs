namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] A = Console.ReadLine().Split();
            int M = int.Parse(Console.ReadLine());
            string[] B = Console.ReadLine().Split();
            string[] answer = new string[M];
            HashSet<string> setA = new HashSet<string>(A);
            for (int i = 0; i < M; ++i)
            {
                if (setA.Contains(B[i]))
                {
                    answer[i] = "1";
                }
                else
                {
                    answer[i] = "0";
                }
            }
            Console.WriteLine(string.Join(" ", answer));
        }// main
    }
}
