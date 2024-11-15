namespace testcoding
{
    internal class Program
    {
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int LCM(int a, int b, int gcd)
        {
            return (a / gcd) * b;
        }

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int T = int.Parse(sr.ReadLine());
                
                for (int i = 0; i < T; i++)
                {
                    string[] input = sr.ReadLine().Split();
                    int a = int.Parse(input[0]);
                    int b = int.Parse(input[1]);

                    int gcd = GCD(a, b);
                    int lcm = LCM(a, b, gcd);

                    sw.WriteLine($"{lcm} {gcd}");
                }
            }
        }
    }
}