namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int answer = 0;
                int T = int.Parse(sr.ReadLine());
                int[] human = { 1, 2, 3, 3, 4, 10 };
                int[] enemy = { 1, 2, 2, 2, 3, 5, 10 };
                for (int i = 0; i < T; i++)
                {
                    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    int sum1 = 0;
                    for (int j = 0; j < input.Length; j++)
                    {
                        sum1 += input[j] * human[j];
                    }

                    input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    int sum2 = 0;
                    for (int j = 0; j < input.Length; j++)
                    {
                        sum2 += input[j] * enemy[j];
                    }

                    if (sum1 > sum2)
                    {
                        sw.WriteLine($"Battle {i + 1}: Good triumphs over Evil");
                    }
                    else if (sum1 == sum2)
                    {
                        sw.WriteLine($"Battle {i + 1}: No victor on this battle field");
                    }
                    else
                    {
                        sw.WriteLine($"Battle {i + 1}: Evil eradicates all trace of Good");
                    }

                }

            } // using
        } // Main
    } // class
} // namespace