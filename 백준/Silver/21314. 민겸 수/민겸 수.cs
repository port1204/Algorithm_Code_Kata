namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] MK = input.ToCharArray();
            string MaxA = "";
            string MinA = "";
            int count = 0;

            for (long i = 0; i < MK.Length; ++i)
            {
                if (MK[i] == 'M') 
                {
                    ++count;
                }
                else if (MK[i] == 'K')
                {
                    long Max = (long)(5 * Math.Pow(10, count));
                    if (count == 0) { Max = 5; MinA += "5"; }
                    else { MinA += (long)Math.Pow(10, count) + 5; }
                    MaxA += Max;
                    count = 0;
                }
            }

            if (count > 0)
            {
                for (int i = 0; i < count; ++i)
                {
                    MaxA += '1';
                }
                MinA += '1';
                for (int i = 1; i < count; ++i)
                {
                    MinA += '0';
                }
            }


            Console.WriteLine(MaxA);
            Console.WriteLine(MinA);
        }
    }
}

