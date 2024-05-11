namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int a = 0;
            for (int i = 0; i < N; i++)
            {
                a += int.Parse(input[i].ToString());
            }
            Console.Clear();
            Console.WriteLine(a);
        }
    }
}
