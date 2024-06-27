namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double answer = 0;
            int N = int.Parse(Console.ReadLine());
            double[] Drink = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
            Array.Sort(Drink);
            Array.Reverse(Drink);
            answer += Drink[0];
            for (int i = 1; i < N; ++i)
            {
                answer += Drink[i] / 2; 
            }
            Console.WriteLine(answer);
        }
    }
}
