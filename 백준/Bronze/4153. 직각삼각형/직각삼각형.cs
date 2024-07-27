namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                while (true)
                {
                    string[] input = sr.ReadLine().Split();
                    Array.Sort(input);
                    int a = int.Parse(input[0]);
                    int b = int.Parse(input[1]);
                    int c = int.Parse(input[2]);
                    if (a == 0 && b == 0 && c == 0) break;

                    if (a > b)
                    {
                        int temp = a;
                        a = b;
                        b = temp;
                    }
                    if (b > c)
                    {
                        int temp = b;
                        b = c;
                        c = temp;
                    }
                    if (a > b)
                    {
                        int temp = a;
                        a = b;
                        b = temp;
                    }

                    if ( (c * c) == (a * a) + (b * b))
                    {
                        sw.WriteLine("right");
                    }
                    else
                    {
                        sw.WriteLine("wrong");
                    }

                }
            }
        }

    }
}
