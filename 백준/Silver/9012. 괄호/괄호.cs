using System.Text;

namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder Answer = new StringBuilder();
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
                    Answer.Append("YES\n");
                }
                else
                {
                    Answer.Append("NO\n");
                }

                a = 0;
            }

            Console.Clear();

            Console.WriteLine(Answer);
        }
    }
}
