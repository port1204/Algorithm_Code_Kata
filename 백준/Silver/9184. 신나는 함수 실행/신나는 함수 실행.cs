using System.ComponentModel.Design;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int a = 0;
                int b = 0; 
                int c = 0;

                int[,,] dp = new int[51, 51, 51];

                int W(int a, int b, int c)
                {
                    if (a <= 0 || b <= 0 || c <= 0)
                    {
                        return 1;
                    }
                    else if (a > 20 || b > 20 || c > 20)
                    {
                        return W(20, 20, 20);
                    }
                    else if (dp[a, b, c] != 0)
                    {
                        return dp[a, b, c];
                    }
                    else if (a < b && b < c)
                    {
                        return dp[a, b, c] = W(a, b, c - 1) + W(a, b - 1, c - 1) - W(a, b - 1, c);
                    }
                    else
                    {
                        return dp[a, b, c] = W(a - 1, b, c) + W(a - 1, b - 1, c) + W(a - 1, b, c - 1) - W(a - 1, b - 1, c - 1);
                    }

                }

                while (true)
                {
                    string[] input = sr.ReadLine().Split();
                    a = int.Parse(input[0]);
                    b = int.Parse(input[1]);
                    c = int.Parse(input[2]);

                    if (a == -1 && b == -1 && c == -1)
                    {
                        break;
                    }

                    sw.WriteLine($"w({a}, {b}, {c}) = {W(a, b, c)}");
                }


            } // using
        } // Main
    } // class
} // namespace