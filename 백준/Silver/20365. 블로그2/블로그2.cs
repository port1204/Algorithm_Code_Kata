namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string Paint = Console.ReadLine();
            char[] Color = Paint.ToCharArray();
            int count = 0;
            int answer = 1;

            for (int i = 1; i < N; ++i)
            {
                if(Color[i] == 'B')
                {
                    if (Color[i - 1] == 'R')
                    {
                        ++answer;
                        ++count;
                    }
                }
                else
                {
                    if (Color[i - 1] == 'B')
                    {
                        --count;
                    }
                }
            }

            if (count < 0)
            {
                ++answer;
            }

            Console.WriteLine(answer);
        }
    }
}
