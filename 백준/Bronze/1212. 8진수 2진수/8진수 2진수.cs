using System.Text;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string input = Console.ReadLine();

            if (input == "0")
            {
                sb.Append("0");
                Console.WriteLine(sb);
            }
            else
            {
                foreach (char c in input)
                {
                    switch (c)
                    {
                        case '0':
                            sb.Append("000");
                            break;
                        case '1':
                            sb.Append("001");
                            break;
                        case '2':
                            sb.Append("010");
                            break;
                        case '3':
                            sb.Append("011");
                            break;
                        case '4':
                            sb.Append("100");
                            break;
                        case '5':
                            sb.Append("101");
                            break;
                        case '6':
                            sb.Append("110");
                            break;
                        case '7':
                            sb.Append("111");
                            break;
                    }
                }
            }

            string answer = sb.ToString().TrimStart('0');
            Console.WriteLine(answer);
        }
    }
}