namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            List<string> Answer = new List<string>();
            int a = 0;

            for (int i = 0; i < T; ++i)
            {
                string input = Console.ReadLine();
                foreach( char c in input )
                {
                    if ( c == '(')
                    {
                        ++a;
                    }
                    else if ( c == ')' )
                    {
                        --a;
                        if( a < 0)
                        {
                            break;
                        }
                    }
                }

                if ( a == 0 )
                {
                    Answer.Add("YES");
                }
                else if ( a < 0)
                {
                    Answer.Add("NO");
                }
                else
                {
                    Answer.Add("NO");
                }

                a = 0;
            }

            Console.Clear();

            foreach (var answer in Answer)
            {
                Console.WriteLine(answer);
            }
        }
    }
}
