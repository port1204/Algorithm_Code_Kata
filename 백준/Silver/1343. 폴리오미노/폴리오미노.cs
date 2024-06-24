using System.Text;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            string input = Console.ReadLine();
            int count = 0;

            foreach(char c in input)
            {
                if(c == 'X')
                {
                    ++count;
                }
                else if (c == '.')
                {
                    if (count % 2 != 0)
                    {
                        answer = "-1";
                        break;
                    }
                    else
                    {
                        A(count);
                    }
                    count = 0;
                    answer += ".";
                }
            }

            if (count % 2 != 0)
            {
                answer = "-1";
            }
            else
            {
                A(count);
            }

            Console.WriteLine(answer);

            string A(int count)
            {
                while (count != 0)
                {
                    if (count >= 4)
                    {
                        answer += "AAAA";
                        count -= 4;
                    }
                    else if (count >= 2)
                    {
                        answer += "BB";
                        count -= 2;
                    }
                }
                return answer;
            }

        }
    }
}
