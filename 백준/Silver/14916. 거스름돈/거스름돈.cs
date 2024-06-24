namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int answer = 0;

            int A(int input)
            {
                if (input < 2)
                {
                    answer = -1;
                }
                else if (input % 5 == 0)
                {
                    answer += input / 5;
                }
                else if (input % 2 == 0 && input < 10)
                {
                    answer += input / 2;
                }
                else
                {
                    ++answer;
                    input -= 5;
                    A(input);
                }

                return answer;
            }

            A(input);


            Console.WriteLine(answer);
        }
    }
}
