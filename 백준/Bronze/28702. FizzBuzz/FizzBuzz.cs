namespace testcoding
{
    internal class Program
    {

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int num = 0;
                
                for (int i = 0; i < 3; ++i)
                {
                    string input = sr.ReadLine();
                    int.TryParse(input, out num);
                    if (num != 0)
                    {
                        num += 3 - i;
                        break;
                    }
                }

                string answer = "";

                if (num % 3 == 0 && num % 5 == 0)
                {
                    answer = "FizzBuzz";
                }
                else if (num % 3 == 0)
                {
                    answer = "Fizz";
                }
                else if (num % 5 == 0)
                {
                    answer = "Buzz";
                }
                else
                {
                    answer = num.ToString();
                }

                sw.WriteLine(answer);
            }
        }

    }
}
