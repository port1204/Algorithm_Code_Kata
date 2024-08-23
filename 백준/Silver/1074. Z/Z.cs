namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string[] input = sr.ReadLine().Split();
                int N = int.Parse(input[0]);
                int r = int.Parse(input[1]);
                int c = int.Parse(input[2]);

                sw.WriteLine(Z(N, r, c));
            }

            static int Z(int n, int r, int c)
            {
                int answer = 0;

                while (n > 0)
                {
                    int half = (int)Math.Pow(2, n - 1);

                    if (r < half && c < half)
                    {
                    }
                    else if (r < half && c >= half)
                    {
                        answer += half * half;
                        c -= half;
                    }
                    else if (r >= half && c < half)
                    {
                        answer += 2 * half * half;
                        r -= half;
                    }
                    else
                    {
                        answer += 3 * half * half;
                        r -= half;
                        c -= half;
                    }

                    --n;
                }

                return answer;

            }
        }
    }
}