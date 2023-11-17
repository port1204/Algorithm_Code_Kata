namespace kata_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            int rem = 0;
            while (n > 0)
            {
                rem = n % 10;
                answer += rem;
                n = n / 10;
            }

            return answer;
        }
    }
}