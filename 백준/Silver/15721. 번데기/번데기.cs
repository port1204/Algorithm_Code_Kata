namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int T = int.Parse(Console.ReadLine());
            int QJseorl = int.Parse(Console.ReadLine());

            int p = 2;
            int count = 0;
            int person = 0;

            while ( true )
            {
                for ( int i = 0; i < 4; ++i ) // 뻔 - 데기 - 뻔 - 데기
                {
                    if (i % 2 == QJseorl)
                    {
                        ++count;
                        if (count == T)
                        {
                            Console.WriteLine(person);
                            return;
                        }
                    }
                    person = (person + 1) % A;
                }

                for ( int i = 0; i < p; ++i)
                {
                    if (QJseorl == 0)
                    {
                        ++count;
                        if (count == T)
                        {
                            Console.WriteLine(person);
                            return;
                        }
                    }
                    person = (person + 1) % A;
                }

                for (int i = 0; i < p; ++i)
                {
                    if (QJseorl == 1)
                    {
                        ++count;
                        if (count == T)
                        {
                            Console.WriteLine(person);
                            return;
                        }
                    }
                    person = (person + 1) % A;
                }

                ++p;

            }

        }
    }
}
