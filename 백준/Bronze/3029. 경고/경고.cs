namespace CodingTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(":");
            int hh = int.Parse(input[0]);
            int mm = int.Parse(input[1]);
            int ss = int.Parse(input[2]);

            string[] input1 = Console.ReadLine().Split(":");
            int hh1 = int.Parse(input1[0]);
            int mm1 = int.Parse(input1[1]);
            int ss1 = int.Parse(input1[2]);

            if (hh > hh1)
            {
                hh1 += 24;
            }
            else if (hh == hh1)
            {
                if(mm > mm1)
                {
                    hh1 += 24;
                }
                else if (mm == mm1)
                {
                    if (ss > ss1)
                    {
                        hh1 += 24;
                    }
                }
            }

            if (ss > ss1)
            {
                ss1 += 60;
                --mm1;
            }

            if (mm > mm1)
            {
                mm1 += 60;
                --hh1;
            }

            if (hh == hh1 && mm == mm1 && ss == ss1)
            {
                hh1 = 24;
                mm1 = 0;
                ss1 = 0;
            }
            else
            {
                hh1 -= hh;
                mm1 -= mm;
                ss1 -= ss;
            }

            Console.WriteLine($"{hh1:D2}:{mm1:D2}:{ss1:D2}");

        }
    }
}