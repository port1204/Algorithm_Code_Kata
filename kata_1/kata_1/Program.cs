namespace kata_1
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
        public string solution(int num)
        {
            string answer = "";
            if (num % 2 == 0)
            {
                answer = "Even";
            }
            else
                answer = "Odd";

            return answer;
        }
    }
}