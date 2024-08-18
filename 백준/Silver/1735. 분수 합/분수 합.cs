namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int[] A = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int[] B = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int a = A[1];
                int b = B[1];

                while (a != b)
                {
                    if (a > b)
                    {
                        int temp = a;
                        a = b;
                        b = temp;
                    }
                    if (a % A[1] == 0)
                    {
                        a += A[1];
                    }
                    else
                    {
                        a += B[1];
                    }
                }
                a = ((b / A[1]) * A[0]) + ((b / B[1]) * B[0]);

                for (int i = a; i > 1; --i)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        a /= i;
                        b /= i;
                    }
                }

                sw.WriteLine($"{a} {b}");
            }
        }

    }
}