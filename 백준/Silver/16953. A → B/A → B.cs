using System.Data;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long A = long.Parse(input[0]);
            long B = long.Parse(input[1]);
            int count = 1;

            long C(long num)
            {
                num /= 2;
                return num;
            }

            long D(long num)
            {
                num = (num - 1) / 10;
                return num;
            }

            while (A < B)
            {
                if (B % 10 == 1)
                {
                    B = D(B);
                    ++count;
                }
                else
                {
                    if (B % 2 != 0) { break; }
                    B = C(B);
                    ++count;
                }
            }

            if (A == B)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
