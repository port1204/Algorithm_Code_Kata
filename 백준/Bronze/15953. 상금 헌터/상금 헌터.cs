namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int[] A = { 500, 300, 200, 50, 30, 10 };
                int[] AA = { 1, 2, 3, 4, 5, 6 };
                int[] B = { 512, 256, 128, 64, 32 }; 
                int[] BB = { 1, 2, 4, 8, 16 };

                int T = int.Parse(sr.ReadLine());

                for (int i = 0; i < T; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    int AAA = int.Parse(input[0]);
                    int BBB = int.Parse(input[1]);
                    int money = 0;

                    int position = 0;
                    for (int j = 0; j < AA.Length; ++j)
                    {
                        position += AA[j];
                        if (AAA > 0 && AAA <= position)
                        {
                            money += A[j];
                            break;
                        }
                    }

                    position = 0;
                    for (int j = 0; j < BB.Length; ++j)
                    {
                        position += BB[j];
                        if (BBB > 0 && BBB <= position)
                        {
                            money += B[j];
                            break;
                        }
                    }

                    sw.WriteLine(money * 10000);
                }

            } // using
        } // Main
    } // class
} // ns
