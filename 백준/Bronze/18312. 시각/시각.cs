namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);
            
            int hour = 0;
            int minute = 0;
            int second = 0;

            int count = 0;

            while( N >= hour)
            {
                ++second;

                if (second / 10 == K ||  second % 10 == K || minute / 10 == K || minute % 10 == K || hour / 10 == K || hour % 10 == K)
                {
                    ++count;
                }


                if (second == 60)
                {
                    second = 0;
                    ++minute;
                }

                if (minute == 60)
                {
                    minute = 0;
                    ++hour;
                }
            }

            Console.WriteLine(count);
        }
    }
}
