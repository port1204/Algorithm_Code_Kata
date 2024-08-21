namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int T = int.Parse(sr.ReadLine());
                for (int  i = 0; i < T; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    int M = int.Parse(input[0]);
                    int N = int.Parse(input[1]);
                    int x = int.Parse(input[2]);
                    int y = int.Parse(input[3]);

                    int a = LCM(M, N);
                    int answer = -1;

                    for (int j = x; j <= a; j += M)
                    {
                        if ((j - 1) % N + 1 == y)
                        {
                            answer = j;
                            break;
                        }
                    }

                    sw.WriteLine(answer);
                }
            }
        }

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

        static int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }

    }
}